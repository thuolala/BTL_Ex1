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
    public partial class manageItemForm : Form
    {
        public manageItemForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        //Load all item 
        private void loadAll()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Item", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewProduct.DataSource = dt;
            }
            conn.Close();
        }

        //Load categories
        private void loadCategories()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Category", conn);
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

        //Load each by category 
        private void loadByCate(string cateID)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Item Where CateID LIKE '" + cateID + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewProduct.DataSource = dt;
            }
            conn.Close();
        }

        private void manageItemForm_Load(object sender, EventArgs e)
        {
            dataGridViewProduct.Width = panelList.Width;
            dataGridViewProduct.Height = panelList.Height;

            loadCategories();
            loadAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            String cateID = comboBoxCate.SelectedValue.ToString();

            if (cateID.Equals("ALL"))
            {
                loadAll();
            }
            else
            {
                loadByCate(cateID);
            }
        }
    }
}
