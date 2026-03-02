namespace Dashboard
{
    partial class StudentList
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
            txtSearch = new TextBox();
            btnSearch = new Button();
            dataGridView1 = new DataGridView();
            btnRefresh = new Button();
            btnSaveRecord = new Button();
            label2 = new Label();
            cbSection = new ComboBox();
            cbCourse = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAge = new TextBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            btnDeleteRecord = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(71, 59);
            label1.Name = "label1";
            label1.Size = new Size(234, 28);
            label1.TabIndex = 8;
            label1.Text = "STUDENT MASTER LIST";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 15F);
            txtSearch.Location = new Point(71, 114);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(319, 34);
            txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.ControlLight;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSearch.Location = new Point(406, 117);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(124, 31);
            btnSearch.TabIndex = 10;
            btnSearch.Text = "SEARCH";
            btnSearch.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(71, 165);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(620, 427);
            dataGridView1.TabIndex = 11;
            // 
            // btnRefresh
            // 
            btnRefresh.BackColor = SystemColors.ControlLight;
            btnRefresh.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRefresh.Location = new Point(567, 21);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(124, 31);
            btnRefresh.TabIndex = 12;
            btnRefresh.Text = "REFRESH";
            btnRefresh.UseVisualStyleBackColor = false;
            // 
            // btnSaveRecord
            // 
            btnSaveRecord.BackColor = SystemColors.ControlLight;
            btnSaveRecord.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSaveRecord.Location = new Point(831, 374);
            btnSaveRecord.Name = "btnSaveRecord";
            btnSaveRecord.Size = new Size(273, 46);
            btnSaveRecord.TabIndex = 14;
            btnSaveRecord.Text = "SAVE RECORD";
            btnSaveRecord.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(789, 59);
            label2.Name = "label2";
            label2.Size = new Size(333, 28);
            label2.TabIndex = 15;
            label2.Text = "UPDATE STUDENT INFORMATION";
            // 
            // cbSection
            // 
            cbSection.Font = new Font("Segoe UI", 15F);
            cbSection.FormattingEnabled = true;
            cbSection.Location = new Point(831, 279);
            cbSection.Name = "cbSection";
            cbSection.Size = new Size(273, 36);
            cbSection.TabIndex = 25;
            // 
            // cbCourse
            // 
            cbCourse.Font = new Font("Segoe UI", 15F);
            cbCourse.FormattingEnabled = true;
            cbCourse.Location = new Point(831, 232);
            cbCourse.Name = "cbCourse";
            cbCourse.Size = new Size(273, 36);
            cbCourse.TabIndex = 24;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.Location = new Point(771, 326);
            label5.Name = "label5";
            label5.Size = new Size(54, 28);
            label5.TabIndex = 23;
            label5.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.Location = new Point(738, 282);
            label4.Name = "label4";
            label4.Size = new Size(87, 28);
            label4.TabIndex = 22;
            label4.Text = "Section:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.Location = new Point(744, 232);
            label3.Name = "label3";
            label3.Size = new Size(81, 28);
            label3.TabIndex = 21;
            label3.Text = "Course:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label6.Location = new Point(717, 187);
            label6.Name = "label6";
            label6.Size = new Size(113, 28);
            label6.TabIndex = 20;
            label6.Text = "Last name:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label7.Location = new Point(714, 144);
            label7.Name = "label7";
            label7.Size = new Size(116, 28);
            label7.TabIndex = 19;
            label7.Text = "FIrst name:";
            label7.Click += label7_Click;
            // 
            // txtAge
            // 
            txtAge.Font = new Font("Segoe UI", 15F);
            txtAge.Location = new Point(831, 320);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(273, 34);
            txtAge.TabIndex = 18;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(831, 184);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(273, 34);
            txtLastName.TabIndex = 17;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(836, 141);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(273, 34);
            txtFirstName.TabIndex = 16;
            // 
            // btnDeleteRecord
            // 
            btnDeleteRecord.BackColor = SystemColors.ControlLight;
            btnDeleteRecord.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDeleteRecord.Location = new Point(831, 426);
            btnDeleteRecord.Name = "btnDeleteRecord";
            btnDeleteRecord.Size = new Size(273, 46);
            btnDeleteRecord.TabIndex = 26;
            btnDeleteRecord.Text = "DELETE RECORD";
            btnDeleteRecord.UseVisualStyleBackColor = false;
            // 
            // StudentList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1178, 627);
            Controls.Add(btnDeleteRecord);
            Controls.Add(cbSection);
            Controls.Add(cbCourse);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(txtAge);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(label2);
            Controls.Add(btnSaveRecord);
            Controls.Add(btnRefresh);
            Controls.Add(dataGridView1);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(label1);
            Name = "StudentList";
            Text = "StudentList";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtSearch;
        private Button btnSearch;
        private DataGridView dataGridView1;
        private Button btnRefresh;
        private Button button1;
        private Button btnSaveRecord;
        private Label label2;
        private ComboBox cbSection;
        private ComboBox cbCourse;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label7;
        private TextBox txtAge;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Button btnDeleteRecord;
    }
}