namespace ColourSpaceConverter
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.rgbToGrayScaleButton = new System.Windows.Forms.Button();
            this.buttonsFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.rgbChannelsExtractionButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.rgbToHsvButton = new System.Windows.Forms.Button();
            this.buttonsFlowLayoutPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rgbToGrayScaleButton
            // 
            this.rgbToGrayScaleButton.Location = new System.Drawing.Point(3, 53);
            this.rgbToGrayScaleButton.Name = "rgbToGrayScaleButton";
            this.rgbToGrayScaleButton.Size = new System.Drawing.Size(230, 120);
            this.rgbToGrayScaleButton.TabIndex = 0;
            this.rgbToGrayScaleButton.Text = "Открыть форму";
            this.rgbToGrayScaleButton.UseVisualStyleBackColor = true;
            this.rgbToGrayScaleButton.Click += new System.EventHandler(this.rgbToGrayScaleButton_Click);
            // 
            // buttonsFlowLayoutPanel
            // 
            this.buttonsFlowLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsFlowLayoutPanel.Controls.Add(this.flowLayoutPanel1);
            this.buttonsFlowLayoutPanel.Controls.Add(this.flowLayoutPanel2);
            this.buttonsFlowLayoutPanel.Controls.Add(this.flowLayoutPanel3);
            this.buttonsFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.buttonsFlowLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.buttonsFlowLayoutPanel.Name = "buttonsFlowLayoutPanel";
            this.buttonsFlowLayoutPanel.Size = new System.Drawing.Size(1200, 235);
            this.buttonsFlowLayoutPanel.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.rgbToGrayScaleButton);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(392, 214);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Преобразование изображения из RGB в оттенки серого";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label2);
            this.flowLayoutPanel2.Controls.Add(this.rgbChannelsExtractionButton);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(401, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(392, 214);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 75);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выделение из полноцветного изображения каждого из каналов R, G, B";
            // 
            // rgbChannelsExtractionButton
            // 
            this.rgbChannelsExtractionButton.Location = new System.Drawing.Point(3, 78);
            this.rgbChannelsExtractionButton.Name = "rgbChannelsExtractionButton";
            this.rgbChannelsExtractionButton.Size = new System.Drawing.Size(230, 120);
            this.rgbChannelsExtractionButton.TabIndex = 2;
            this.rgbChannelsExtractionButton.Text = "Открыть форму";
            this.rgbChannelsExtractionButton.UseVisualStyleBackColor = true;
            this.rgbChannelsExtractionButton.Click += new System.EventHandler(this.rgbChannelsExtractionButton_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label3);
            this.flowLayoutPanel3.Controls.Add(this.rgbToHsvButton);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(799, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(392, 214);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(355, 50);
            this.label3.TabIndex = 7;
            this.label3.Text = "Преобразование изображения из RGB в HSV";
            // 
            // rgbToHsvButton
            // 
            this.rgbToHsvButton.Location = new System.Drawing.Point(3, 53);
            this.rgbToHsvButton.Name = "rgbToHsvButton";
            this.rgbToHsvButton.Size = new System.Drawing.Size(230, 120);
            this.rgbToHsvButton.TabIndex = 2;
            this.rgbToHsvButton.Text = "Открыть форму";
            this.rgbToHsvButton.UseVisualStyleBackColor = true;
            this.rgbToHsvButton.Click += new System.EventHandler(this.rgbToHsvButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 259);
            this.Controls.Add(this.buttonsFlowLayoutPanel);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 330);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1250, 330);
            this.Name = "MainForm";
            this.Text = "Преобразование цветовых пространств";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.buttonsFlowLayoutPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rgbToGrayScaleButton;
        private System.Windows.Forms.FlowLayoutPanel buttonsFlowLayoutPanel;
        private System.Windows.Forms.Button rgbChannelsExtractionButton;
        private System.Windows.Forms.Button rgbToHsvButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label3;
    }
}

