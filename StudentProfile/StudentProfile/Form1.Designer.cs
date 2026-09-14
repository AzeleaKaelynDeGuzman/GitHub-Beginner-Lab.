namespace StudentProfile
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
            lblStudentProfile = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblStudentProfile
            // 
            lblStudentProfile.AutoSize = true;
            lblStudentProfile.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStudentProfile.Location = new Point(33, 37);
            lblStudentProfile.Name = "lblStudentProfile";
            lblStudentProfile.Size = new Size(423, 32);
            lblStudentProfile.TabIndex = 0;
            lblStudentProfile.Text = "Student Profile - GitHub Beginner Lab.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(33, 85);
            label1.Name = "label1";
            label1.Size = new Size(346, 32);
            label1.TabIndex = 1;
            label1.Text = "Contact Number: 09281503182";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(589, 163);
            Controls.Add(label1);
            Controls.Add(lblStudentProfile);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentProfile;
        private Label label1;
    }
}
