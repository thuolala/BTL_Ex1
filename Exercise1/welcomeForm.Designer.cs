namespace Exercise1
{
    partial class welcomeForm
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
            components = new System.ComponentModel.Container();
            exit = new PictureBox();
            label1 = new Label();
            panelTittle = new Panel();
            panelA = new Panel();
            panelB = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            panelTittle.SuspendLayout();
            panelA.SuspendLayout();
            SuspendLayout();
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources._switch;
            exit.Location = new Point(598, 12);
            exit.Name = "exit";
            exit.Size = new Size(24, 24);
            exit.TabIndex = 0;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Vladimir Script", 48F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(255, 207, 213);
            label1.Location = new Point(75, 13);
            label1.Name = "label1";
            label1.Size = new Size(256, 78);
            label1.TabIndex = 0;
            label1.Text = "TM Café";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTittle
            // 
            panelTittle.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelTittle.BackColor = Color.Transparent;
            panelTittle.Controls.Add(label1);
            panelTittle.Location = new Point(112, 147);
            panelTittle.Name = "panelTittle";
            panelTittle.Size = new Size(417, 102);
            panelTittle.TabIndex = 1;
            // 
            // panelA
            // 
            panelA.BackColor = Color.Transparent;
            panelA.Controls.Add(panelB);
            panelA.Dock = DockStyle.Bottom;
            panelA.Location = new Point(0, 430);
            panelA.Name = "panelA";
            panelA.Size = new Size(640, 20);
            panelA.TabIndex = 2;
            // 
            // panelB
            // 
            panelB.BackColor = Color.FromArgb(255, 225, 207);
            panelB.Location = new Point(0, 0);
            panelB.Name = "panelB";
            panelB.Size = new Size(100, 20);
            panelB.TabIndex = 0;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // welcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.backg;
            ClientSize = new Size(640, 450);
            Controls.Add(panelA);
            Controls.Add(panelTittle);
            Controls.Add(exit);
            FormBorderStyle = FormBorderStyle.None;
            Name = "welcomeForm";
            StartPosition = FormStartPosition.WindowsDefaultBounds;
            Load += welcomeForm_Load;
            MouseDown += welcomeForm_MouseDown;
            MouseMove += welcomeForm_MouseMove;
            MouseUp += welcomeForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            panelTittle.ResumeLayout(false);
            panelTittle.PerformLayout();
            panelA.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox exit;
        private Label label1;
        private Panel panelTittle;
        private Panel panelA;
        private Panel panelB;
        private System.Windows.Forms.Timer timer1;
    }
}