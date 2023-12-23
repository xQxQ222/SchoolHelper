namespace WinFormsApp1
{
    partial class CreateNews
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
            pictureBox1 = new PictureBox();
            SelectImage = new Button();
            label2 = new Label();
            richTextBox1 = new RichTextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            createNewsButton = new Button();
            BackButton = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(266, 21);
            label1.Name = "label1";
            label1.Size = new Size(445, 61);
            label1.TabIndex = 0;
            label1.Text = "Редактор новостей";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(287, 282);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // SelectImage
            // 
            SelectImage.Cursor = Cursors.Hand;
            SelectImage.FlatStyle = FlatStyle.Flat;
            SelectImage.Font = new Font("Franklin Gothic Medium", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            SelectImage.Location = new Point(118, 412);
            SelectImage.Name = "SelectImage";
            SelectImage.Size = new Size(152, 44);
            SelectImage.TabIndex = 3;
            SelectImage.Text = "Выбрать фото\r\n";
            SelectImage.UseVisualStyleBackColor = true;
            SelectImage.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(418, 129);
            label2.Name = "label2";
            label2.Size = new Size(455, 30);
            label2.TabIndex = 4;
            label2.Text = "Напишите текст вашей новости здесь:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(418, 162);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(455, 627);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 560);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(225, 23);
            comboBox1.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(30, 527);
            label3.Name = "label3";
            label3.Size = new Size(320, 30);
            label3.TabIndex = 7;
            label3.Text = "Выберите автора новости:\r\n";
            // 
            // createNewsButton
            // 
            createNewsButton.FlatStyle = FlatStyle.Flat;
            createNewsButton.Font = new Font("Franklin Gothic Medium", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            createNewsButton.Location = new Point(798, 917);
            createNewsButton.Name = "createNewsButton";
            createNewsButton.Size = new Size(178, 71);
            createNewsButton.TabIndex = 8;
            createNewsButton.Text = "Создать новость";
            createNewsButton.UseVisualStyleBackColor = true;
            createNewsButton.Click += createNewsButton_Click;
            // 
            // BackButton
            // 
            BackButton.Cursor = Cursors.Hand;
            BackButton.FlatStyle = FlatStyle.Flat;
            BackButton.Font = new Font("Franklin Gothic Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            BackButton.Location = new Point(12, 917);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(169, 71);
            BackButton.TabIndex = 17;
            BackButton.Text = "Назад";
            BackButton.UseVisualStyleBackColor = true;
            BackButton.Click += button3_Click;
            BackButton.MouseDown += button3_MouseDown;
            BackButton.MouseMove += button3_MouseMove;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(960, 0);
            label4.Name = "label4";
            label4.Size = new Size(41, 43);
            label4.TabIndex = 18;
            label4.Text = "X";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientActiveCaption;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(53, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(287, 282);
            panel1.TabIndex = 19;
            // 
            // CreateNews
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(1000, 1000);
            Controls.Add(label4);
            Controls.Add(BackButton);
            Controls.Add(createNewsButton);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(richTextBox1);
            Controls.Add(label2);
            Controls.Add(SelectImage);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CreateNews";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CreateNews";
            Load += CreateNews_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button SelectImage;
        private Label label2;
        private RichTextBox richTextBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Button createNewsButton;
        private Button BackButton;
        private Label label4;
        private Panel panel1;
    }
}