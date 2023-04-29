namespace Exercise1
{
    partial class manageOrderForm
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

        private void InitializeComponent()
        {
            panelProduct = new Panel();
            searchByCusID = new TextBox();
            searchByDate = new TextBox();
            searchByOrderID = new TextBox();
            pictureBoxRefresh = new PictureBox();
            btnAdd = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            panelList = new Panel();
            dataGridViewOrder = new DataGridView();
            panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).BeginInit();
            SuspendLayout();
            // 
            // panelProduct
            // 
            panelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProduct.AutoSize = true;
            panelProduct.BackColor = Color.FromArgb(255, 207, 213);
            panelProduct.Controls.Add(searchByCusID);
            panelProduct.Controls.Add(searchByDate);
            panelProduct.Controls.Add(searchByOrderID);
            panelProduct.Controls.Add(pictureBoxRefresh);
            panelProduct.Controls.Add(btnAdd);
            panelProduct.Controls.Add(label3);
            panelProduct.Controls.Add(label1);
            panelProduct.Controls.Add(label2);
            panelProduct.Controls.Add(panelList);
            panelProduct.Location = new Point(0, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(702, 534);
            panelProduct.TabIndex = 0;
            // 
            // searchByCusID
            // 
            searchByCusID.BorderStyle = BorderStyle.None;
            searchByCusID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByCusID.ForeColor = SystemColors.ControlDarkDark;
            searchByCusID.Location = new Point(177, 105);
            searchByCusID.Name = "searchByCusID";
            searchByCusID.Size = new Size(266, 22);
            searchByCusID.TabIndex = 13;
            searchByCusID.TextChanged += searchByCusID_TextChanged;
            // 
            // searchByDate
            // 
            searchByDate.BorderStyle = BorderStyle.None;
            searchByDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByDate.ForeColor = SystemColors.ControlDarkDark;
            searchByDate.Location = new Point(177, 60);
            searchByDate.Name = "searchByDate";
            searchByDate.Size = new Size(266, 22);
            searchByDate.TabIndex = 12;
            searchByDate.TextChanged += searchByDate_TextChanged;
            // 
            // searchByOrderID
            // 
            searchByOrderID.BorderStyle = BorderStyle.None;
            searchByOrderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByOrderID.ForeColor = SystemColors.ControlDarkDark;
            searchByOrderID.Location = new Point(177, 19);
            searchByOrderID.Name = "searchByOrderID";
            searchByOrderID.Size = new Size(266, 22);
            searchByOrderID.TabIndex = 11;
            searchByOrderID.TextChanged += searchByOrderID_TextChanged;
            // 
            // pictureBoxRefresh
            // 
            pictureBoxRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBoxRefresh.Image = Properties.Resources.refresh__2_;
            pictureBoxRefresh.Location = new Point(629, 140);
            pictureBoxRefresh.Name = "pictureBoxRefresh";
            pictureBoxRefresh.Size = new Size(32, 32);
            pictureBoxRefresh.TabIndex = 8;
            pictureBoxRefresh.TabStop = false;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Image = Properties.Resources.cargo;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(466, 84);
            btnAdd.MaximumSize = new Size(222, 50);
            btnAdd.MinimumSize = new Size(36, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "    Create Order";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(33, 105);
            label3.Name = "label3";
            label3.Size = new Size(127, 21);
            label3.TabIndex = 6;
            label3.Text = "By Customer ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(69, 21);
            label1.TabIndex = 4;
            label1.Text = "By Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(33, 19);
            label2.Name = "label2";
            label2.Size = new Size(97, 21);
            label2.TabIndex = 2;
            label2.Text = "By Order ID";
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.AutoSize = true;
            panelList.Controls.Add(dataGridViewOrder);
            panelList.Location = new Point(33, 189);
            panelList.Name = "panelList";
            panelList.Size = new Size(628, 333);
            panelList.TabIndex = 0;
            // 
            // dataGridViewOrder
            // 
            dataGridViewOrder.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOrder.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewOrder.BackgroundColor = Color.White;
            dataGridViewOrder.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrder.Dock = DockStyle.Fill;
            dataGridViewOrder.Location = new Point(0, 0);
            dataGridViewOrder.Name = "dataGridViewOrder";
            dataGridViewOrder.RowTemplate.Height = 25;
            dataGridViewOrder.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewOrder.Size = new Size(628, 333);
            dataGridViewOrder.TabIndex = 0;
            // 
            // manageOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(700, 530);
            Controls.Add(panelProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageOrderForm";
            Load += manageOrderForm_Load;
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrder).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProduct;
        private Panel panelList;
        private DataGridView dataGridViewOrder;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Label label3;
        private PictureBox pictureBoxRefresh;
        private TextBox searchByCusID;
        private TextBox searchByDate;
        private TextBox searchByOrderID;
    }
}