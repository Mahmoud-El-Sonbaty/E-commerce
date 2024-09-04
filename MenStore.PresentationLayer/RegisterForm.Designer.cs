namespace MenStore.PresentationLayer
{
    partial class RegisterForm
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
            label1 = new Label();
            label2 = new Label();
            NameTXT = new TextBox();
            label3 = new Label();
            label4 = new Label();
            PhoneTXT = new TextBox();
            label5 = new Label();
            AddressTXT = new TextBox();
            UsernameTXT = new TextBox();
            label6 = new Label();
            PasswordTXT = new TextBox();
            SubmitBTN = new Button();
            RegisterNow = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(271, 6);
            label1.Name = "label1";
            label1.Size = new Size(325, 70);
            label1.TabIndex = 0;
            label1.Text = "Registration";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(112, 84);
            label2.Name = "label2";
            label2.Size = new Size(91, 38);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // NameTXT
            // 
            NameTXT.Location = new Point(277, 99);
            NameTXT.MaxLength = 20;
            NameTXT.Name = "NameTXT";
            NameTXT.Size = new Size(324, 27);
            NameTXT.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(112, 145);
            label3.Name = "label3";
            label3.Size = new Size(96, 38);
            label3.TabIndex = 1;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(115, 211);
            label4.Name = "label4";
            label4.Size = new Size(116, 38);
            label4.TabIndex = 1;
            label4.Text = "Address";
            // 
            // PhoneTXT
            // 
            PhoneTXT.Location = new Point(277, 158);
            PhoneTXT.MaxLength = 11;
            PhoneTXT.Name = "PhoneTXT";
            PhoneTXT.Size = new Size(321, 27);
            PhoneTXT.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(113, 270);
            label5.Name = "label5";
            label5.Size = new Size(142, 38);
            label5.TabIndex = 1;
            label5.Text = "Username";
            // 
            // AddressTXT
            // 
            AddressTXT.Location = new Point(278, 220);
            AddressTXT.Name = "AddressTXT";
            AddressTXT.Size = new Size(321, 27);
            AddressTXT.TabIndex = 2;
            // 
            // UsernameTXT
            // 
            UsernameTXT.Location = new Point(277, 279);
            UsernameTXT.Name = "UsernameTXT";
            UsernameTXT.Size = new Size(321, 27);
            UsernameTXT.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(114, 332);
            label6.Name = "label6";
            label6.Size = new Size(132, 38);
            label6.TabIndex = 1;
            label6.Text = "Password";
            // 
            // PasswordTXT
            // 
            PasswordTXT.Location = new Point(278, 342);
            PasswordTXT.Name = "PasswordTXT";
            PasswordTXT.Size = new Size(321, 27);
            PasswordTXT.TabIndex = 2;
            PasswordTXT.UseSystemPasswordChar = true;
            // 
            // SubmitBTN
            // 
            SubmitBTN.BackColor = Color.Navy;
            SubmitBTN.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitBTN.ForeColor = Color.White;
            SubmitBTN.Location = new Point(369, 379);
            SubmitBTN.Name = "SubmitBTN";
            SubmitBTN.Size = new Size(94, 44);
            SubmitBTN.TabIndex = 3;
            SubmitBTN.Text = "Submit";
            SubmitBTN.UseVisualStyleBackColor = false;
            SubmitBTN.Click += SubmitBTN_Click;
            // 
            // RegisterNow
            // 
            RegisterNow.AutoSize = true;
            RegisterNow.Cursor = Cursors.Hand;
            RegisterNow.ForeColor = Color.Navy;
            RegisterNow.Location = new Point(475, 426);
            RegisterNow.Name = "RegisterNow";
            RegisterNow.Size = new Size(81, 20);
            RegisterNow.TabIndex = 19;
            RegisterNow.Text = "Login Now";
            RegisterNow.Click += RegisterNow_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(278, 426);
            label7.Name = "label7";
            label7.Size = new Size(189, 20);
            label7.TabIndex = 18;
            label7.Text = "Already Have An Account ?";
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterNow);
            Controls.Add(label7);
            Controls.Add(SubmitBTN);
            Controls.Add(PasswordTXT);
            Controls.Add(UsernameTXT);
            Controls.Add(AddressTXT);
            Controls.Add(label6);
            Controls.Add(PhoneTXT);
            Controls.Add(label5);
            Controls.Add(NameTXT);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox NameTXT;
        private Label label3;
        private Label label4;
        private TextBox PhoneTXT;
        private Label label5;
        private TextBox AddressTXT;
        private TextBox UsernameTXT;
        private Label label6;
        private TextBox PasswordTXT;
        private Button SubmitBTN;
        private Label RegisterNow;
        private Label label7;
    }
}