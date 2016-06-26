using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace AlekhinesGunConfigurator
{
    public partial class Form1 : Form
    {
        #region Properties
        public bool isAnimationSequence { get; set; }
        public bool cleanUp { get; set; }
        public string currentDirectory { get; set; }
        public string outputDirectory { get; set; }
        public int quality { get; set; }
        public int fps { get; set; }
        public List<string> files { get; set; }
        #endregion

        public Form1()
        {
            InitializeComponent();
            currentDirectory = Directory.GetCurrentDirectory();
            if (!checkIfWebpExists())
            {
                MessageBox.Show(String.Format("No libwebp files found in current directory!\n\nPlease download libwebp and place its files in:\n {0}", currentDirectory), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Process.Start("https://developers.google.com/speed/webp/docs/precompiled");
            }
            setDefaults();
            
        }

        private void setDefaults()
        {
            quality = 50;
            fps = 30;   //probably there is a ton of people screaming now!
            cleanUp = true;
            outputDirectory = Path.Combine(currentDirectory, "output");
            isAnimationSequence = true;
            files = new List<string>();
            ListBox_Files.DataSource = null;

            TB_OutputDirectory.DataBindings.Add("Text", this, "outputDirectory", false, DataSourceUpdateMode.OnPropertyChanged);
            trackBar_Quality.DataBindings.Add("Value", this, "quality", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_DoCleanUp.DataBindings.Add("Checked", this, "cleanUp", false, DataSourceUpdateMode.OnPropertyChanged);
            CB_Sequence.DataBindings.Add("Checked", this, "isAnimationSequence", false, DataSourceUpdateMode.OnPropertyChanged);
            TB_FPS.Text = fps.ToString();
            ListBox_Files.DataSource = files;
            L_CompressionQuality.Text = String.Format("{0} %", quality);

        }

        private void convert()
        {
            bool allFineFlag = true;
            Directory.CreateDirectory(outputDirectory);

            //Prepare CMD file to convert images to WebP
            string commands = "";
            string animationVars = "";
            foreach (string file in files)
            {
                string name = new FileInfo(file).Name;
                name = name.Substring(0, name.LastIndexOf('.')) + ".webp";
                commands += string.Format("{0} -q {1} {2} -o {3}",
                    Path.Combine("libwebp", "bin", "cwebp.exe"),
                    quality,
                    String.Format("\"{0}\"", file),
                    String.Format("\"{0}\"", Path.Combine(outputDirectory, name))) + "\n";
            }

            //If is animation prepare WebP animation
            if (isAnimationSequence)
            {
                Directory.CreateDirectory(Path.Combine(outputDirectory, "animated"));
                Bitmap temp = new Bitmap(files[0]);
                int width = temp.Width;
                int height = temp.Height;
                temp.Dispose();

                string framesVars = " ";
                int freeze_time = (int)(1000 / fps * 1.0f);

                foreach (string file in files)
                {
                    Bitmap checkBitmap = new Bitmap(files[0]);
                    if(checkBitmap.Width != width || checkBitmap.Height != height)
                    {
                        allFineFlag = false;
                        break;
                    }

                    //This is reduntent - but it doesn't matter much...
                    string name = new FileInfo(file).Name;
                    name = name.Substring(0, name.LastIndexOf('.')) + ".webp";

                    framesVars += String.Format("-frame {0} +{1} ",
                        String.Format("\"{0}\"", Path.Combine(outputDirectory, name)),
                        freeze_time);
                    checkBitmap.Dispose();
                }

                framesVars += "-loop 0 -o \""
                    + Path.Combine(outputDirectory, "animated", "anim.webp") +"\"";

                animationVars = framesVars;
            }

            if (allFineFlag)
            {
                File.WriteAllText("task.cmd", commands);

                Process webpConversion = new Process();
                webpConversion.StartInfo.FileName = "task.cmd";
                webpConversion.EnableRaisingEvents = true;
                webpConversion.Start();
                webpConversion.WaitForExit();

                //Cleanup
                if (File.Exists("task.cmd"))
                    File.Delete("task.cmd");

                if (isAnimationSequence)
                {
                    Process animConversion = new Process();
                    animConversion.StartInfo.FileName = Path.Combine("libwebp", "bin", "webpmux.exe");
                    animConversion.StartInfo.Arguments = animationVars;
                    animConversion.EnableRaisingEvents = true;
                    animConversion.Start();
                    animConversion.WaitForExit();
                }


                if(cleanUp)
                {
                    foreach(string file in files)
                    {
                        //OK, I really have to do something about it....
                        string name = new FileInfo(file).Name;
                        name = name.Substring(0, name.LastIndexOf('.')) + ".webp";
                        File.Delete(Path.Combine(outputDirectory, name));
                    }
                }
                Process.Start(outputDirectory);
            }
            else
                MessageBox.Show("To create an animation, all images have to have the same width and height!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void calculateCanvasSize(int width, int height, int amountOfFrames, out int canvasWidth, out int canvasHeight)
        {
            throw new NotImplementedException();
        }



        #region Events
        private void B_Add_Click(object sender, EventArgs e)
        {
            ListBox_Files.DataSource = null;
            OpenFileDialog fd = new OpenFileDialog();
            fd.Multiselect = true;
            fd.Filter = string.Join("|", new string[]
            {
                "Graphics formats|*.png;*.jpg;*.jpeg",
                "Portable Graphics|*.png",
                "JPG|*.jpg,*.jpeg"
            });

            if (fd.ShowDialog() == DialogResult.OK)
            {
                foreach (string file in fd.FileNames)
                {
                    files.Add(file);
                }
            }
            ListBox_Files.DataSource = files;
        }

        private void B_Clear_Click(object sender, EventArgs e)
        {
            files.Clear();
            ListBox_Files.DataSource = null;
        }

        private void trackBar_Quality_Scroll(object sender, EventArgs e)
        {
            L_CompressionQuality.Text = String.Format("{0} %", quality);
        }

        private void TB_FPS_TextChanged(object sender, EventArgs e)
        {
            int value;
            if (int.TryParse(TB_FPS.Text, out value))
            {
                fps = value;
            }
        }
        #endregion

        #region GenericHelpingFunctions
        private bool checkIfWebpExists()
        {
            if (!Directory.Exists(Path.Combine(currentDirectory, "libwebp")))
                Directory.CreateDirectory(Path.Combine(currentDirectory, "libwebp"));
            bool isValid = true;
            if (!File.Exists(Path.Combine(currentDirectory, "libwebp", "bin", "freeglut.dll")))
                isValid = false;
            if (!File.Exists(Path.Combine(currentDirectory, "libwebp", "bin", "webpmux.exe")))
                isValid = false;
            if (!File.Exists(Path.Combine(currentDirectory, "libwebp", "bin", "cwebp.exe")))
                isValid = false;
            if (!File.Exists(Path.Combine(currentDirectory, "libwebp", "bin", "anim_diff.exe")))
                isValid = false;
            return isValid;
        }

        #endregion

        private void B_Convert_Click(object sender, EventArgs e)
        {
            convert();
        }

        private void B_BrowseOutputDirectory_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if(fbd.ShowDialog() == DialogResult.OK)
            {
                outputDirectory = fbd.SelectedPath;
                TB_OutputDirectory.Text = outputDirectory;
            }
        }

        private void CB_DoCleanUp_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void CB_Sequence_CheckedChanged(object sender, EventArgs e)
        {
            if (CB_Sequence.Checked)
                CB_DoCleanUp.Enabled = true;
            else
            {
                CB_DoCleanUp.Enabled = false;
                cleanUp = false;
            }
        }
    }
}
