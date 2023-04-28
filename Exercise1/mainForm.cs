using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercise1
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void pictureBoxMenu_Click(object sender, EventArgs e)
        {
            timerMenu.Start();
        }

        bool sidebarExpand;
        private void timerMenu_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 20;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerMenu.Stop();
                }
            }
            else
            {
                sidebar.Width += +20;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerMenu.Stop();
                }
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            panelAction.Controls.Clear();
            manageItemForm mI = new manageItemForm();
            mI.TopLevel = false;
            mI.Dock = DockStyle.Fill;
            mI.Show();
            panelAction.Controls.Add(mI);
            mI.BringToFront();
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            panelAction.Controls.Clear();
            manageAgentForm mI = new manageAgentForm();
            mI.TopLevel = false;
            mI.Dock = DockStyle.Fill;
            mI.Show();
            panelAction.Controls.Add(mI);
            mI.BringToFront();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
