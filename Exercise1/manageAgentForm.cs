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
            for(int i = 0; i < dt.Rows.Count; i++)
            {
                nameSource.Add(dt.Rows[i]["AgentName"].ToString());
            }
            conn.Close();
            return nameSource;
        }

        private void manageAgentForm_Load(object sender, EventArgs e)
        {
            loadAll();
            AutoCompleteStringCollection nameSource = new AutoCompleteStringCollection();
            nameSource.AddRange(getNameSource().ToArray());

            searchByName.AutoCompleteCustomSource = nameSource;
            searchByName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            searchByName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void pictureBoxRefresh_Click(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
