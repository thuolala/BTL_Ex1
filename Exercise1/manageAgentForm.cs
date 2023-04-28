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
    public partial class manageAgentForm : Form
    {
        public manageAgentForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        //Get all cus 
        public void loadAll()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Agent", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                dataGridViewCustomer.DataSource = dt;
            }
            conn.Close();
        }

        //Get data for search box by Name 
        private List<String> getNameSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentName FROM Agent", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> nameSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                nameSource.Add(dt.Rows[i]["AgentName"].ToString());
            }
            conn.Close();
            return nameSource;
        }

        //Get data for search box by ID
        private List<String> getIDSource()
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT AgentID FROM Agent", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            List<String> IDSource = new List<String>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                IDSource.Add(dt.Rows[i]["AgentID"].ToString());
            }
            conn.Close();
            return IDSource;
        }

        //Search by Name 
        private void searchName()
        {
            //Search by name
            AutoCompleteStringCollection nameSource = new AutoCompleteStringCollection();
            nameSource.AddRange(getNameSource().ToArray());

            searchByName.AutoCompleteCustomSource = nameSource;
            searchByName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Search by ID 
        private void searchID()
        {
            //Search by ID
            AutoCompleteStringCollection IDSource = new AutoCompleteStringCollection();
            IDSource.AddRange(getIDSource().ToArray());

            searchByID.AutoCompleteCustomSource = IDSource;
            searchByID.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByID.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void manageAgentForm_Load(object sender, EventArgs e)
        {
            loadAll();
            searchName();
            searchID(); 
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
            searchName();
            searchID();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            addAgentForm f = new addAgentForm();
            f.ShowDialog();
        }
    }
}
