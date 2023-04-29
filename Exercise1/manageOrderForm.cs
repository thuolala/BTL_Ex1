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
    public partial class manageOrderForm : Form
    {
        public manageOrderForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        //Load all orders 
        public void loadAll()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrder.DataSource = dt;
            }
            conn.Close();
        }

        //Get data for search box by Order ID 
        private List<String> getOrderIDSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT OrderID FROM Orders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> orderIDSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                orderIDSource.Add(dt.Rows[i]["OrderID"].ToString());
            }
            conn.Close();
            return orderIDSource;
        }

        //Search by Order ID 
        private void searchOrderID()
        {
            //Search by Order ID
            AutoCompleteStringCollection orderIDSource = new AutoCompleteStringCollection();
            orderIDSource.AddRange(getOrderIDSource().ToArray());

            searchByOrderID.AutoCompleteCustomSource = orderIDSource;
            searchByOrderID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByOrderID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Get data for search box by Date
        private List<String> getDateSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT OrderDate FROM Orders", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> orderDateSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                orderDateSource.Add(dt.Rows[i]["OrderDate"].ToString());
            }
            conn.Close();
            return orderDateSource;
        }

        //Search by Date
        private void searchDate()
        {
            //Search by Order Date
            AutoCompleteStringCollection orderDateSource = new AutoCompleteStringCollection();
            orderDateSource.AddRange(getDateSource().ToArray());

            searchByDate.AutoCompleteCustomSource = orderDateSource;
            searchByDate.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByDate.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Get data for search box by Customer ID
        private List<String> getCusIDSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT DISTINCT AgentID FROM Agent", conn);
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

            searchByCusID.AutoCompleteCustomSource = cusIDSource;
            searchByCusID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByCusID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void manageOrderForm_Load(object sender, EventArgs e)
        {
            loadAll();
            searchOrderID();
            searchDate();
            searchCusID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            createOrderForm f = new createOrderForm();
            f.ShowDialog();
        }

        private void searchByCusID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE AgentID LIKE '%" + searchByCusID.Text + "%'", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrder.DataSource = dt;
            }
            conn.Close();
        }

        private void searchByDate_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderDate LIKE '%" + searchByDate.Text + "%'", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrder.DataSource = dt;
            }
            conn.Close();
        }

        private void searchByOrderID_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Orders WHERE OrderID LIKE '%" + searchByOrderID.Text + "%'", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewOrder.DataSource = dt;
            }
            conn.Close();
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
            searchOrderID();
            searchDate();
            searchCusID();
        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
