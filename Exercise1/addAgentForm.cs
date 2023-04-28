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
using System.Windows.Forms.VisualStyles;

namespace Exercise1
{
    public partial class addAgentForm : Form
    {
        public addAgentForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        private void addAgentForm_Load(object sender, EventArgs e)
        {
            agentID.Text = getID();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Get auto ID 
        private string getID()
        {
            string agentID = "";
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("Return_AgentID", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                agentID = dt.Rows[0][0].ToString();
            }
            conn.Close();
            return agentID;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();

            //Nhap vao bang Item
            SqlCommand cmd = new SqlCommand("Insert_Agent", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@AgentName", SqlDbType.NVarChar)).Value = agentName.Text;
            cmd.Parameters.Add(new SqlParameter("@Address", SqlDbType.Text)).Value = agentAddress.Text;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            da.Dispose();
            MessageBox.Show("Add customer successully!");
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            agentName.Text = "";
            agentAddress.Text = "";
        }
    }
}
