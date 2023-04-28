namespace Exercise1
{
    partial class addAgentForm
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
            label2 = new Label();
            agentID = new TextBox();
            label1 = new Label();
            agentName = new TextBox();
            label3 = new Label();
            agentPrice = new TextBox();
            label4 = new Label();
            btnSave = new Button();
            btnReset = new Button();
            exit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(161, 21);
            label2.Name = "label2";
            label2.Size = new Size(236, 32);
            label2.TabIndex = 3;
            label2.Text = "Add New Customer";
            // 
            // agentID
            // 
            agentID.BorderStyle = BorderStyle.None;
            agentID.Enabled = false;
            agentID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agentID.ForeColor = SystemColors.ControlDarkDark;
            agentID.Location = new Point(161, 79);
            agentID.Name = "agentID";
            agentID.Size = new Size(142, 22);
            agentID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(104, 21);
            label1.TabIndex = 4;
            label1.Text = "Customer ID";
            // 
            // agentName
            // 
            agentName.BorderStyle = BorderStyle.None;
            agentName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agentName.ForeColor = SystemColors.ControlDarkDark;
            agentName.Location = new Point(161, 136);
            agentName.Name = "agentName";
            agentName.Size = new Size(278, 22);
            agentName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(46, 136);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 6;
            label3.Text = "Full Name";
            // 
            // agentPrice
            // 
            agentPrice.BorderStyle = BorderStyle.None;
            agentPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            agentPrice.ForeColor = SystemColors.ControlDarkDark;
            agentPrice.Location = new Point(161, 198);
            agentPrice.Name = "agentPrice";
            agentPrice.Size = new Size(278, 22);
            agentPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 8;
            label4.Text = "Address";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlDarkDark;
            btnSave.Location = new Point(284, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(155, 34);
            btnSave.TabIndex = 16;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            btnReset.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnReset.ForeColor = SystemColors.ControlDarkDark;
            btnReset.Location = new Point(123, 243);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(155, 34);
            btnReset.TabIndex = 17;
            btnReset.Text = "Cancel";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources._switch;
            exit.Location = new Point(464, 12);
            exit.Name = "exit";
            exit.Size = new Size(24, 24);
            exit.TabIndex = 18;
            exit.TabStop = false;
            // 
            // addAgentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 207);
            ClientSize = new Size(500, 320);
            Controls.Add(exit);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(agentPrice);
            Controls.Add(label4);
            Controls.Add(agentName);
            Controls.Add(label3);
            Controls.Add(agentID);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addAgentForm";
            Text = "addItem";
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox agentID;
        private Label label1;
        private TextBox agentName;
        private Label label3;
        private TextBox agentPrice;
        private Label label4;
        private Button btnSave;
        private Button btnReset;
        private PictureBox exit;
    }
}