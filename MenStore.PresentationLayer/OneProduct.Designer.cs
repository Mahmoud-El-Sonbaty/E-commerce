namespace MenStore.PresentationLayer
{
    partial class OneProduct
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
            BoxPic = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTitle = new Label();
            Units = new Label();
            lblPrice = new Label();
            lblCategory = new Label();
            ((System.ComponentModel.ISupportInitialize)BoxPic).BeginInit();
            SuspendLayout();
            // 
            // BoxPic
            // 
            BoxPic.Location = new Point(43, 24);
            BoxPic.Name = "BoxPic";
            BoxPic.Size = new Size(287, 348);
            BoxPic.TabIndex = 0;
            BoxPic.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F);
            label2.Location = new Point(417, 34);
            label2.Name = "label2";
            label2.Size = new Size(74, 37);
            label2.TabIndex = 2;
            label2.Text = "Title:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.Location = new Point(417, 118);
            label1.Name = "label1";
            label1.Size = new Size(179, 37);
            label1.TabIndex = 3;
            label1.Text = "Unit In Stock :";
            label1.Click += label1_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F);
            label3.Location = new Point(417, 204);
            label3.Name = "label3";
            label3.Size = new Size(87, 37);
            label3.TabIndex = 4;
            label3.Text = "Price :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F);
            label4.Location = new Point(417, 287);
            label4.Name = "label4";
            label4.Size = new Size(138, 37);
            label4.TabIndex = 5;
            label4.Text = "Category :";
            label4.Click += label4_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F);
            lblTitle.Location = new Point(625, 34);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(32, 37);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "0";
            lblTitle.Click += label5_Click;
            // 
            // Units
            // 
            Units.AutoSize = true;
            Units.Font = new Font("Segoe UI", 16F);
            Units.Location = new Point(625, 118);
            Units.Name = "Units";
            Units.Size = new Size(32, 37);
            Units.TabIndex = 3;
            Units.Text = "0";
            Units.Click += label1_Click_1;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 16F);
            lblPrice.Location = new Point(625, 204);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(32, 37);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "0";
            lblPrice.Click += label3_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 16F);
            lblCategory.Location = new Point(625, 287);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(32, 37);
            lblCategory.TabIndex = 5;
            lblCategory.Text = "0";
            lblCategory.Click += label4_Click;
            // 
            // OneProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(954, 395);
            Controls.Add(lblCategory);
            Controls.Add(label4);
            Controls.Add(lblPrice);
            Controls.Add(label3);
            Controls.Add(Units);
            Controls.Add(label1);
            Controls.Add(lblTitle);
            Controls.Add(label2);
            Controls.Add(BoxPic);
            Name = "OneProduct";
            Text = "OneProduct";
            ((System.ComponentModel.ISupportInitialize)BoxPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox BoxPic;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label lblTitle;
        private Label Units;
        private Label lblPrice;
        private Label lblCategory;
    }
}