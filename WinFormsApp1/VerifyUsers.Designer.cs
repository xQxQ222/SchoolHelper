namespace WinFormsApp1
{
    partial class VerifyUsers
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
            button3 = new Button();
            label8 = new Label();
            UsersWaitingForConfirm = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            FIO = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            AdditionalStatus = new DataGridViewTextBoxColumn();
            ConfirmButton = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)UsersWaitingForConfirm).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Franklin Gothic Medium", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 526);
            button3.Name = "button3";
            button3.Size = new Size(117, 62);
            button3.TabIndex = 54;
            button3.Text = "Назад";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Cursor = Cursors.Hand;
            label8.Font = new Font("Arial", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(768, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 34);
            label8.TabIndex = 55;
            label8.Text = "X";
            label8.Click += label8_Click;
            // 
            // UsersWaitingForConfirm
            // 
            UsersWaitingForConfirm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersWaitingForConfirm.Columns.AddRange(new DataGridViewColumn[] { id, FIO, Status, AdditionalStatus, ConfirmButton });
            UsersWaitingForConfirm.Location = new Point(28, 35);
            UsersWaitingForConfirm.Name = "UsersWaitingForConfirm";
            UsersWaitingForConfirm.RowTemplate.Height = 25;
            UsersWaitingForConfirm.Size = new Size(735, 485);
            UsersWaitingForConfirm.TabIndex = 56;
            UsersWaitingForConfirm.CellContentClick += UsersWaitingForConfirm_CellContentClick_1;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            id.Width = 40;
            // 
            // FIO
            // 
            FIO.HeaderText = "ФИО";
            FIO.Name = "FIO";
            FIO.ReadOnly = true;
            FIO.Width = 250;
            // 
            // Status
            // 
            Status.HeaderText = "Статус";
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 150;
            // 
            // AdditionalStatus
            // 
            AdditionalStatus.HeaderText = "Класс/Предмет";
            AdditionalStatus.Name = "AdditionalStatus";
            AdditionalStatus.ReadOnly = true;
            // 
            // ConfirmButton
            // 
            ConfirmButton.HeaderText = "Кнопка подтверждения";
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Text = "Подтвердить";
            ConfirmButton.UseColumnTextForButtonValue = true;
            ConfirmButton.Width = 150;
            // 
            // VerifyUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(227, 244, 244);
            ClientSize = new Size(800, 600);
            Controls.Add(UsersWaitingForConfirm);
            Controls.Add(label8);
            Controls.Add(button3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "VerifyUsers";
            StartPosition = FormStartPosition.CenterParent;
            Text = "VerifyUsers";
            Load += VerifyUsers_Load;
            ((System.ComponentModel.ISupportInitialize)UsersWaitingForConfirm).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button3;
        private Label label8;
        private DataGridView UsersWaitingForConfirm;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn FIO;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn AdditionalStatus;
        private DataGridViewButtonColumn ConfirmButton;
    }
}