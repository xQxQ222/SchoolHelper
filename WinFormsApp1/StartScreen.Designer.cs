namespace WinFormsApp1
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            RegistrationButton = new Button();
            LoginButton = new Button();
            label1 = new Label();
            label8 = new Label();
            SuspendLayout();
            // 
            // RegistrationButton
            // 
            RegistrationButton.AutoSize = true;
            RegistrationButton.Cursor = Cursors.Hand;
            RegistrationButton.FlatAppearance.BorderSize = 2;
            RegistrationButton.FlatStyle = FlatStyle.Flat;
            RegistrationButton.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationButton.Location = new Point(294, 316);
            RegistrationButton.Name = "RegistrationButton";
            RegistrationButton.Size = new Size(181, 58);
            RegistrationButton.TabIndex = 0;
            RegistrationButton.Text = "Регистрация";
            RegistrationButton.UseVisualStyleBackColor = true;
            RegistrationButton.Click += RegistrationButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = true;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.FlatAppearance.BorderSize = 2;
            LoginButton.FlatStyle = FlatStyle.Flat;
            LoginButton.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LoginButton.Location = new Point(294, 203);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(181, 58);
            LoginButton.TabIndex = 1;
            LoginButton.Text = "Вход";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 66);
            label1.Name = "label1";
            label1.Size = new Size(446, 61);
            label1.TabIndex = 2;
            label1.Text = "Добро пожаловать!";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(750, -2);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 27;
            label8.Text = "X";
            label8.Click += ExitButton_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(784, 561);
            Controls.Add(label8);
            Controls.Add(label1);
            Controls.Add(LoginButton);
            Controls.Add(RegistrationButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "StartScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            MouseDown += StartScreen_MouseDown;
            MouseMove += StartScreen_MouseMove;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button RegistrationButton;
        private Button LoginButton;
        private Label label1;
        private Label label8;
    }
}