namespace Dashboard
{
    partial class Dashboard
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
            btnRegister = new Button();
            btnRegisterList = new Button();
            SuspendLayout();
            // 
            // btnRegister
            // 
            btnRegister.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegister.Location = new Point(85, 194);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(236, 63);
            btnRegister.TabIndex = 1;
            btnRegister.Text = "REGISTER";
            btnRegister.UseVisualStyleBackColor = true;
            // 
            // btnRegisterList
            // 
            btnRegisterList.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnRegisterList.Location = new Point(435, 194);
            btnRegisterList.Name = "btnRegisterList";
            btnRegisterList.Size = new Size(236, 63);
            btnRegisterList.TabIndex = 2;
            btnRegisterList.Text = "STUDENT LIST";
            btnRegisterList.UseVisualStyleBackColor = true;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegisterList);
            Controls.Add(btnRegister);
            Name = "Dashboard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRegister;
        private Button btnRegisterList;
    }
}