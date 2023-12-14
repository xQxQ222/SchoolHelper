namespace WinFormsApp1
{
    partial class ChangePass
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
            pictureBox4 = new PictureBox();
            emailField = new TextBox();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            CodeField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SendCodeButton = new Button();
            NextButton = new Button();
            pictureBox2 = new PictureBox();
            newPassField = new TextBox();
            label3 = new Label();
            BackButton = new Button();
            ShowPasswordCheckBox = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._134146_mail_email_icon;
            pictureBox4.Location = new Point(108, 92);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 43;
            pictureBox4.TabStop = false;
            // 
            // emailField
            // 
            emailField.Cursor = Cursors.IBeam;
            emailField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailField.Location = new Point(144, 89);
            emailField.Name = "emailField";
            emailField.Size = new Size(202, 29);
            emailField.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(144, 62);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 41;
            label6.Text = "E-Mail";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._8678775_fingerprint_biometric_security_icon;
            pictureBox1.Location = new Point(108, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 46;
            pictureBox1.TabStop = false;
            // 
            // CodeField
            // 
            CodeField.Cursor = Cursors.IBeam;
            CodeField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CodeField.Location = new Point(144, 178);
            CodeField.Name = "CodeField";
            CodeField.Size = new Size(79, 29);
            CodeField.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(144, 151);
            label1.Name = "label1";
            label1.Size = new Size(44, 24);
            label1.TabIndex = 44;
            label1.Text = "Код";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 6.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(144, 121);
            label2.Name = "label2";
            label2.Size = new Size(199, 12);
            label2.TabIndex = 47;
            label2.Text = "Введите почту, привязанную к вашему аккаунту";
            // 
            // SendCodeButton
            // 
            SendCodeButton.FlatStyle = FlatStyle.Flat;
            SendCodeButton.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SendCodeButton.Location = new Point(352, 92);
            SendCodeButton.Name = "SendCodeButton";
            SendCodeButton.Size = new Size(99, 29);
            SendCodeButton.TabIndex = 48;
            SendCodeButton.Text = "Отправить код";
            SendCodeButton.UseVisualStyleBackColor = true;
            
            // 
            // NextButton
            // 
            NextButton.FlatStyle = FlatStyle.Flat;
            NextButton.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Regular, GraphicsUnit.Point);
            NextButton.Location = new Point(502, 294);
            NextButton.Name = "NextButton";
            NextButton.Size = new Size(76, 43);
            NextButton.TabIndex = 49;
            NextButton.Text = "Далее";
            NextButton.UseVisualStyleBackColor = true;
            
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._1564520_code_open_password_icon;
            pictureBox2.Location = new Point(108, 254);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 52;
            pictureBox2.TabStop = false;
            // 
            // newPassField
            // 
            newPassField.Cursor = Cursors.IBeam;
            newPassField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            newPassField.Location = new Point(144, 255);
            newPassField.Name = "newPassField";
            newPassField.Size = new Size(202, 29);
            newPassField.TabIndex = 51;
            newPassField.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(144, 228);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 50;
            label3.Text = "Новый пароль";
            // 
            // BackButton
            // 
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.Location = new Point(22, 295);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(76, 41);
            BackButton.TabIndex = 53;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
           
            // 
            // ShowPasswordCheckBox
            // 
            ShowPasswordCheckBox.AutoSize = true;
            ShowPasswordCheckBox.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPasswordCheckBox.Location = new Point(352, 264);
            ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            ShowPasswordCheckBox.Size = new Size(126, 20);
            ShowPasswordCheckBox.TabIndex = 54;
            ShowPasswordCheckBox.Text = "Показать пароль";
            ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            // 
            // ChangePass
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(600, 350);
            Controls.Add(ShowPasswordCheckBox);
            Controls.Add(BackButton);
            Controls.Add(pictureBox2);
            Controls.Add(newPassField);
            Controls.Add(label3);
            Controls.Add(NextButton);
            Controls.Add(SendCodeButton);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(CodeField);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(emailField);
            Controls.Add(label6);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangePass";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ChangePass";
            
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox4;
        private TextBox emailField;
        private Label label6;
        private PictureBox pictureBox1;
        private TextBox CodeField;
        private Label label1;
        private Label label2;
        private Button SendCodeButton;
        private Button NextButton;
        private PictureBox pictureBox2;
        private TextBox newPassField;
        private Label label3;
        private Button BackButton;
        private CheckBox ShowPasswordCheckBox;
    }
}