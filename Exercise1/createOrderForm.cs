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
    public partial class createOrderForm : Form
    {
        public createOrderForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        //move 
        private bool mouse;
        private Point lastPos;

        private void createOrderForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void createOrderForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void createOrderForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<String> itemNameList = new List<String>();
            List<int> buyQuant = new List<int>();

            itemNameList.Add(searchProduct.Text);
            buyQuant.Add(Int32.Parse(buyQuan.Text));

            productList.AppendText(Environment.NewLine + searchProduct.Text + "    x    " + buyQuan.Text);

        }

        //Get auto ID 
        private string getID()
        {
            string orderID = "";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Return_OrderID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                orderID = dt.Rows[0][0].ToString();
            }
            conn.Close();
            return orderID;
        }



        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void createOrderForm_Load(object sender, EventArgs e)
        {
            orderID.Text = getID();
            searchCusID();
            searchItemName();
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

            searchProduct.AutoCompleteCustomSource = itemNameSource;
            searchProduct.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchProduct.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Get data for search box by CusID 
        private List<String> getCusIDSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentID FROM Agent", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> nameSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameSource.Add(dt.Rows[i]["AgentID"].ToString());
            }
            conn.Close();
            return nameSource;
        }

        //Search by CusID 
        private void searchCusID()
        {
            //Search by item name
            AutoCompleteStringCollection cusIDSource = new AutoCompleteStringCollection();
            cusIDSource.AddRange(getItemNameSource().ToArray());

            searchCus.AutoCompleteCustomSource = cusIDSource;
            searchCus.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchCus.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Get Cus Name 
        private string getCusName(string cusID)
        {
            string cusName = "";

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentName FROM Agent WHERE AgentID LIKE '" + cusID + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cusName = dt.Rows[0][0].ToString();
            }
            conn.Close();

            return cusName;
        }     
    }
}
