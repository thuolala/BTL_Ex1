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

        //List of product
        List<String> itemNameList = new List<String>();
        List<int> buyQuant = new List<int>();
        List<int> unitAmountList = new List<int>();
        int unitMoney = 0;
        int totalMoney = 0;

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

        //Get Unit Amount 
        private int getPriceOf(string itemName)
        {
            int price = 0;

            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Price FROM Item WHERE ItemName LIKE '" + itemName + "'", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                price = Int32.Parse(dt.Rows[0][0].ToString());
            }
            conn.Close();

            return price;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            itemNameList.Add(searchProduct.Text);
            buyQuant.Add(Int32.Parse(buyQuan.Text));
            int count = itemNameList.Count;

            for (int i = 0; i < itemNameList.Count; i++)
            {
                unitMoney = getPriceOf(itemNameList[i]) * buyQuant[i];
            }

            unitAmountList.Add(unitMoney);
            productList.AppendText(count.ToString() + ". " + searchProduct.Text + "    x    " + buyQuan.Text + ": " + unitMoney.ToString() + Environment.NewLine);

            labelQuantity.Text = itemNameList.Count.ToString();
            totalMoney += unitMoney;
            labelMoney.Text = totalMoney.ToString();


            searchProduct.Text = "";
            labelAvai.Text = "";
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
            cusIDSource.AddRange(getCusIDSource().ToArray());

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

        private void searchCus_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentName FROM Agent WHERE AgentID LIKE '%" + searchCus.Text + "%'", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                cusName.Text = dt.Rows[0][0].ToString();
            }
            conn.Close();
        }

        private void searchProduct_TextChanged(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT Available FROM Item WHERE ItemName LIKE '%" + searchProduct.Text + "%'", conn); ;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                labelAvai.Text = dt.Rows[0][0].ToString();
            }
            conn.Close();
        }

        //Print order
        private void printOrder()
        {

        }

        //Create order to database 
        private void createOrder()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("Insert_Order", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@OrderDate", SqlDbType.DateTime)).Value = orderDate.Value;
            cmd.Parameters.Add(new SqlParameter("@AgentID", SqlDbType.VarChar)).Value = searchCus.Text;
            cmd.Parameters.Add(new SqlParameter("@Total", SqlDbType.Int)).Value = totalMoney;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            this.Close();
        }

        //Get Item ID By Name
        private string getItemID(string name)
        {
            string itemID = "";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT ItemID FROM Item WHERE ItemName LIKE '%" + name + "%'", conn); ;
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

        //Create order detail with order ID above 
        private void addToDetail()
        {
            for(int i = 0; i < itemNameList.Count; i++)
            {
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();

                //Nhap vao bang Item
                SqlCommand cmd = new SqlCommand("Insert_OrderDetail", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@OrderID", SqlDbType.VarChar)).Value = orderID.Text;
                cmd.Parameters.Add(new SqlParameter("@ItemID", SqlDbType.VarChar)).Value = getItemID(itemNameList[i]);
                cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int)).Value = buyQuant[i];
                cmd.Parameters.Add(new SqlParameter("@UnitAmount", SqlDbType.Int)).Value = unitAmountList[i];

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                da.Dispose();

                //Update vao bang Item
                cmd = new SqlCommand("Update_Avai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ItemName", SqlDbType.VarChar)).Value = searchProduct.Text;
                cmd.Parameters.Add(new SqlParameter("@Quantity", SqlDbType.Int)).Value = buyQuant[i];

                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);
                da.Dispose();
                this.Close();
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to print order?", "Order Successfully", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                createOrder();
                addToDetail();
                this.Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                createOrder();
                addToDetail();
                this.Close();
            }
        }
    }
}
