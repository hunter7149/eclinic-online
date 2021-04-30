using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity;
using Interfaces;
using Repository;

namespace eclinic
{
    public partial class password : Form
    {
        login l=new login();
        LoginRepo lr;
        public password(login p)
        {
            this.l = p;
            InitializeComponent();
            textBox1.Text = p.Pass;

            
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.textBox1.UseSystemPasswordChar = false;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.textBox1.UseSystemPasswordChar = true;
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = false;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.textBox2.UseSystemPasswordChar = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (l.Role == 0)
            {
                adminui ad = new adminui(l);
                ad.Visible = true;
                this.Close();

            }
            else if (l.Role == 1)
            {

                doctorui dui = new doctorui(l);
                dui.Visible = true;
                this.Close();
            }
            else if (l.Role == 2)
            {
                cashier ch = new cashier(l);
                ch.Visible = true;
                this.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox2.Text != null && textBox2.Text !="")
            {
                lr = new LoginRepo();
                l.Pass = textBox2.Text;
                bool b = lr.updateUser(l);
                if (b == true)
                {
                    MessageBox.Show("YOUR PASSWORD CHANGED SUCCESSFULLY \n YOU WILL BE SIGNED OUT NOW \n PLEASE LOGIN WITH YOUR NEW PASSWORD. ");
                    loginui2 lui = new loginui2();
                    lui.Visible = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("PLEASE TRY AGAIN LATER");
                }
                

            }
        }

       
    }
}
