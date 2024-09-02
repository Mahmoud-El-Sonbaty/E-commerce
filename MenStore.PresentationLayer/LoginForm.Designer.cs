
using System.Windows.Forms;
using System.Xml.Linq;

namespace MenStore.PresentationLayer
{
    partial class LoginForm
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
            SubmitBTN = new Button();
            PasswordTXT = new TextBox();
            UsernameTXT = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // SubmitBTN
            // 
            SubmitBTN.BackColor = Color.Navy;
            SubmitBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBTN.ForeColor = Color.White;
            SubmitBTN.Location = new Point(413, 273);
            SubmitBTN.Name = "SubmitBTN";
            SubmitBTN.Size = new Size(94, 44);
            SubmitBTN.TabIndex = 15;
            SubmitBTN.Text = "Login";
            SubmitBTN.UseVisualStyleBackColor = false;
            SubmitBTN.Click += SubmitBTN_Click;
            // 
            // PasswordTXT
            // 
            PasswordTXT.Location = new Point(322, 208);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.Size = new Size(321, 27);
            PasswordTXT.TabIndex = 10;
            PasswordTXT.UseSystemPasswordChar = true;
            // 
            // UsernameTXT
            // 
            UsernameTXT.Location = new Point(321, 137);
            UsernameTXT.Name = "UsernameTXT";
            UsernameTXT.Size = new Size(321, 27);
            UsernameTXT.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(158, 198);
            label6.Name = "label6";
            label6.Size = new Size(132, 38);
            label6.TabIndex = 5;
            label6.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(157, 128);
            label5.Name = "label5";
            label5.Size = new Size(142, 38);
            label5.TabIndex = 6;
            label5.Text = "Username";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(304, 17);
            label1.Name = "label1";
            label1.Size = new Size(325, 70);
            label1.TabIndex = 4;
            label1.Text = "Login";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitBTN);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernameTXT);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "LoginForm";
            Text = "LoginFormcs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SubmitBTN;
        private TextBox PasswordTXT;
        private TextBox UsernameTXT;
        private Label label6;
        private Label label5;
        private Label label1;
    }
}