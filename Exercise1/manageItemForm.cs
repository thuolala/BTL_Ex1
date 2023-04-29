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
        public void loadAll()
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
            searchCusID();
            searchItemName();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addItem f = new addItem();
            f.ShowDialog();
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

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
        }

        private void btnTop3_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("Top3_Item", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewProduct.DataSource = dt;
            }
            da.Dispose();
            conn.Close();
        }

        //Get data for search box by ItemName 
        private List<String> getItemNameSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ItemName FROM Item", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> nameSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameSource.Add(dt.Rows[i]["ItemName"].ToString());
            }
            conn.Close();
            return nameSource;
        }

        //Search by Name 
        private void searchItemName()
        {
            //Search by item name
            AutoCompleteStringCollection itemNameSource = new AutoCompleteStringCollection();
            itemNameSource.AddRange(getItemNameSource().ToArray());

            searchByItemName.AutoCompleteCustomSource = itemNameSource;
            searchByItemName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByItemName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void searchByItemName_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("GetAgent_ByItem", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.NVarChar)).Value = searchByItemName.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewProduct.DataSource = dt;
            }
            da.Dispose();
            conn.Close();
        }

        //Get data for search box by Customer ID
        private List<String> getCusIDSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentID FROM Agent", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> cusIDSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cusIDSource.Add(dt.Rows[i]["AgentID"].ToString());
            }
            conn.Close();
            return cusIDSource;
        }

        //Search by Customer ID 
        private void searchCusID()
        {
            //Search by Order Date
            AutoCompleteStringCollection cusIDSource = new AutoCompleteStringCollection();
            cusIDSource.AddRange(getCusIDSource().ToArray());

            searchByCustomerID.AutoCompleteCustomSource = cusIDSource;
            searchByCustomerID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByCustomerID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void searchByCustomerID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("GetItem_ByAgent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AgentID", SqlDbType.VarChar)).Value = searchByCustomerID.Text.Trim();

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewProduct.DataSource = dt;
            }
            da.Dispose();
            conn.Close();
        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
