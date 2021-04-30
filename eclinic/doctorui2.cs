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
    public partial class doctorui2 : Form
    {
        login l2 = new login();
        patient p2;
        PatientRepo pr = new PatientRepo();
        DoctorRepo dr = new DoctorRepo();
        string tdate = DateTime.Now.Date.ToString("dd-MM-yyyy");
        string ndate;
        public doctorui2(patient p,login l,string dt)
        {
            this.l2 = l;
            this.p2 = p;
            InitializeComponent();
            
            this.ndate = dt;

            
            
            if (tdate == ndate)
            {
                name.Text = p.Name;
                age.Text = p.Age.ToString();
                phn.Text = p.Phone;
                bdgroup.Text = p.Bgroup;
                statement.Text = p.Comment;
            }

            else
            {
                name.Text = p.Name;
                age.Text = p.Age.ToString();
                phn.Text = p.Phone;
                bdgroup.Text = p.Bgroup;
                statement.Text = p.Comment;
                button1.Visible = false;
                button2.Text = "BACK";
                

            }
            
            
        }

        private void doctorui2_Load(object sender, EventArgs e)
        {

        }

        private void back_Click(object sender, EventArgs e)
        {
            doctorui dui = new doctorui(l2);
            dui.Visible = true;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tdate == ndate)
            {
                panel3.Visible = true;
                button1.Visible = false;
            }


        }

        private void prescription_TextChanged(object sender, EventArgs e)
        {
            panel4.Visible = true;
            button2.Visible = false;
        }

        private void print_Click(object sender, EventArgs e)
        {
            string s = prescription.Text;
            string id = l2.Id;
  
            string dname = dr.getName(id);
             string o = DateTime.Now.Date.ToString("dd-MM-yyyy");

             bool b = pr.insertprescribed(p2, l2, s);
             bool c = pr.DeletePrescribed(this.p2);
             if (b == true && c == true)
             {
                 prescription ps = new prescription(l2, p2, dname, o, s);

                 ps.Visible = true;
                 this.Close();
             }
             else
             {
                 MessageBox.Show("DATABASE CONNECTION ERROR!");
             }

            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            doctorui dui = new doctorui(l2);
            dui.Visible = true;
            this.Close();
        }
    }
}
