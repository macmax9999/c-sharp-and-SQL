namespace Dashboard
{
    partial class RegisterStudent
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
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtAge = new TextBox();
            btnSaveRecord = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cbCourse = new ComboBox();
            cbSection = new ComboBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(172, 100);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 34);
            txtFirstName.TabIndex = 1;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(172, 140);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 34);
            txtLastName.TabIndex = 2;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 15F);
            txtAge.Location = new Point(172, 276);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(273, 34);
            txtAge.TabIndex = 5;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = SystemColors.ButtonFace;
            btnSaveRecord.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveRecord.Location = new Point(172, 316);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(273, 46);
            btnSaveRecord.TabIndex = 6;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(55, 103);
            label1.Name = "label1";
            label1.Size = new Size(116, 28);
            label1.TabIndex = 7;
            label1.Text = "FIrst name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(55, 146);
            label2.Name = "label2";
            label2.Size = new Size(113, 28);
            label2.TabIndex = 8;
            label2.Text = "Last name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(82, 188);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 9;
            label3.Text = "Course:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(76, 235);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 10;
            label4.Text = "Section:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(109, 276);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 11;
            label5.Text = "Age:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(76, 56);
            label6.Name = "label6";
            label6.Size = new Size(347, 28);
            label6.TabIndex = 13;
            label6.Text = "REGISTER STUDENT INFORMATION";
            // 
            // cbCourse
            // 
            cbCourse.Font = new Font("Segoe UI", 15F);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(172, 188);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(273, 36);
            cbCourse.TabIndex = 14;
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 15F);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(172, 235);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(273, 36);
            cbSection.TabIndex = 15;
            // 
            // RegisterStudent
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnSaveRecord);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Name = "RegisterStudent";
            Text = "RegisterStudent";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtAge;
        private Button btnSaveRecord;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cbCourse;
        private ComboBox cbSection;
    }
}