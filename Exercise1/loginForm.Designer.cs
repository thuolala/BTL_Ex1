namespace Exercise1
{
    partial class loginForm
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
            exit = new PictureBox();
            label1 = new Label();
            panelLogin = new Panel();
            error = new Label();
            btnLogin = new Button();
            password = new TextBox();
            username = new TextBox();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panelLogin.SuspendLayout();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources._switch;
            exit.Location = new Point(598, 12);
            exit.Name = "exit";
            exit.Size = new Size(24, 24);
            exit.TabIndex = 1;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Vladimir Script", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 207, 213);
            label1.Location = new Point(12, 4);
            label1.Name = "label1";
            label1.Size = new Size(112, 32);
            label1.TabIndex = 2;
            label1.Text = "TM Café";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelLogin
            // 
            panelLogin.BackColor = Color.FromArgb(255, 225, 207);
            panelLogin.Controls.Add(error);
            panelLogin.Controls.Add(btnLogin);
            panelLogin.Controls.Add(password);
            panelLogin.Controls.Add(username);
            panelLogin.Controls.Add(label3);
            panelLogin.Controls.Add(label2);
            panelLogin.Location = new Point(120, 119);
            panelLogin.Name = "panelLogin";
            panelLogin.Size = new Size(400, 257);
            panelLogin.TabIndex = 3;
            // 
            // error
            // 
            error.AutoSize = true;
            error.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            error.ForeColor = Color.IndianRed;
            error.Location = new Point(125, 137);
            error.Name = "error";
            error.Size = new Size(12, 17);
            error.TabIndex = 5;
            error.Text = " ";
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLogin.ForeColor = SystemColors.ControlDarkDark;
            btnLogin.Location = new Point(125, 174);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(155, 34);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            btnLogin.Enter += btnLogin_Enter;
            // 
            // password
            // 
            password.BorderStyle = BorderStyle.None;
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = SystemColors.ControlDarkDark;
            password.Location = new Point(125, 112);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(239, 22);
            password.TabIndex = 3;
            // 
            // username
            // 
            username.BorderStyle = BorderStyle.None;
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = SystemColors.ControlDarkDark;
            username.Location = new Point(125, 62);
            username.Name = "username";
            username.Size = new Size(239, 22);
            username.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(17, 112);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 1;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(17, 62);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 0;
            label2.Text = "Username";
            // 
            // loginF
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backg;
            ClientSize = new Size(640, 450);
            Controls.Add(panelLogin);
            Controls.Add(label1);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "loginF";
            MouseDown += loginF_MouseDown;
            MouseMove += loginF_MouseMove;
            MouseUp += loginF_MouseUp;
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panelLogin.ResumeLayout(false);
            panelLogin.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox exit;
        private Label label1;
        private Panel panelLogin;
        private Label error;
        private Button btnLogin;
        private TextBox password;
        private TextBox username;
        private Label label3;
        private Label label2;
    }
}