namespace SegundoDIP
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openCameraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openForegroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.inputFilterBox = new System.Windows.Forms.PictureBox();
            this.outputFilterBox = new System.Windows.Forms.PictureBox();
            this.chooseFilterButton = new System.Windows.Forms.Button();
            this.saveOutputButton = new System.Windows.Forms.Button();
            this.filterSelect = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.subtractButton = new System.Windows.Forms.Button();
            this.subtractedBox = new System.Windows.Forms.PictureBox();
            this.backgroundBox = new System.Windows.Forms.PictureBox();
            this.foregroundBox = new System.Windows.Forms.PictureBox();
            this.chooseFilterSubtractedButton = new System.Windows.Forms.Button();
            this.saveSubtractedButton = new System.Windows.Forms.Button();
            this.filterSubtractedSelect = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.saveFileDialog2 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputFilterBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFilterBox)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.subtractedBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundBox)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openBackgroundToolStripMenuItem,
            this.openCameraToolStripMenuItem,
            this.openForegroundToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openBackgroundToolStripMenuItem
            // 
            this.openBackgroundToolStripMenuItem.Name = "openBackgroundToolStripMenuItem";
            this.openBackgroundToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openBackgroundToolStripMenuItem.Text = "Open Background";
            this.openBackgroundToolStripMenuItem.Click += new System.EventHandler(this.openBackgroundToolStripMenuItem_Click);
            // 
            // openCameraToolStripMenuItem
            // 
            this.openCameraToolStripMenuItem.Name = "openCameraToolStripMenuItem";
            this.openCameraToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openCameraToolStripMenuItem.Text = "Open Camera";
            this.openCameraToolStripMenuItem.Click += new System.EventHandler(this.openCameraToolStripMenuItem_Click);
            // 
            // openForegroundToolStripMenuItem
            // 
            this.openForegroundToolStripMenuItem.Enabled = false;
            this.openForegroundToolStripMenuItem.Name = "openForegroundToolStripMenuItem";
            this.openForegroundToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.openForegroundToolStripMenuItem.Text = "Open Foreground";
            this.openForegroundToolStripMenuItem.Click += new System.EventHandler(this.openForegroundToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "1";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1233, 565);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.inputFilterBox);
            this.tabPage1.Controls.Add(this.outputFilterBox);
            this.tabPage1.Controls.Add(this.chooseFilterButton);
            this.tabPage1.Controls.Add(this.saveOutputButton);
            this.tabPage1.Controls.Add(this.filterSelect);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1225, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Filters";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // inputFilterBox
            // 
            this.inputFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.inputFilterBox.Location = new System.Drawing.Point(19, 19);
            this.inputFilterBox.Name = "inputFilterBox";
            this.inputFilterBox.Size = new System.Drawing.Size(500, 500);
            this.inputFilterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.inputFilterBox.TabIndex = 6;
            this.inputFilterBox.TabStop = false;
            this.inputFilterBox.Click += new System.EventHandler(this.inputFilterBox_Click);
            // 
            // outputFilterBox
            // 
            this.outputFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.outputFilterBox.Location = new System.Drawing.Point(702, 19);
            this.outputFilterBox.Name = "outputFilterBox";
            this.outputFilterBox.Size = new System.Drawing.Size(500, 500);
            this.outputFilterBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.outputFilterBox.TabIndex = 5;
            this.outputFilterBox.TabStop = false;
            this.outputFilterBox.Click += new System.EventHandler(this.outputFilterBox_Click);
            // 
            // chooseFilterButton
            // 
            this.chooseFilterButton.Enabled = false;
            this.chooseFilterButton.Location = new System.Drawing.Point(542, 232);
            this.chooseFilterButton.Name = "chooseFilterButton";
            this.chooseFilterButton.Size = new System.Drawing.Size(133, 42);
            this.chooseFilterButton.TabIndex = 4;
            this.chooseFilterButton.Text = "Choose Filter";
            this.chooseFilterButton.UseVisualStyleBackColor = true;
            this.chooseFilterButton.Click += new System.EventHandler(this.chooseFilterButton_Click);
            // 
            // saveOutputButton
            // 
            this.saveOutputButton.Enabled = false;
            this.saveOutputButton.Location = new System.Drawing.Point(542, 295);
            this.saveOutputButton.Name = "saveOutputButton";
            this.saveOutputButton.Size = new System.Drawing.Size(133, 39);
            this.saveOutputButton.TabIndex = 3;
            this.saveOutputButton.Text = "Save Output";
            this.saveOutputButton.UseVisualStyleBackColor = true;
            this.saveOutputButton.Click += new System.EventHandler(this.saveOutputButton_Click);
            // 
            // filterSelect
            // 
            this.filterSelect.Enabled = false;
            this.filterSelect.FormattingEnabled = true;
            this.filterSelect.Items.AddRange(new object[] {
            "Copy",
            "Greyscale",
            "Inversion",
            "Sepia",
            "Histogram",
            "Smoothing",
            "Sharpen",
            "Gaussian Blur",
            "Mean Removal",
            "Emboss Laplacian",
            "Edge Enhance",
            "Edge Detect"});
            this.filterSelect.Location = new System.Drawing.Point(542, 183);
            this.filterSelect.Name = "filterSelect";
            this.filterSelect.Size = new System.Drawing.Size(133, 24);
            this.filterSelect.TabIndex = 2;
            this.filterSelect.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.subtractButton);
            this.tabPage2.Controls.Add(this.subtractedBox);
            this.tabPage2.Controls.Add(this.backgroundBox);
            this.tabPage2.Controls.Add(this.foregroundBox);
            this.tabPage2.Controls.Add(this.chooseFilterSubtractedButton);
            this.tabPage2.Controls.Add(this.saveSubtractedButton);
            this.tabPage2.Controls.Add(this.filterSubtractedSelect);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1225, 536);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Subtract";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // subtractButton
            // 
            this.subtractButton.Enabled = false;
            this.subtractButton.Location = new System.Drawing.Point(129, 370);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(442, 39);
            this.subtractButton.TabIndex = 13;
            this.subtractButton.Text = "Subtract Button";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // subtractedBox
            // 
            this.subtractedBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.subtractedBox.Location = new System.Drawing.Point(716, 18);
            this.subtractedBox.Name = "subtractedBox";
            this.subtractedBox.Size = new System.Drawing.Size(483, 497);
            this.subtractedBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.subtractedBox.TabIndex = 12;
            this.subtractedBox.TabStop = false;
            // 
            // backgroundBox
            // 
            this.backgroundBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.backgroundBox.Location = new System.Drawing.Point(21, 18);
            this.backgroundBox.Name = "backgroundBox";
            this.backgroundBox.Size = new System.Drawing.Size(300, 300);
            this.backgroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backgroundBox.TabIndex = 11;
            this.backgroundBox.TabStop = false;
            this.backgroundBox.Click += new System.EventHandler(this.backgroundBox_Click);
            // 
            // foregroundBox
            // 
            this.foregroundBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foregroundBox.Location = new System.Drawing.Point(380, 18);
            this.foregroundBox.Name = "foregroundBox";
            this.foregroundBox.Size = new System.Drawing.Size(300, 300);
            this.foregroundBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foregroundBox.TabIndex = 10;
            this.foregroundBox.TabStop = false;
            this.foregroundBox.Click += new System.EventHandler(this.foregroundBox_Click);
            // 
            // chooseFilterSubtractedButton
            // 
            this.chooseFilterSubtractedButton.Enabled = false;
            this.chooseFilterSubtractedButton.Location = new System.Drawing.Point(129, 450);
            this.chooseFilterSubtractedButton.Name = "chooseFilterSubtractedButton";
            this.chooseFilterSubtractedButton.Size = new System.Drawing.Size(133, 42);
            this.chooseFilterSubtractedButton.TabIndex = 9;
            this.chooseFilterSubtractedButton.Text = "Choose Filter";
            this.chooseFilterSubtractedButton.UseVisualStyleBackColor = true;
            this.chooseFilterSubtractedButton.Click += new System.EventHandler(this.chooseFilterSubtractedButton_Click);
            // 
            // saveSubtractedButton
            // 
            this.saveSubtractedButton.Enabled = false;
            this.saveSubtractedButton.Location = new System.Drawing.Point(438, 450);
            this.saveSubtractedButton.Name = "saveSubtractedButton";
            this.saveSubtractedButton.Size = new System.Drawing.Size(133, 39);
            this.saveSubtractedButton.TabIndex = 8;
            this.saveSubtractedButton.Text = "Save Output";
            this.saveSubtractedButton.UseVisualStyleBackColor = true;
            this.saveSubtractedButton.Click += new System.EventHandler(this.saveSubtractedButton_Click);
            // 
            // filterSubtractedSelect
            // 
            this.filterSubtractedSelect.Enabled = false;
            this.filterSubtractedSelect.FormattingEnabled = true;
            this.filterSubtractedSelect.Items.AddRange(new object[] {
            "Greyscale",
            "Inversion",
            "Sepia",
            "Histogram",
            "Smoothing",
            "Sharpen",
            "Gaussian Blur",
            "Mean Removal",
            "Emboss Laplacian",
            "Edge Enhance",
            "Edge Detect"});
            this.filterSubtractedSelect.Location = new System.Drawing.Point(279, 458);
            this.filterSubtractedSelect.Name = "filterSubtractedSelect";
            this.filterSubtractedSelect.Size = new System.Drawing.Size(133, 24);
            this.filterSubtractedSelect.TabIndex = 7;
            this.filterSubtractedSelect.SelectedIndexChanged += new System.EventHandler(this.filterSubtractedSelect_SelectedIndexChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            this.openFileDialog2.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog2_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 608);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inputFilterBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.outputFilterBox)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.subtractedBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backgroundBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foregroundBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openCameraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openForegroundToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog2;
        private System.Windows.Forms.PictureBox inputFilterBox;
        private System.Windows.Forms.PictureBox outputFilterBox;
        private System.Windows.Forms.Button chooseFilterButton;
        private System.Windows.Forms.Button saveOutputButton;
        private System.Windows.Forms.ComboBox filterSelect;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.PictureBox subtractedBox;
        private System.Windows.Forms.PictureBox backgroundBox;
        private System.Windows.Forms.PictureBox foregroundBox;
        private System.Windows.Forms.Button chooseFilterSubtractedButton;
        private System.Windows.Forms.Button saveSubtractedButton;
        private System.Windows.Forms.ComboBox filterSubtractedSelect;
    }
}

