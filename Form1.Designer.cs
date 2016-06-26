namespace AlekhinesGunConfigurator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Sequence = new System.Windows.Forms.CheckBox();
            this.B_Add = new System.Windows.Forms.Button();
            this.B_Clear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ListBox_Files = new System.Windows.Forms.ListBox();
            this.B_Convert = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.B_BrowseOutputDirectory = new System.Windows.Forms.Button();
            this.TB_OutputDirectory = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.L_CompressionQuality = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar_Quality = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TB_FPS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_DoCleanUp = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 619);
            this.panel1.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.B_Convert, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(645, 619);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ListBox_Files, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(639, 475);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 159F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel3.Controls.Add(this.CB_DoCleanUp, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.CB_Sequence, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.B_Add, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.B_Clear, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(4, 443);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(631, 28);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CB_Sequence
            // 
            this.CB_Sequence.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_Sequence.AutoSize = true;
            this.CB_Sequence.Checked = true;
            this.CB_Sequence.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_Sequence.Location = new System.Drawing.Point(4, 5);
            this.CB_Sequence.Name = "CB_Sequence";
            this.CB_Sequence.Size = new System.Drawing.Size(124, 17);
            this.CB_Sequence.TabIndex = 0;
            this.CB_Sequence.Text = "Animation Sequence";
            this.CB_Sequence.UseVisualStyleBackColor = true;
            this.CB_Sequence.CheckedChanged += new System.EventHandler(this.CB_Sequence_CheckedChanged);
            // 
            // B_Add
            // 
            this.B_Add.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Add.Location = new System.Drawing.Point(441, 4);
            this.B_Add.Name = "B_Add";
            this.B_Add.Size = new System.Drawing.Size(75, 20);
            this.B_Add.TabIndex = 1;
            this.B_Add.Text = "Add files";
            this.B_Add.UseVisualStyleBackColor = true;
            this.B_Add.Click += new System.EventHandler(this.B_Add_Click);
            // 
            // B_Clear
            // 
            this.B_Clear.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Clear.Location = new System.Drawing.Point(542, 4);
            this.B_Clear.Name = "B_Clear";
            this.B_Clear.Size = new System.Drawing.Size(75, 20);
            this.B_Clear.TabIndex = 2;
            this.B_Clear.Text = "Clear list";
            this.B_Clear.UseVisualStyleBackColor = true;
            this.B_Clear.Click += new System.EventHandler(this.B_Clear_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Input files:";
            // 
            // ListBox_Files
            // 
            this.ListBox_Files.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListBox_Files.FormattingEnabled = true;
            this.ListBox_Files.Items.AddRange(new object[] {
            "Item",
            "Item2"});
            this.ListBox_Files.Location = new System.Drawing.Point(4, 26);
            this.ListBox_Files.Name = "ListBox_Files";
            this.ListBox_Files.Size = new System.Drawing.Size(631, 410);
            this.ListBox_Files.TabIndex = 2;
            // 
            // B_Convert
            // 
            this.B_Convert.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_Convert.Location = new System.Drawing.Point(279, 589);
            this.B_Convert.Name = "B_Convert";
            this.B_Convert.Size = new System.Drawing.Size(87, 22);
            this.B_Convert.TabIndex = 1;
            this.B_Convert.Text = "Convert!";
            this.B_Convert.UseVisualStyleBackColor = true;
            this.B_Convert.Click += new System.EventHandler(this.B_Convert_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.B_BrowseOutputDirectory, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.TB_OutputDirectory, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 484);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(639, 34);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Output directory:";
            // 
            // B_BrowseOutputDirectory
            // 
            this.B_BrowseOutputDirectory.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.B_BrowseOutputDirectory.Location = new System.Drawing.Point(594, 6);
            this.B_BrowseOutputDirectory.Name = "B_BrowseOutputDirectory";
            this.B_BrowseOutputDirectory.Size = new System.Drawing.Size(35, 21);
            this.B_BrowseOutputDirectory.TabIndex = 2;
            this.B_BrowseOutputDirectory.Text = "...";
            this.B_BrowseOutputDirectory.UseVisualStyleBackColor = true;
            this.B_BrowseOutputDirectory.Click += new System.EventHandler(this.B_BrowseOutputDirectory_Click);
            // 
            // TB_OutputDirectory
            // 
            this.TB_OutputDirectory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_OutputDirectory.Location = new System.Drawing.Point(99, 4);
            this.TB_OutputDirectory.Name = "TB_OutputDirectory";
            this.TB_OutputDirectory.Size = new System.Drawing.Size(482, 20);
            this.TB_OutputDirectory.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 55);
            this.panel2.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.panel4, 2, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(639, 55);
            this.tableLayoutPanel5.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Quality:";
            // 
            // L_CompressionQuality
            // 
            this.L_CompressionQuality.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.L_CompressionQuality.AutoSize = true;
            this.L_CompressionQuality.Location = new System.Drawing.Point(232, 34);
            this.L_CompressionQuality.Name = "L_CompressionQuality";
            this.L_CompressionQuality.Size = new System.Drawing.Size(23, 13);
            this.L_CompressionQuality.TabIndex = 2;
            this.L_CompressionQuality.Text = "%%";
            this.L_CompressionQuality.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.L_CompressionQuality);
            this.panel3.Controls.Add(this.trackBar_Quality);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(99, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 47);
            this.panel3.TabIndex = 3;
            // 
            // trackBar_Quality
            // 
            this.trackBar_Quality.Location = new System.Drawing.Point(3, -1);
            this.trackBar_Quality.Maximum = 100;
            this.trackBar_Quality.Name = "trackBar_Quality";
            this.trackBar_Quality.Size = new System.Drawing.Size(479, 45);
            this.trackBar_Quality.TabIndex = 3;
            this.trackBar_Quality.Value = 50;
            this.trackBar_Quality.Scroll += new System.EventHandler(this.trackBar_Quality_Scroll);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.TB_FPS);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(588, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(47, 47);
            this.panel4.TabIndex = 4;
            // 
            // TB_FPS
            // 
            this.TB_FPS.Location = new System.Drawing.Point(4, 23);
            this.TB_FPS.Name = "TB_FPS";
            this.TB_FPS.Size = new System.Drawing.Size(40, 20);
            this.TB_FPS.TabIndex = 0;
            this.TB_FPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_FPS.TextChanged += new System.EventHandler(this.TB_FPS_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "FPS:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CB_DoCleanUp
            // 
            this.CB_DoCleanUp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_DoCleanUp.AutoSize = true;
            this.CB_DoCleanUp.Checked = true;
            this.CB_DoCleanUp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CB_DoCleanUp.Location = new System.Drawing.Point(272, 5);
            this.CB_DoCleanUp.Name = "CB_DoCleanUp";
            this.CB_DoCleanUp.Size = new System.Drawing.Size(150, 17);
            this.CB_DoCleanUp.TabIndex = 3;
            this.CB_DoCleanUp.Text = "Remove frames after work";
            this.CB_DoCleanUp.UseVisualStyleBackColor = true;
            this.CB_DoCleanUp.CheckedChanged += new System.EventHandler(this.CB_DoCleanUp_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 619);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Sui\'s WebP GUI";
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Quality)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.CheckBox CB_Sequence;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_Clear;
        private System.Windows.Forms.Button B_Add;
        private System.Windows.Forms.ListBox ListBox_Files;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button B_BrowseOutputDirectory;
        private System.Windows.Forms.TextBox TB_OutputDirectory;
        private System.Windows.Forms.Button B_Convert;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label L_CompressionQuality;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar_Quality;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_FPS;
        private System.Windows.Forms.CheckBox CB_DoCleanUp;
    }
}

