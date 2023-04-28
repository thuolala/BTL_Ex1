namespace Exercise1
{
    partial class view
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
            btnAdd = new Button();
            label3 = new Label();
            comboBoxByCus = new ComboBox();
            label1 = new Label();
            comboBoxByItem = new ComboBox();
            label2 = new Label();
            comboBoxCate = new ComboBox();
            panelList = new Panel();
            dataGridViewProduct = new DataGridView();
            panelProduct.SuspendLayout();
            panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            SuspendLayout();
            // 
            // panelProduct
            // 
            panelProduct.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelProduct.AutoSize = true;
            panelProduct.BackColor = Color.FromArgb(255, 207, 213);
            panelProduct.Controls.Add(btnAdd);
            panelProduct.Controls.Add(label3);
            panelProduct.Controls.Add(comboBoxByCus);
            panelProduct.Controls.Add(label1);
            panelProduct.Controls.Add(comboBoxByItem);
            panelProduct.Controls.Add(label2);
            panelProduct.Controls.Add(comboBoxCate);
            panelProduct.Controls.Add(panelList);
            panelProduct.Location = new Point(0, 0);
            panelProduct.Name = "panelProduct";
            panelProduct.Size = new Size(702, 504);
            panelProduct.TabIndex = 0;
            panelProduct.Paint += panelProduct_Paint;
            // 
            // btnAdd
            // 
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
            // comboBoxByCus
            // 
            comboBoxByCus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxByCus.FormattingEnabled = true;
            comboBoxByCus.Location = new Point(145, 105);
            comboBoxByCus.Name = "comboBoxByCus";
            comboBoxByCus.Size = new Size(291, 29);
            comboBoxByCus.TabIndex = 5;
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
            // comboBoxByItem
            // 
            comboBoxByItem.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxByItem.FormattingEnabled = true;
            comboBoxByItem.Location = new Point(145, 60);
            comboBoxByItem.Name = "comboBoxByItem";
            comboBoxByItem.Size = new Size(291, 29);
            comboBoxByItem.TabIndex = 3;
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
            comboBoxCate.Location = new Point(145, 16);
            comboBoxCate.Name = "comboBoxCate";
            comboBoxCate.Size = new Size(291, 29);
            comboBoxCate.TabIndex = 1;
            comboBoxCate.SelectedIndexChanged += comboBoxCate_SelectedIndexChanged;
            // 
            // panelList
            // 
            panelList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelList.AutoSize = true;
            panelList.Controls.Add(dataGridViewProduct);
            panelList.Location = new Point(33, 165);
            panelList.Name = "panelList";
            panelList.Size = new Size(628, 327);
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
            dataGridViewProduct.Size = new Size(628, 327);
            dataGridViewProduct.TabIndex = 0;
            // 
            // viewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.White;
            ClientSize = new Size(700, 500);
            Controls.Add(panelProduct);
            FormBorderStyle = FormBorderStyle.None;
            Name = "viewProduct";
            Load += viewProduct_Load;
            panelProduct.ResumeLayout(false);
            panelProduct.PerformLayout();
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
        private ComboBox comboBoxByItem;
        private Label label2;
        private Button btnAdd;
        private Label label3;
        private ComboBox comboBoxByCus;
    }
}