using Entity;
using Interfaces;
using Repository;
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
    public partial class cashier : Form
    {
        login l = null;
        PatientRepo pr = new PatientRepo();
        patient p = new patient();
        public cashier(login p)
        {
            this.l = p;
            InitializeComponent();
            if (l.Role == 0)
            {
                
                button5.Visible = true;
                
            }
        }

       
        private void cashier_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                if(panel3.Visible == false)
                {
                    panel3.Visible = true;
                }
                
                int j = Int32.Parse(textBox1.Text);
                int fe = pr.getfee(j);
                p = pr.getpatient(j);
                label4.Text = "NAME: " + p.Name;
                label5.Text = "PHONE: " + p.Phone;
                label6.Text = "CATAGORY: \n" + p.Cat;
                label7.Text = "DATE: " + p.Date;
                label8.Text = "DOCTOR ID: " + p.Did;
                label9.Text = "FEE: "+fe.ToString();
                if (p.Status == 0)
                {
                    label10.Text = "NOT PAID";
                }
                else
                {
                    label10.ForeColor = System.Drawing.Color.Lime;
                    label10.Text = "PAID";
                    button2.Enabled = false;
                    textBox1.Text = null;
                }



            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            p.Status = 1;
            
            
            if (pr.updateStatus(p) == true)
            {
                MessageBox.Show("PAYMENT RECIEVED!");
                textBox1.Text = null;
                button2.Enabled = false;
                label10.Text = "PAID";
                label10.ForeColor = System.Drawing.Color.Lime;

            }
            else
            {
                MessageBox.Show("ERROR!");
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
            textBox1.Text = null;
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            loginui l = new loginui();
            this.Close();
            l.Visible = true;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
            else if (e.KeyCode == Keys.RShiftKey)
            {
                button2.PerformClick();
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
           

            adminui ad = new adminui(l);
            ad.Visible = true;
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            password pw = new password(l);
            pw.Visible = true;
            this.Close();
            
        }

       

      

        
    
    }
}
