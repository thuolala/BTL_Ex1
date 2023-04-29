namespace Exercise1
{
    partial class createOrderForm
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
            orderID = new TextBox();
            label1 = new Label();
            label3 = new Label();
            searchCus = new TextBox();
            label4 = new Label();
            btnCheckout = new Button();
            exit = new PictureBox();
            orderDate = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            searchProduct = new TextBox();
            productList = new RichTextBox();
            label7 = new Label();
            buyQuan = new TextBox();
            cusName = new TextBox();
            avai = new Label();
            labelAvai = new Label();
            btnAdd = new Button();
            label9 = new Label();
            labelQuantity = new Label();
            labelMoney = new Label();
            label10 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)exit).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(196, 21);
            label2.Name = "label2";
            label2.Size = new Size(218, 32);
            label2.TabIndex = 3;
            label2.Text = "Create New Order";
            // 
            // orderID
            // 
            orderID.BorderStyle = BorderStyle.None;
            orderID.Enabled = false;
            orderID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderID.ForeColor = SystemColors.ControlDarkDark;
            orderID.Location = new Point(184, 79);
            orderID.Name = "orderID";
            orderID.Size = new Size(119, 22);
            orderID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(74, 21);
            label1.TabIndex = 4;
            label1.Text = "Order ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(46, 136);
            label3.Name = "label3";
            label3.Size = new Size(93, 21);
            label3.TabIndex = 6;
            label3.Text = "Order Date";
            // 
            // searchCus
            // 
            searchCus.BorderStyle = BorderStyle.None;
            searchCus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchCus.ForeColor = SystemColors.ControlDarkDark;
            searchCus.Location = new Point(184, 198);
            searchCus.Name = "searchCus";
            searchCus.Size = new Size(119, 22);
            searchCus.TabIndex = 9;
            searchCus.TextChanged += searchCus_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(104, 21);
            label4.TabIndex = 8;
            label4.Text = "Customer ID";
            // 
            // btnCheckout
            // 
            btnCheckout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCheckout.ForeColor = SystemColors.ControlDarkDark;
            btnCheckout.Location = new Point(390, 521);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(155, 34);
            btnCheckout.TabIndex = 16;
            btnCheckout.Text = "Checkout";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // exit
            // 
            exit.BackColor = Color.Transparent;
            exit.Image = Properties.Resources._switch;
            exit.Location = new Point(574, 12);
            exit.Name = "exit";
            exit.Size = new Size(24, 24);
            exit.TabIndex = 18;
            exit.TabStop = false;
            exit.Click += exit_Click;
            // 
            // orderDate
            // 
            orderDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            orderDate.Location = new Point(184, 136);
            orderDate.Name = "orderDate";
            orderDate.Size = new Size(361, 29);
            orderDate.TabIndex = 19;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(46, 260);
            label5.Name = "label5";
            label5.Size = new Size(130, 21);
            label5.TabIndex = 20;
            label5.Text = "Choose Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(46, 332);
            label6.Name = "label6";
            label6.Size = new Size(100, 21);
            label6.TabIndex = 21;
            label6.Text = "Product List";
            // 
            // searchProduct
            // 
            searchProduct.BorderStyle = BorderStyle.None;
            searchProduct.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            searchProduct.ForeColor = SystemColors.ControlDarkDark;
            searchProduct.Location = new Point(184, 259);
            searchProduct.Name = "searchProduct";
            searchProduct.Size = new Size(217, 22);
            searchProduct.TabIndex = 22;
            searchProduct.TextChanged += searchProduct_TextChanged;
            // 
            // productList
            // 
            productList.BorderStyle = BorderStyle.FixedSingle;
            productList.Location = new Point(184, 334);
            productList.Name = "productList";
            productList.Size = new Size(361, 136);
            productList.TabIndex = 23;
            productList.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(407, 259);
            label7.Name = "label7";
            label7.Size = new Size(19, 21);
            label7.TabIndex = 24;
            label7.Text = "x";
            // 
            // buyQuan
            // 
            buyQuan.BorderStyle = BorderStyle.None;
            buyQuan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buyQuan.ForeColor = SystemColors.ControlDarkDark;
            buyQuan.Location = new Point(432, 258);
            buyQuan.Name = "buyQuan";
            buyQuan.Size = new Size(75, 22);
            buyQuan.TabIndex = 26;
            // 
            // cusName
            // 
            cusName.BorderStyle = BorderStyle.None;
            cusName.Enabled = false;
            cusName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cusName.ForeColor = SystemColors.ControlDarkDark;
            cusName.Location = new Point(320, 198);
            cusName.Name = "cusName";
            cusName.Size = new Size(225, 22);
            cusName.TabIndex = 27;
            // 
            // avai
            // 
            avai.AutoSize = true;
            avai.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            avai.ForeColor = Color.IndianRed;
            avai.Location = new Point(184, 296);
            avai.Name = "avai";
            avai.Size = new Size(65, 17);
            avai.TabIndex = 28;
            avai.Text = "Available: ";
            // 
            // labelAvai
            // 
            labelAvai.AutoSize = true;
            labelAvai.Enabled = false;
            labelAvai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelAvai.ForeColor = Color.IndianRed;
            labelAvai.Location = new Point(255, 296);
            labelAvai.Name = "labelAvai";
            labelAvai.Size = new Size(12, 17);
            labelAvai.TabIndex = 29;
            labelAvai.Text = " ";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.ForeColor = SystemColors.ControlDarkDark;
            btnAdd.Location = new Point(513, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(22, 22);
            btnAdd.TabIndex = 30;
            btnAdd.Text = "+";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label9.ForeColor = Color.IndianRed;
            label9.Location = new Point(184, 483);
            label9.Name = "label9";
            label9.Size = new Size(95, 17);
            label9.TabIndex = 31;
            label9.Text = "Total Quantity: ";
            // 
            // labelQuantity
            // 
            labelQuantity.AutoSize = true;
            labelQuantity.Enabled = false;
            labelQuantity.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelQuantity.ForeColor = Color.IndianRed;
            labelQuantity.Location = new Point(285, 483);
            labelQuantity.Name = "labelQuantity";
            labelQuantity.Size = new Size(12, 17);
            labelQuantity.TabIndex = 32;
            labelQuantity.Text = " ";
            // 
            // labelMoney
            // 
            labelMoney.AutoSize = true;
            labelMoney.Enabled = false;
            labelMoney.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            labelMoney.ForeColor = Color.IndianRed;
            labelMoney.Location = new Point(407, 483);
            labelMoney.Name = "labelMoney";
            labelMoney.Size = new Size(12, 17);
            labelMoney.TabIndex = 34;
            labelMoney.Text = " ";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label10.ForeColor = Color.IndianRed;
            label10.Location = new Point(319, 483);
            label10.Name = "label10";
            label10.Size = new Size(84, 17);
            label10.TabIndex = 33;
            label10.Text = "Total Money: ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            label8.ForeColor = Color.IndianRed;
            label8.Location = new Point(510, 483);
            label8.Name = "label8";
            label8.Size = new Size(35, 17);
            label8.TabIndex = 35;
            label8.Text = "VND";
            // 
            // createOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 207);
            ClientSize = new Size(610, 567);
            Controls.Add(label8);
            Controls.Add(labelMoney);
            Controls.Add(label10);
            Controls.Add(labelQuantity);
            Controls.Add(label9);
            Controls.Add(btnAdd);
            Controls.Add(labelAvai);
            Controls.Add(avai);
            Controls.Add(cusName);
            Controls.Add(buyQuan);
            Controls.Add(label7);
            Controls.Add(productList);
            Controls.Add(searchProduct);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(orderDate);
            Controls.Add(exit);
            Controls.Add(btnCheckout);
            Controls.Add(searchCus);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(orderID);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "createOrderForm";
            Load += createOrderForm_Load;
            MouseDown += createOrderForm_MouseDown;
            MouseMove += createOrderForm_MouseMove;
            MouseUp += createOrderForm_MouseUp;
            ((System.ComponentModel.ISupportInitialize)exit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox orderID;
        private Label label1;
        private Label label3;
        private TextBox searchCus;
        private Label label4;
        private Button btnCheckout;
        private Button btnReset;
        private PictureBox exit;
        private DateTimePicker orderDate;
        private Label label5;
        private Label label6;
        private TextBox searchProduct;
        private RichTextBox productList;
        private Label label7;
        private TextBox buyQuan;
        private TextBox cusName;
        private Label avai;
        private Label labelAvai;
        private Button btnAdd;
        private Label label9;
        private Label labelQuantity;
        private Label labelMoney;
        private Label label10;
        private Label label8;
    }
}