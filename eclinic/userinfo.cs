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

namespace eclinic
{
    public partial class userinfo : Form
    {
        internal Entity.patient p;
        public userinfo()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginui l = new loginui();
            l.Visible = true;
        }

        private void confrm_Click(object sender, EventArgs e)

        {
            int a = 0;
            if (namebox.Text !="" && phonebox.Text != "" && agebox.Text != null && bloodbox.Text != null )
            { p = new Entity.patient();
            p.Name = namebox.Text.ToString().ToUpper();
            a++;
            if (phonebox.Text.Count() == 11)
            {
                p.Phone = phonebox.Text.ToString().ToUpper();
                a++;
            }
            else
            {
                MessageBox.Show("PLEASE ENTER YOUR 11 DIGIT NUMBER!");
            }
            if (agebox.Text!=null && agebox.Text!="" && Int32.Parse(agebox.Text) > 0)
            {
                p.Age = Int32.Parse(agebox.Text);
                a++;
            }
            else
            {
                MessageBox.Show("ENTER A VALID AGE!");

            }


            if (bloodbox.Text != null && bloodbox.Text != "")
            {
                if (bloodbox.Text.ToUpper() == "O+" || bloodbox.Text.ToUpper() == "O-" || bloodbox.Text.ToUpper() == "A+" || bloodbox.Text.ToUpper() == "A-" || bloodbox.Text.ToUpper() == "B+" || bloodbox.Text.ToUpper() == "B-" || bloodbox.Text.ToUpper() == "AB+" || bloodbox.Text.ToUpper() == "AB-" || bloodbox.Text.ToUpper() == "RH+" || bloodbox.Text.ToUpper() == "RH-")
                {
                    p.Bgroup = bloodbox.Text.ToUpper();
                    a++;
                }
                else
                { MessageBox.Show(bloodbox.Text + " IS NOT A VALID BLOOD GROUP!!"); }
            }
            else
            {
                MessageBox.Show("PLEASE ENTER BLOOD GROUP !");
            }

            if (a == 4)
            {
                userinfo2 u2 = new userinfo2(p);
                this.Visible = false;
                u2.Visible = true;
            }
        
            }


            
        }

        private void namebox_TextChanged(object sender, EventArgs e)
        {
            if (namebox.Text.Count() > 2)
            {
                panel1.Visible = true;
            }
            else
            { panel1.Visible = false; }
        }

        private void phonebox_TextChanged(object sender, EventArgs e)
        {
            if (phonebox.Text.Count() > 10)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void agebox_TextChanged(object sender, EventArgs e)
        {
            if (agebox.Text.Count() >= 1)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void bloodbox_TextChanged(object sender, EventArgs e)

        {
            if (bloodbox.Text.Count() > 1)
            {
                confrm.Visible = true;
            }
            else
            {
                confrm.Visible = false;
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
