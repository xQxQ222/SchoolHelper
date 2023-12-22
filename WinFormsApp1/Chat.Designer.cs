namespace WinFormsApp1
{
    partial class Chat
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
            label11 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            panel4 = new Panel();
            Send = new Button();
            richTextBox1 = new RichTextBox();
            label2 = new Label();
            label3 = new Label();
            panel5 = new Panel();
            label4 = new Label();
            comboBox1 = new ComboBox();
            label5 = new Label();
            button1 = new Button();
            RecievedMessages = new ListView();
            id = new ColumnHeader();
            Sender = new ColumnHeader();
            MessageText = new ColumnHeader();
            SendMessages = new ListView();
            id2 = new ColumnHeader();
            Reciever = new ColumnHeader();
            TextOfMessage = new ColumnHeader();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Cursor = Cursors.Hand;
            label11.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(1467, -3);
            label11.Name = "label11";
            label11.Size = new Size(34, 34);
            label11.TabIndex = 29;
            label11.Text = "X";
            label11.Click += ExitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Location = new Point(750, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(3, 1004);
            panel1.TabIndex = 30;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Location = new Point(0, 90);
            panel2.Name = "panel2";
            panel2.Size = new Size(1500, 3);
            panel2.TabIndex = 31;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Medium", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(318, 43);
            label1.TabIndex = 32;
            label1.Text = "Ваши сообщения";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Location = new Point(0, 60);
            panel3.Name = "panel3";
            panel3.Size = new Size(589, 3);
            panel3.TabIndex = 31;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(Send);
            panel4.Controls.Add(richTextBox1);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(panel3);
            panel4.Location = new Point(824, 149);
            panel4.Name = "panel4";
            panel4.Size = new Size(589, 717);
            panel4.TabIndex = 33;
            // 
            // Send
            // 
            Send.FlatStyle = FlatStyle.Flat;
            Send.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Send.ForeColor = Color.Gray;
            Send.Location = new Point(433, 655);
            Send.Name = "Send";
            Send.Size = new Size(150, 50);
            Send.TabIndex = 34;
            Send.Text = "Отправить";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 69);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(580, 580);
            richTextBox1.TabIndex = 34;
            richTextBox1.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(3, 14);
            label2.Name = "label2";
            label2.Size = new Size(328, 37);
            label2.TabIndex = 33;
            label2.Text = "Введите сообщение:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(381, 37);
            label3.TabIndex = 34;
            label3.Text = "Полученные сообщения";
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.Location = new Point(0, 455);
            panel5.Name = "panel5";
            panel5.Size = new Size(750, 3);
            panel5.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Franklin Gothic Medium", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Gray;
            label4.Location = new Point(12, 473);
            label4.Name = "label4";
            label4.Size = new Size(417, 37);
            label4.TabIndex = 36;
            label4.Text = "Отправленные сообщения";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1077, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(302, 23);
            comboBox1.TabIndex = 39;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Franklin Gothic Medium", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(759, 24);
            label5.Name = "label5";
            label5.Size = new Size(312, 37);
            label5.TabIndex = 40;
            label5.Text = "Выберите получателя";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Franklin Gothic Medium", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(12, 918);
            button1.Name = "button1";
            button1.Size = new Size(120, 70);
            button1.TabIndex = 41;
            button1.Text = "Назад";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton_Click;
            // 
            // RecievedMessages
            // 
            RecievedMessages.Columns.AddRange(new ColumnHeader[] { id, Sender, MessageText });
            RecievedMessages.Location = new Point(12, 149);
            RecievedMessages.Name = "RecievedMessages";
            RecievedMessages.Size = new Size(715, 288);
            RecievedMessages.TabIndex = 42;
            RecievedMessages.UseCompatibleStateImageBehavior = false;
            RecievedMessages.View = View.Details;
            // 
            // id
            // 
            id.Text = "id";
            id.Width = 40;
            // 
            // Sender
            // 
            Sender.Text = "Отправитель";
            Sender.TextAlign = HorizontalAlignment.Center;
            Sender.Width = 150;
            // 
            // MessageText
            // 
            MessageText.Text = "Текст сообщения";
            MessageText.TextAlign = HorizontalAlignment.Center;
            MessageText.Width = 530;
            // 
            // SendMessages
            // 
            SendMessages.Columns.AddRange(new ColumnHeader[] { id2, Reciever, TextOfMessage });
            SendMessages.Location = new Point(12, 522);
            SendMessages.Name = "SendMessages";
            SendMessages.Size = new Size(715, 288);
            SendMessages.TabIndex = 43;
            SendMessages.UseCompatibleStateImageBehavior = false;
            SendMessages.View = View.Details;
            // 
            // id2
            // 
            id2.Text = "id";
            // 
            // Reciever
            // 
            Reciever.Text = "Получатель";
            Reciever.TextAlign = HorizontalAlignment.Center;
            Reciever.Width = 150;
            // 
            // TextOfMessage
            // 
            TextOfMessage.Text = "Текст сообщения";
            TextOfMessage.TextAlign = HorizontalAlignment.Center;
            TextOfMessage.Width = 530;
            // 
            // Chat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(1500, 1000);
            Controls.Add(SendMessages);
            Controls.Add(RecievedMessages);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(panel4);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label11);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Chat";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chat";
            Load += Chat_Load;
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label11;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Panel panel3;
        private Panel panel4;
        private RichTextBox richTextBox1;
        private Label label2;
        private Button Send;
        private Label label3;
        private Panel panel5;
        private Label label4;
        private ComboBox comboBox1;
        private Label label5;
        private Button button1;
        private ListView RecievedMessages;
        private ListView SendMessages;
        private ColumnHeader id;
        private ColumnHeader Sender;
        private ColumnHeader MessageText;
        private ColumnHeader id2;
        private ColumnHeader Reciever;
        private ColumnHeader TextOfMessage;
    }
}