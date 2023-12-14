namespace WinFormsApp1
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
            LoginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            LoginField = new TextBox();
            PasswordField = new TextBox();
            label3 = new Label();
            backButton = new Button();
            loginPic = new PictureBox();
            passwordPic = new PictureBox();
            ShowPassword = new CheckBox();
            escapeButton = new Label();
            forgotPassLinkLabel = new LinkLabel();
            ((System.ComponentModel.ISupportInitialize)loginPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passwordPic).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(592, 486);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(128, 41);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(283, 204);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 1;
            label1.Text = "Логин";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(283, 293);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 2;
            label2.Text = "Пароль";
            // 
            // LoginField
            // 
            LoginField.Cursor = Cursors.IBeam;
            LoginField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginField.Location = new Point(283, 229);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(202, 29);
            LoginField.TabIndex = 3;
            // 
            // PasswordField
            // 
            PasswordField.Cursor = Cursors.IBeam;
            PasswordField.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(283, 318);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(202, 29);
            PasswordField.TabIndex = 4;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(233, 47);
            label3.Name = "label3";
            label3.Size = new Size(313, 61);
            label3.TabIndex = 5;
            label3.Text = "Авторизация";
            // 
            // backButton
            // 
            backButton.Cursor = Cursors.Hand;
            backButton.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            backButton.Location = new Point(75, 486);
            backButton.Name = "backButton";
            backButton.Size = new Size(128, 41);
            backButton.TabIndex = 6;
            backButton.Text = "Назад";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += BackButton_Click;
            // 
            // loginPic
            // 
            loginPic.Image = Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            loginPic.Location = new Point(247, 228);
            loginPic.Name = "loginPic";
            loginPic.Size = new Size(30, 30);
            loginPic.SizeMode = PictureBoxSizeMode.Zoom;
            loginPic.TabIndex = 7;
            loginPic.TabStop = false;
            // 
            // passwordPic
            // 
            passwordPic.Image = Properties.Resources._8201380_unlock_padlock_password_ui_lock_icon;
            passwordPic.Location = new Point(247, 318);
            passwordPic.Name = "passwordPic";
            passwordPic.Size = new Size(30, 30);
            passwordPic.SizeMode = PictureBoxSizeMode.StretchImage;
            passwordPic.TabIndex = 8;
            passwordPic.TabStop = false;
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword.Location = new Point(491, 325);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(126, 20);
            ShowPassword.TabIndex = 9;
            ShowPassword.Text = "Показать пароль";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // escapeButton
            // 
            escapeButton.AutoSize = true;
            escapeButton.Cursor = Cursors.Hand;
            escapeButton.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            escapeButton.Location = new Point(752, 0);
            escapeButton.Name = "escapeButton";
            escapeButton.Size = new Size(34, 34);
            escapeButton.TabIndex = 27;
            escapeButton.Text = "X";
            escapeButton.Click += EscapeButton_Click;
            // 
            // forgotPassLinkLabel
            // 
            forgotPassLinkLabel.AutoSize = true;
            forgotPassLinkLabel.Location = new Point(387, 350);
            forgotPassLinkLabel.Name = "forgotPassLinkLabel";
            forgotPassLinkLabel.Size = new Size(98, 15);
            forgotPassLinkLabel.TabIndex = 28;
            forgotPassLinkLabel.TabStop = true;
            forgotPassLinkLabel.Text = "Забыли пароль?";
            forgotPassLinkLabel.LinkClicked += ForgotPassLinkLabel_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(784, 561);
            Controls.Add(forgotPassLinkLabel);
            Controls.Add(escapeButton);
            Controls.Add(ShowPassword);
            Controls.Add(passwordPic);
            Controls.Add(loginPic);
            Controls.Add(backButton);
            Controls.Add(label3);
            Controls.Add(PasswordField);
            Controls.Add(LoginField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "LoginForm";
            MouseDown += LoginForm_MouseDown;
            MouseMove += LoginForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)loginPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)passwordPic).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private Label label1;
        private Label label2;
        private TextBox LoginField;
        private TextBox PasswordField;
        private Label label3;
        private Button backButton;
        private PictureBox loginPic;
        private PictureBox passwordPic;
        private CheckBox ShowPassword;
        private Label escapeButton;
        private LinkLabel forgotPassLinkLabel;
    }
}