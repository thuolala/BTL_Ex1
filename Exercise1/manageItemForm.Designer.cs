namespace Exercise1
{
    partial class manageItemForm
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
            panelProduct = new Panel();
            searchByCustomerID = new TextBox();
            searchByItemName = new TextBox();
            btnTop3 = new Button();
            pictureBoxRefresh = new PictureBox();
            btnAdd = new Button();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            comboBoxCate = new ComboBox();
            panelList = new Panel();
            dataGridViewProduct = new DataGridView();
            panelProduct.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).BeginInit();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // panelProduct
            // 
            panelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProduct.AutoSize = true;
            panelProduct.BackColor = Color.FromArgb(255, 207, 213);
            panelProduct.Controls.Add(searchByCustomerID);
            panelProduct.Controls.Add(searchByItemName);
            panelProduct.Controls.Add(btnTop3);
            panelProduct.Controls.Add(pictureBoxRefresh);
            panelProduct.Controls.Add(btnAdd);
            panelProduct.Controls.Add(label3);
            panelProduct.Controls.Add(label1);
            panelProduct.Controls.Add(label2);
            panelProduct.Controls.Add(comboBoxCate);
            panelProduct.Controls.Add(panelList);
            panelProduct.Location = new Point(0, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(702, 534);
            panelProduct.TabIndex = 0;
            panelProduct.Paint += panelProduct_Paint;
            // 
            // searchByCustomerID
            // 
            searchByCustomerID.BorderStyle = BorderStyle.None;
            searchByCustomerID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByCustomerID.ForeColor = SystemColors.ControlDarkDark;
            searchByCustomerID.Location = new Point(158, 99);
            searchByCustomerID.Name = "searchByCustomerID";
            searchByCustomerID.Size = new Size(278, 22);
            searchByCustomerID.TabIndex = 14;
            searchByCustomerID.TextChanged += searchByCustomerID_TextChanged;
            // 
            // searchByItemName
            // 
            searchByItemName.BorderStyle = BorderStyle.None;
            searchByItemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchByItemName.ForeColor = SystemColors.ControlDarkDark;
            searchByItemName.Location = new Point(158, 60);
            searchByItemName.Name = "searchByItemName";
            searchByItemName.Size = new Size(278, 22);
            searchByItemName.TabIndex = 13;
            searchByItemName.TextChanged += searchByItemName_TextChanged;
            // 
            // btnTop3
            // 
            btnTop3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnTop3.BackColor = Color.Transparent;
            btnTop3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnTop3.ForeColor = SystemColors.ControlDarkDark;
            btnTop3.Image = Properties.Resources.podium;
            btnTop3.ImageAlign = ContentAlignment.MiddleLeft;
            btnTop3.Location = new Point(466, 16);
            btnTop3.MaximumSize = new Size(222, 50);
            btnTop3.MinimumSize = new Size(36, 0);
            btnTop3.Name = "btnTop3";
            btnTop3.Size = new Size(195, 50);
            btnTop3.TabIndex = 9;
            btnTop3.Text = "    Top 3 Items";
            btnTop3.UseVisualStyleBackColor = false;
            btnTop3.Click += btnTop3_Click;
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
            pictureBoxRefresh.Click += pictureBoxRefresh_Click;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            btnAdd.BackColor = Color.Transparent;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Image = Properties.Resources.cupcake;
            btnAdd.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdd.Location = new Point(466, 84);
            btnAdd.MaximumSize = new Size(222, 50);
            btnAdd.MinimumSize = new Size(36, 0);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(195, 50);
            btnAdd.TabIndex = 7;
            btnAdd.Text = "    Add Product";
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
            label3.Size = new Size(106, 21);
            label3.TabIndex = 6;
            label3.Text = "By Customer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(33, 60);
            label1.Name = "label1";
            label1.Size = new Size(68, 21);
            label1.TabIndex = 4;
            label1.Text = "By Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(33, 19);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 2;
            label2.Text = "Categories";
            // 
            // comboBoxCate
            // 
            comboBoxCate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCate.FormattingEnabled = true;
            comboBoxCate.Location = new Point(158, 16);
            comboBoxCate.Name = "comboBoxCate";
            comboBoxCate.Size = new Size(278, 29);
            comboBoxCate.TabIndex = 1;
            comboBoxCate.SelectedIndexChanged += comboBoxCate_SelectedIndexChanged;
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.AutoSize = true;
            panelList.Controls.Add(dataGridViewProduct);
            panelList.Location = new Point(33, 189);
            panelList.Name = "panelList";
            panelList.Size = new Size(628, 333);
            panelList.TabIndex = 0;
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProduct.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dataGridViewProduct.BackgroundColor = Color.White;
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Dock = DockStyle.Fill;
            dataGridViewProduct.Location = new Point(0, 0);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.RowTemplate.Height = 25;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(628, 333);
            dataGridViewProduct.TabIndex = 0;
            // 
            // manageItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(700, 530);
            Controls.Add(panelProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "manageItemForm";
            Load += manageItemForm_Load;
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRefresh).EndInit();
            panelList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelProduct;
        private Panel panelList;
        private DataGridView dataGridViewProduct;
        private ComboBox comboBoxCate;
        private Label label1;
        private Label label2;
        private Button btnAdd;
        private Label label3;
        private PictureBox pictureBoxRefresh;
        private Button btnTop3;
        private TextBox searchByCustomerID;
        private TextBox searchByItemName;
    }
}