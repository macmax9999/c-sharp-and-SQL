namespace Dashboard
{
    partial class Login
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
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            btnLogin = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtUsername
            // 
            txtUsername.Font = new Font("Segoe UI", 15F);
            txtUsername.Location = new Point(138, 21);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(273, 34);
            txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Font = new Font("Segoe UI", 15F);
            txtPassword.Location = new Point(138, 61);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(273, 34);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.Location = new Point(21, 64);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ButtonFace;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLogin.Location = new Point(138, 101);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(273, 46);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(21, 27);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(439, 159);
            Controls.Add(btnLogin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label2;
        private Button btnLogin;
        private Label label1;
    }
}