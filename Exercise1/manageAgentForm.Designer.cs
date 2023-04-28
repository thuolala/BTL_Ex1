namespace Exercise1
{
    partial class manageAgentForm
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
            panelCus = new Panel();
            searchByName = new TextBox();
            pictureBoxRefresh = new PictureBox();
            btnAdd = new Button();
            label1 = new Label();
            label2 = new Label();
            panelList = new Panel();
            dataGridViewCustomer = new DataGridView();
            searchByID = new TextBox();
            panelCus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).BeginInit();
            SuspendLayout();
            // 
            // panelCus
            // 
            panelCus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelCus.AutoSize = true;
            panelCus.BackColor = Color.FromArgb(255, 207, 213);
            panelCus.Controls.Add(searchByID);
            panelCus.Controls.Add(searchByName);
            panelCus.Controls.Add(pictureBoxRefresh);
            panelCus.Controls.Add(btnAdd);
            panelCus.Controls.Add(label1);
            panelCus.Controls.Add(label2);
            panelCus.Controls.Add(panelList);
            panelCus.Location = new Point(0, 0);
            panelCus.Name = "panelCus";
            panelCus.Size = new Size(702, 534);
            panelCus.TabIndex = 0;
            // 
            // searchByName
            // 
            searchByName.BorderStyle = BorderStyle.None;
            searchByName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByName.ForeColor = SystemColors.ControlDarkDark;
            searchByName.Location = new Point(158, 60);
            searchByName.Name = "searchByName";
            searchByName.Size = new Size(278, 22);
            searchByName.TabIndex = 10;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxRefresh.Image = Properties.Resources.refresh__2_;
            pictureBoxRefresh.Location = new Point(629, 87);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(32, 32);
            pictureBoxRefresh.TabIndex = 8;
            pictureBoxRefresh.TabStop = false;
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Image = Properties.Resources.income;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(466, 32);
            btnAdd.MaximumSize = new Size(222, 50);
            btnAdd.MinimumSize = new Size(36, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "    Add Customer";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(79, 21);
            label1.TabIndex = 4;
            label1.Text = "By Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(33, 19);
            label2.Name = "label2";
            label2.Size = new Size(50, 21);
            label2.TabIndex = 2;
            label2.Text = "By ID";
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.AutoSize = true;
            panelList.Controls.Add(dataGridViewCustomer);
            panelList.Location = new Point(33, 125);
            panelList.Name = "panelList";
            panelList.Size = new Size(628, 397);
            panelList.TabIndex = 0;
            // 
            // dataGridViewCustomer
            // 
            dataGridViewCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCustomer.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewCustomer.BackgroundColor = Color.White;
            dataGridViewCustomer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCustomer.Dock = DockStyle.Fill;
            dataGridViewCustomer.Location = new Point(0, 0);
            dataGridViewCustomer.Name = "dataGridViewCustomer";
            dataGridViewCustomer.RowTemplate.Height = 25;
            dataGridViewCustomer.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewCustomer.Size = new Size(628, 397);
            dataGridViewCustomer.TabIndex = 0;
            // 
            // searchByID
            // 
            searchByID.BorderStyle = BorderStyle.None;
            searchByID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByID.ForeColor = SystemColors.ControlDarkDark;
            searchByID.Location = new Point(158, 18);
            searchByID.Name = "searchByID";
            searchByID.Size = new Size(278, 22);
            searchByID.TabIndex = 11;
            // 
            // manageAgentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(700, 530);
            Controls.Add(panelCus);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageAgentForm";
            Load += manageAgentForm_Load;
            panelCus.ResumeLayout(false);
            panelCus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewCustomer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelCus;
        private Panel panelList;
        private DataGridView dataGridViewCustomer;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private PictureBox pictureBoxRefresh;
        private TextBox searchByName;
        private TextBox searchByID;
    }
}