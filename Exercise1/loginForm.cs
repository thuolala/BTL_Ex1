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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        //Read connection from App.config
        String strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Account", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Username"].Equals(username.Text) && dt.Rows[0]["Password"].Equals(password.Text))
                {
                    this.Hide();
                    mainForm f = new mainForm();
                    f.Show();
                }
                else
                {
                    error.Text = "";
                    error.Text = "Username or password is incorrect!";
                }
            }
            conn.Close();
        }

        private void btnLogin_Enter(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Account", conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["Username"].Equals(username.Text) && dt.Rows[0]["Password"].Equals(password.Text))
                {
                    this.Hide();
                    mainForm f = new mainForm();
                    f.Show();
                }
                else
                {
                    error.Text = "";
                    error.Text = "Username or password is incorrect!";
                }
            }
            conn.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //move 
        private bool mouse;
        private Point lastPos;

        private void loginF_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void loginF_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void loginF_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }
    }
}
