namespace StudentRoom.App
{
    partial class Form1
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            lblStudentProfile = new Label();
            label3 = new Label();
            dgvRooms = new DataGridView();
            cbStatus = new ComboBox();
            cbRoomType = new ComboBox();
            txtPrice = new TextBox();
            txtRoomNumber = new TextBox();
            btnCreate = new Button();
            lblStatus = new Label();
            lblPrice = new Label();
            lblRoomType = new Label();
            lblRoomNumber = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label2);
            panel1.Location = new Point(-1, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(620, 82);
            panel1.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cambria", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(193, 23);
            label2.Name = "label2";
            label2.Size = new Size(286, 41);
            label2.TabIndex = 0;
            label2.Text = "Create New Room";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(151, 653);
            label1.Name = "label1";
            label1.Size = new Size(346, 32);
            label1.TabIndex = 15;
            label1.Text = "Contact Number: 09281503182";
            // 
            // lblStudentProfile
            // 
            lblStudentProfile.AutoSize = true;
            lblStudentProfile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentProfile.Location = new Point(109, 610);
            lblStudentProfile.Name = "lblStudentProfile";
            lblStudentProfile.Size = new Size(423, 32);
            lblStudentProfile.TabIndex = 14;
            lblStudentProfile.Text = "Student Profile - GitHub Beginner Lab.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(247, 700);
            label3.Name = "label3";
            label3.Size = new Size(156, 32);
            label3.TabIndex = 27;
            label3.Text = "YEAR LEVEL 2";
            // 
            // dgvRooms
            // 
            dgvRooms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRooms.Location = new Point(12, 414);
            dgvRooms.Name = "dgvRooms";
            dgvRooms.Size = new Size(595, 182);
            dgvRooms.TabIndex = 26;
            // 
            // cbStatus
            // 
            cbStatus.Font = new Font("Cambria", 18F);
            cbStatus.FormattingEnabled = true;
            cbStatus.Location = new Point(283, 302);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(223, 36);
            cbStatus.TabIndex = 25;
            // 
            // cbRoomType
            // 
            cbRoomType.Font = new Font("Cambria", 18F);
            cbRoomType.FormattingEnabled = true;
            cbRoomType.Location = new Point(283, 178);
            cbRoomType.Name = "cbRoomType";
            cbRoomType.Size = new Size(223, 36);
            cbRoomType.TabIndex = 24;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Cambria", 18F);
            txtPrice.Location = new Point(283, 240);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(223, 36);
            txtPrice.TabIndex = 23;
            // 
            // txtRoomNumber
            // 
            txtRoomNumber.Font = new Font("Cambria", 18F);
            txtRoomNumber.Location = new Point(283, 118);
            txtRoomNumber.Name = "txtRoomNumber";
            txtRoomNumber.Size = new Size(223, 36);
            txtRoomNumber.TabIndex = 22;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.FromArgb(192, 192, 0);
            btnCreate.Font = new Font("Cambria", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.ForeColor = Color.White;
            btnCreate.Location = new Point(333, 361);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(122, 34);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Constantia", 18F);
            lblStatus.Location = new Point(188, 305);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(89, 29);
            lblStatus.TabIndex = 20;
            lblStatus.Text = "Status :";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Constantia", 18F);
            lblPrice.Location = new Point(200, 243);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(77, 29);
            lblPrice.TabIndex = 19;
            lblPrice.Text = "Price :";
            // 
            // lblRoomType
            // 
            lblRoomType.AutoSize = true;
            lblRoomType.Font = new Font("Constantia", 18F);
            lblRoomType.Location = new Point(135, 181);
            lblRoomType.Name = "lblRoomType";
            lblRoomType.Size = new Size(142, 29);
            lblRoomType.TabIndex = 18;
            lblRoomType.Text = "Room Type :";
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Font = new Font("Constantia", 18F);
            lblRoomNumber.Location = new Point(98, 121);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(179, 29);
            lblRoomNumber.TabIndex = 17;
            lblRoomNumber.Text = "Room Number :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 746);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(lblStudentProfile);
            Controls.Add(label3);
            Controls.Add(dgvRooms);
            Controls.Add(cbStatus);
            Controls.Add(cbRoomType);
            Controls.Add(txtPrice);
            Controls.Add(txtRoomNumber);
            Controls.Add(btnCreate);
            Controls.Add(lblStatus);
            Controls.Add(lblPrice);
            Controls.Add(lblRoomType);
            Controls.Add(lblRoomNumber);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRooms).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label lblStudentProfile;
        private Label label3;
        private DataGridView dgvRooms;
        private ComboBox cbStatus;
        private ComboBox cbRoomType;
        private TextBox txtPrice;
        private TextBox txtRoomNumber;
        private Button btnCreate;
        private Label lblStatus;
        private Label lblPrice;
        private Label lblRoomType;
        private Label lblRoomNumber;
    }
}
