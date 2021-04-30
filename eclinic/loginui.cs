using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eclinic
{
    public partial class loginui : Form
    {

        public loginui()
        {
            InitializeComponent();

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            userinfo u = new userinfo();
            u.Visible=true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void doctorbutt_Click(object sender, EventArgs e)
        {
            loginui2 dui = new loginui2();
            this.Visible = false;
            dui.Visible = true;
        }

        private void adminbutt_Click(object sender, EventArgs e)
        {
            complain cui = new complain();
            this.Visible = false;
            cui.Visible = true;
        }

        private void loginui_Load(object sender, EventArgs e)
        {

        }
    }
}
