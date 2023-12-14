namespace WinFormsApp1
{
    partial class RegistrationForm
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
            ShowPassword = new CheckBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            label3 = new Label();
            PasswordField = new TextBox();
            LoginField = new TextBox();
            label2 = new Label();
            label1 = new Label();
            RegistrationButton = new Button();
            ExitButton = new Label();
            pictureBox3 = new PictureBox();
            nameField = new TextBox();
            NameLabel = new Label();
            surnameField = new TextBox();
            SurnameLabel = new Label();
            birthDate = new DateTimePicker();
            label4 = new Label();
            status = new ComboBox();
            label5 = new Label();
            pictureBox4 = new PictureBox();
            emailField = new TextBox();
            label6 = new Label();
            patronymicField = new TextBox();
            Otchestvo = new Label();
            button2 = new Button();
            codeField = new TextBox();
            pictureBox5 = new PictureBox();
            label7 = new Label();
            ConfirmCodeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // ShowPassword
            // 
            ShowPassword.AutoSize = true;
            ShowPassword.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ShowPassword.Location = new Point(279, 279);
            ShowPassword.Name = "ShowPassword";
            ShowPassword.Size = new Size(126, 20);
            ShowPassword.TabIndex = 19;
            ShowPassword.Text = "Показать пароль";
            ShowPassword.UseVisualStyleBackColor = true;
            ShowPassword.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._8201380_unlock_padlock_password_ui_lock_icon;
            pictureBox2.Location = new Point(35, 279);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1564535_customer_user_userphoto_account_person_icon;
            pictureBox1.Location = new Point(35, 198);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(30, 30);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(78, 501);
            button1.Name = "button1";
            button1.Size = new Size(128, 41);
            button1.TabIndex = 16;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(183, 35);
            label3.Name = "label3";
            label3.Size = new Size(403, 81);
            label3.TabIndex = 15;
            label3.Text = "Регистрация";
            // 
            // PasswordField
            // 
            PasswordField.Cursor = Cursors.IBeam;
            PasswordField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordField.Location = new Point(71, 276);
            PasswordField.Name = "PasswordField";
            PasswordField.Size = new Size(202, 29);
            PasswordField.TabIndex = 14;
            PasswordField.UseSystemPasswordChar = true;
            // 
            // LoginField
            // 
            LoginField.Cursor = Cursors.IBeam;
            LoginField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginField.Location = new Point(71, 199);
            LoginField.Name = "LoginField";
            LoginField.Size = new Size(202, 29);
            LoginField.TabIndex = 13;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(71, 246);
            label2.Name = "label2";
            label2.Size = new Size(75, 24);
            label2.TabIndex = 12;
            label2.Text = "Пароль";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(75, 171);
            label1.Name = "label1";
            label1.Size = new Size(62, 24);
            label1.TabIndex = 11;
            label1.Text = "Логин";
            // 
            // RegistrationButton
            // 
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(595, 501);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(128, 41);
            RegistrationButton.TabIndex = 10;
            RegistrationButton.Text = "Зарег-ся";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // ExitButton
            // 
            ExitButton.AutoSize = true;
            ExitButton.Cursor = Cursors.Hand;
            ExitButton.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            ExitButton.Location = new Point(767, -1);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(34, 34);
            ExitButton.TabIndex = 28;
            ExitButton.Text = "X";
            ExitButton.Click += EscapeButton_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.png_transparent_name_tag_computer_icons_logo_id_card_miscellaneous_text_silhouette;
            pictureBox3.Location = new Point(471, 198);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 31;
            pictureBox3.TabStop = false;
            // 
            // nameField
            // 
            nameField.Cursor = Cursors.IBeam;
            nameField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            nameField.Location = new Point(507, 198);
            nameField.Name = "nameField";
            nameField.Size = new Size(202, 29);
            nameField.TabIndex = 30;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(507, 171);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(50, 24);
            NameLabel.TabIndex = 29;
            NameLabel.Text = "Имя";
            // 
            // surnameField
            // 
            surnameField.Cursor = Cursors.IBeam;
            surnameField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            surnameField.Location = new Point(507, 257);
            surnameField.Name = "surnameField";
            surnameField.Size = new Size(202, 29);
            surnameField.TabIndex = 33;
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(507, 230);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(93, 24);
            SurnameLabel.TabIndex = 32;
            SurnameLabel.Text = "Фамилия";
            // 
            // birthDate
            // 
            birthDate.Location = new Point(507, 380);
            birthDate.Name = "birthDate";
            birthDate.Size = new Size(200, 23);
            birthDate.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(507, 351);
            label4.Name = "label4";
            label4.Size = new Size(148, 24);
            label4.TabIndex = 35;
            label4.Text = "Дата Рождения";
            // 
            // status
            // 
            status.FormattingEnabled = true;
            status.Location = new Point(507, 433);
            status.Name = "status";
            status.Size = new Size(200, 23);
            status.TabIndex = 36;
            status.SelectedIndexChanged += status_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(507, 406);
            label5.Name = "label5";
            label5.Size = new Size(68, 24);
            label5.TabIndex = 37;
            label5.Text = "Статус";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._134146_mail_email_icon;
            pictureBox4.Location = new Point(35, 348);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 40;
            pictureBox4.TabStop = false;
            // 
            // emailField
            // 
            emailField.Cursor = Cursors.IBeam;
            emailField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            emailField.Location = new Point(71, 348);
            emailField.Name = "emailField";
            emailField.Size = new Size(202, 29);
            emailField.TabIndex = 39;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(71, 321);
            label6.Name = "label6";
            label6.Size = new Size(66, 24);
            label6.TabIndex = 38;
            label6.Text = "E-Mail";
            // 
            // patronymicField
            // 
            patronymicField.Cursor = Cursors.IBeam;
            patronymicField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            patronymicField.Location = new Point(507, 316);
            patronymicField.Name = "patronymicField";
            patronymicField.Size = new Size(202, 29);
            patronymicField.TabIndex = 42;
            // 
            // Otchestvo
            // 
            Otchestvo.AutoSize = true;
            Otchestvo.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Otchestvo.Location = new Point(507, 289);
            Otchestvo.Name = "Otchestvo";
            Otchestvo.Size = new Size(93, 24);
            Otchestvo.TabIndex = 41;
            Otchestvo.Text = "Отчество";
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(279, 348);
            button2.Name = "button2";
            button2.Size = new Size(103, 30);
            button2.TabIndex = 43;
            button2.Text = "Подтвердить";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ConfirmEmailButton_Click;
            // 
            // codeField
            // 
            codeField.Cursor = Cursors.IBeam;
            codeField.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            codeField.Location = new Point(71, 427);
            codeField.Name = "codeField";
            codeField.Size = new Size(122, 29);
            codeField.TabIndex = 44;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._8678775_fingerprint_biometric_security_icon;
            pictureBox5.Location = new Point(35, 426);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(30, 30);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 47;
            pictureBox5.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(71, 400);
            label7.Name = "label7";
            label7.Size = new Size(122, 24);
            label7.TabIndex = 48;
            label7.Text = "Код с почты";
            // 
            // ConfirmCodeButton
            // 
            ConfirmCodeButton.Cursor = Cursors.Hand;
            ConfirmCodeButton.FlatStyle = FlatStyle.Popup;
            ConfirmCodeButton.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            ConfirmCodeButton.Location = new Point(199, 426);
            ConfirmCodeButton.Name = "ConfirmCodeButton";
            ConfirmCodeButton.Size = new Size(103, 30);
            ConfirmCodeButton.TabIndex = 49;
            ConfirmCodeButton.Text = "Подтвердить";
            ConfirmCodeButton.UseVisualStyleBackColor = true;
            ConfirmCodeButton.Click += ConfirmCodeButton_Click;
            // 
            // RegistrationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 600);
            Controls.Add(ConfirmCodeButton);
            Controls.Add(label7);
            Controls.Add(pictureBox5);
            Controls.Add(codeField);
            Controls.Add(button2);
            Controls.Add(patronymicField);
            Controls.Add(Otchestvo);
            Controls.Add(pictureBox4);
            Controls.Add(emailField);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(status);
            Controls.Add(label4);
            Controls.Add(birthDate);
            Controls.Add(surnameField);
            Controls.Add(SurnameLabel);
            Controls.Add(pictureBox3);
            Controls.Add(nameField);
            Controls.Add(NameLabel);
            Controls.Add(ExitButton);
            Controls.Add(ShowPassword);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(PasswordField);
            Controls.Add(LoginField);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(RegistrationButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegistrationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form2";
            Load += RegistrationForm_Load;
            MouseDown += RegistrationForm_MouseDown;
            MouseMove += RegistrationForm_MouseMove;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ShowPassword;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Button button1;
        private Label label3;
        private TextBox PasswordField;
        private TextBox LoginField;
        private Label label2;
        private Label label1;
        private Button RegistrationButton;
        private Label ExitButton;
        private PictureBox pictureBox3;
        private TextBox nameField;
        private Label NameLabel;
        private TextBox surnameField;
        private Label SurnameLabel;
        private DateTimePicker birthDate;
        private Label label4;
        private ComboBox status;
        private Label label5;
        private PictureBox pictureBox4;
        private TextBox emailField;
        private Label label6;
        private TextBox patronymicField;
        private Label Otchestvo;
        private Button button2;
        private TextBox codeField;
        private PictureBox pictureBox5;
        private Label label7;
        private Button ConfirmCodeButton;
    }
}