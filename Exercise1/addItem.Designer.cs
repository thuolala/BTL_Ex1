namespace Exercise1
{
    partial class addItem
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
            itemID = new TextBox();
            label1 = new Label();
            itemName = new TextBox();
            label3 = new Label();
            itemPrice = new TextBox();
            label4 = new Label();
            itemAvai = new TextBox();
            label5 = new Label();
            itemDesc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            comboBoxCate = new ComboBox();
            btnSave = new Button();
            btnReset = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(161, 21);
            label2.Name = "label2";
            label2.Size = new Size(178, 32);
            label2.TabIndex = 3;
            label2.Text = "Add New Item";
            // 
            // itemID
            // 
            itemID.BorderStyle = BorderStyle.None;
            itemID.Enabled = false;
            itemID.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemID.ForeColor = SystemColors.ControlDarkDark;
            itemID.Location = new Point(161, 79);
            itemID.Name = "itemID";
            itemID.Size = new Size(142, 22);
            itemID.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(46, 80);
            label1.Name = "label1";
            label1.Size = new Size(66, 21);
            label1.TabIndex = 4;
            label1.Text = "Item ID";
            // 
            // itemName
            // 
            itemName.BorderStyle = BorderStyle.None;
            itemName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemName.ForeColor = SystemColors.ControlDarkDark;
            itemName.Location = new Point(161, 136);
            itemName.Name = "itemName";
            itemName.Size = new Size(278, 22);
            itemName.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(46, 136);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 6;
            label3.Text = "Item Name";
            // 
            // itemPrice
            // 
            itemPrice.BorderStyle = BorderStyle.None;
            itemPrice.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemPrice.ForeColor = SystemColors.ControlDarkDark;
            itemPrice.Location = new Point(161, 198);
            itemPrice.Name = "itemPrice";
            itemPrice.Size = new Size(278, 22);
            itemPrice.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(46, 198);
            label4.Name = "label4";
            label4.Size = new Size(48, 21);
            label4.TabIndex = 8;
            label4.Text = "Price";
            // 
            // itemAvai
            // 
            itemAvai.BorderStyle = BorderStyle.None;
            itemAvai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemAvai.ForeColor = SystemColors.ControlDarkDark;
            itemAvai.Location = new Point(161, 253);
            itemAvai.Name = "itemAvai";
            itemAvai.Size = new Size(142, 22);
            itemAvai.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlDarkDark;
            label5.Location = new Point(46, 253);
            label5.Name = "label5";
            label5.Size = new Size(82, 21);
            label5.TabIndex = 10;
            label5.Text = "Available";
            // 
            // itemDesc
            // 
            itemDesc.BorderStyle = BorderStyle.None;
            itemDesc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            itemDesc.ForeColor = SystemColors.ControlDarkDark;
            itemDesc.Location = new Point(161, 307);
            itemDesc.Name = "itemDesc";
            itemDesc.Size = new Size(278, 22);
            itemDesc.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(46, 307);
            label6.Name = "label6";
            label6.Size = new Size(98, 21);
            label6.TabIndex = 12;
            label6.Text = "Description";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(46, 358);
            label7.Name = "label7";
            label7.Size = new Size(91, 21);
            label7.TabIndex = 15;
            label7.Text = "Categories";
            // 
            // comboBoxCate
            // 
            comboBoxCate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxCate.FormattingEnabled = true;
            comboBoxCate.Location = new Point(158, 355);
            comboBoxCate.Name = "comboBoxCate";
            comboBoxCate.Size = new Size(281, 29);
            comboBoxCate.TabIndex = 14;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlDarkDark;
            btnSave.Location = new Point(284, 415);
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
            btnReset.Location = new Point(123, 415);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(155, 34);
            btnReset.TabIndex = 17;
            btnReset.Text = "Cancel";
            btnReset.UseVisualStyleBackColor = true;
            // 
            // addItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 225, 207);
            ClientSize = new Size(500, 500);
            Controls.Add(btnReset);
            Controls.Add(btnSave);
            Controls.Add(label7);
            Controls.Add(comboBoxCate);
            Controls.Add(itemDesc);
            Controls.Add(label6);
            Controls.Add(itemAvai);
            Controls.Add(label5);
            Controls.Add(itemPrice);
            Controls.Add(label4);
            Controls.Add(itemName);
            Controls.Add(label3);
            Controls.Add(itemID);
            Controls.Add(label1);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "addItem";
            Text = "addItem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox itemID;
        private Label label1;
        private TextBox itemName;
        private Label label3;
        private TextBox itemPrice;
        private Label label4;
        private TextBox itemAvai;
        private Label label5;
        private TextBox itemDesc;
        private Label label6;
        private Label label7;
        private ComboBox comboBoxCate;
        private Button btnSave;
        private Button btnReset;
    }
}