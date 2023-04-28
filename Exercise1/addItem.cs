using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class addItem : Form
    {
        public addItem()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Get auto ID 
        private string getID()
        {
            string itemID = "";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Return_ItemID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                itemID = dt.Rows[0][0].ToString();
            }
            conn.Close();
            return itemID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            string cateID = comboBoxCate.SelectedValue.ToString();
            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("Insert_Item", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar)).Value = itemName.Text;
            cmd.Parameters.Add(new SqlParameter("@Price", SqlDbType.Int)).Value = Int32.Parse(itemPrice.Text);
            cmd.Parameters.Add(new SqlParameter("@Available", SqlDbType.Int)).Value = Int32.Parse(itemAvai.Text);
            cmd.Parameters.Add(new SqlParameter("@Description", SqlDbType.NVarChar)).Value = itemDesc.Text;
            cmd.Parameters.Add(new SqlParameter("@CateID", SqlDbType.VarChar)).Value = cateID;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            MessageBox.Show("Add item successully!");
            this.Close();
        }

        //Load categories
        private void loadCategories()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category WHERE CateID NOT LIKE 'ALL'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                comboBoxCate.DataSource = dt;
                comboBoxCate.DisplayMember = dt.Columns["CateName"].ToString();
                comboBoxCate.ValueMember = dt.Columns["CateID"].ToString();
            }
            conn.Close();
        }

        private void addItem_Load(object sender, EventArgs e)
        {
            itemID.Text = getID();
            loadCategories();
        }

        //move 
        private bool mouse;
        private Point lastPos;

        private void addItem_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void addItem_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void addItem_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            itemName.Text = "";
            itemPrice.Text = "";
            itemAvai.Text = "";
            itemDesc.Text = "";
        }
    }
}
