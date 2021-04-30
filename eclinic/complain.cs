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
using Repository;
using Interfaces;

namespace eclinic
{
    public partial class complain : Form
    {
        DoctorRepo dr = new DoctorRepo();
        public complain()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginui lui = new loginui();
            lui.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "" && textBox1.Text.Count()>=3)
            {
                string s = textBox1.Text;
                 string d = DateTime.Now.Date.ToString("dd-MM-yyyy");

                 if (dr.insertComplain(s, d) == true)
                 {
                     MessageBox.Show("THANK YOU. \n AUTHORITY WILL TAKE FURTHER STEP.");
                     loginui lui = new loginui();
                     lui.Visible = true;
                     this.Close();

                 }
                 else
                 {
                     MessageBox.Show("ERROR!");
                 }


            }
            else
            {
                MessageBox.Show("PLEASE WRITE YOUR COMPLAIN CORRECTLY!");
            }
        }
    }
}
