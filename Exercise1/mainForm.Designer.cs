namespace Exercise1
{
    partial class mainForm
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
            panel1 = new Panel();
            panelAction = new Panel();
            sidebar = new FlowLayoutPanel();
            pictureBoxMenu = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            btnProduct = new Button();
            btnAgent = new Button();
            btnOrder = new Button();
            timerMenu = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelAction);
            panel1.Controls.Add(sidebar);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // panelAction
            // 
            panelAction.AutoSize = true;
            panelAction.Dock = DockStyle.Fill;
            panelAction.Location = new Point(200, 0);
            panelAction.Name = "panelAction";
            panelAction.Size = new Size(600, 450);
            panelAction.TabIndex = 1;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(255, 225, 207);
            sidebar.Controls.Add(pictureBoxMenu);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(btnProduct);
            sidebar.Controls.Add(btnAgent);
            sidebar.Controls.Add(btnOrder);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(200, 0);
            sidebar.MinimumSize = new Size(36, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(200, 450);
            sidebar.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            pictureBoxMenu.Image = Properties.Resources.menu_button_of_three_horizontal_lines;
            pictureBoxMenu.Location = new Point(3, 3);
            pictureBoxMenu.Name = "pictureBoxMenu";
            pictureBoxMenu.Size = new Size(32, 32);
            pictureBoxMenu.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxMenu.TabIndex = 0;
            pictureBoxMenu.TabStop = false;
            pictureBoxMenu.Click += pictureBoxMenu_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Location = new Point(3, 41);
            panel2.Name = "panel2";
            panel2.Size = new Size(197, 60);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(3, 17);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Hi, Admin!";
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnProduct.ForeColor = SystemColors.ControlDarkDark;
            btnProduct.Image = Properties.Resources.cupcake;
            btnProduct.ImageAlign = ContentAlignment.MiddleLeft;
            btnProduct.Location = new Point(3, 107);
            btnProduct.MaximumSize = new Size(195, 50);
            btnProduct.MinimumSize = new Size(36, 0);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(195, 50);
            btnProduct.TabIndex = 0;
            btnProduct.Text = "    Manage Product";
            btnProduct.UseVisualStyleBackColor = false;
            btnProduct.Click += btnProduct_Click;
            // 
            // btnAgent
            // 
            btnAgent.BackColor = Color.Transparent;
            btnAgent.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAgent.ForeColor = SystemColors.ControlDarkDark;
            btnAgent.Image = Properties.Resources.rating;
            btnAgent.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgent.Location = new Point(3, 163);
            btnAgent.MaximumSize = new Size(195, 50);
            btnAgent.MinimumSize = new Size(36, 0);
            btnAgent.Name = "btnAgent";
            btnAgent.Size = new Size(195, 50);
            btnAgent.TabIndex = 1;
            btnAgent.Text = " Manage Agent";
            btnAgent.UseVisualStyleBackColor = false;
            btnAgent.Click += btnAgent_Click;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Transparent;
            btnOrder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnOrder.ForeColor = SystemColors.ControlDarkDark;
            btnOrder.Image = Properties.Resources.cargo;
            btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
            btnOrder.Location = new Point(3, 219);
            btnOrder.MaximumSize = new Size(195, 50);
            btnOrder.MinimumSize = new Size(36, 0);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(195, 50);
            btnOrder.TabIndex = 2;
            btnOrder.Text = "Manage Order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // timerMenu
            // 
            timerMenu.Tick += timerMenu_Tick;
            // 
            // mainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "mainForm";
            Text = "TM Café";
            Load += mainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxMenu).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelAction;
        private FlowLayoutPanel sidebar;
        private PictureBox pictureBoxMenu;
        private System.Windows.Forms.Timer timerMenu;
        private Button btnProduct;
        private Button btnAgent;
        private Button btnOrder;
        private Panel panel2;
        private Label label2;
    }
}