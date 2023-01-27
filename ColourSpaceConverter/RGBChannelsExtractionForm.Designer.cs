namespace ColourSpaceConverter
{
    partial class RGBChannelsExtractionForm
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
            this.baseImagePictureBox = new System.Windows.Forms.PictureBox();
            this.redChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.greenChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.blueChannelPictureBox = new System.Windows.Forms.PictureBox();
            this.chooseImageButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.histogramPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.baseImagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChannelPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseImagePictureBox
            // 
            this.baseImagePictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baseImagePictureBox.Location = new System.Drawing.Point(7, 33);
            this.baseImagePictureBox.Name = "baseImagePictureBox";
            this.baseImagePictureBox.Size = new System.Drawing.Size(603, 480);
            this.baseImagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.baseImagePictureBox.TabIndex = 0;
            this.baseImagePictureBox.TabStop = false;
            // 
            // redChannelPictureBox
            // 
            this.redChannelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.redChannelPictureBox.Location = new System.Drawing.Point(7, 30);
            this.redChannelPictureBox.Name = "redChannelPictureBox";
            this.redChannelPictureBox.Size = new System.Drawing.Size(609, 526);
            this.redChannelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.redChannelPictureBox.TabIndex = 1;
            this.redChannelPictureBox.TabStop = false;
            // 
            // greenChannelPictureBox
            // 
            this.greenChannelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.greenChannelPictureBox.Location = new System.Drawing.Point(642, 30);
            this.greenChannelPictureBox.Name = "greenChannelPictureBox";
            this.greenChannelPictureBox.Size = new System.Drawing.Size(609, 526);
            this.greenChannelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.greenChannelPictureBox.TabIndex = 2;
            this.greenChannelPictureBox.TabStop = false;
            // 
            // blueChannelPictureBox
            // 
            this.blueChannelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.blueChannelPictureBox.Location = new System.Drawing.Point(1275, 30);
            this.blueChannelPictureBox.Name = "blueChannelPictureBox";
            this.blueChannelPictureBox.Size = new System.Drawing.Size(609, 526);
            this.blueChannelPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.blueChannelPictureBox.TabIndex = 3;
            this.blueChannelPictureBox.TabStop = false;
            // 
            // chooseImageButton
            // 
            this.chooseImageButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chooseImageButton.Location = new System.Drawing.Point(7, 525);
            this.chooseImageButton.Name = "chooseImageButton";
            this.chooseImageButton.Size = new System.Drawing.Size(603, 50);
            this.chooseImageButton.TabIndex = 8;
            this.chooseImageButton.Text = "Выбрать";
            this.chooseImageButton.UseVisualStyleBackColor = true;
            this.chooseImageButton.Click += new System.EventHandler(this.chooseImageButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // histogramPictureBox
            // 
            this.histogramPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.histogramPictureBox.BackColor = System.Drawing.SystemColors.Control;
            this.histogramPictureBox.Location = new System.Drawing.Point(6, 30);
            this.histogramPictureBox.Name = "histogramPictureBox";
            this.histogramPictureBox.Size = new System.Drawing.Size(1269, 545);
            this.histogramPictureBox.TabIndex = 1;
            this.histogramPictureBox.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.blueChannelPictureBox);
            this.groupBox2.Controls.Add(this.greenChannelPictureBox);
            this.groupBox2.Controls.Add(this.redChannelPictureBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 605);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1903, 562);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Цветовые составляющие";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.histogramPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(634, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1281, 591);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Цветовая гистограмма";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.baseImagePictureBox);
            this.groupBox3.Controls.Add(this.chooseImageButton);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(616, 591);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Исходное изображение";
            // 
            // RGBChannelsExtractionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1932, 1179);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RGBChannelsExtractionForm";
            this.Text = "Выделение из полноцветного изображения каждого из каналов R, G, B";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.RGBChannelsExtractionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseImagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greenChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blueChannelPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.histogramPictureBox)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox baseImagePictureBox;
        private System.Windows.Forms.PictureBox redChannelPictureBox;
        private System.Windows.Forms.PictureBox greenChannelPictureBox;
        private System.Windows.Forms.PictureBox blueChannelPictureBox;
        private System.Windows.Forms.Button chooseImageButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.PictureBox histogramPictureBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}