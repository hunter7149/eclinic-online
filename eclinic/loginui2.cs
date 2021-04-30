using System;
using Entity;
using Repository;
using Interfaces;
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
    public partial class loginui2 : Form
    {
        login l = null;
        public loginui2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            loginui l = new loginui();
            l.Visible = true;
        }

        

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = false;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginRepo lr = new LoginRepo();
            string id = textBox1.Text;
            string password = textBox2.Text;

            if (id != null && id != "" && password != null && password != "")
            {
                l = lr.GetUser(id, password);

                if (l != null)
                {
                    if (l.Role == 1)
                    {
                        doctorui hp = new doctorui(this.l);
                        this.Visible = false;
                        hp.Visible = true;
                    }
                    else if (l.Role == 2)
                    {
                        cashier c = new cashier(this.l);
                        this.Close();
                        c.Visible = true;
                    }
                    else if (l.Role == 0)
                    {
                        adminui ad = new adminui(l);
                        ad.Visible = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("USER NOT FOUND!");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid User");
                }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER YOUR CREDENTIALS!!");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }
    }
}
