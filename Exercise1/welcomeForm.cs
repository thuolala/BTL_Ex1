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
    public partial class welcomeForm : Form
    {
        public welcomeForm()
        {
            InitializeComponent();
        }

        //move 
        private bool mouse;
        private Point lastPos;

        private void welcomeForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void welcomeForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            lastPos = e.Location;
        }

        private void welcomeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse)
            {
                this.Location = new Point((this.Location.X - lastPos.X) + e.X, (this.Location.Y - lastPos.Y) + e.Y);
                this.Update();
            }
        }

        private void welcomeForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panelB.Width += 50;
            if (panelB.Width >= 640)
            {
                timer1.Stop();
                this.Hide();
                loginForm f = new loginForm();
                f.Show();
            }
        }
    }
}
