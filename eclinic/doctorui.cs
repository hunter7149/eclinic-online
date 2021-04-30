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
    public partial class doctorui : Form

    {
        login l = null;
        PatientRepo pr = new PatientRepo();
         string o = DateTime.Now.Date.ToString("dd-MM-yyyy");
         string o2 = DateTime.Now.Date.AddDays(1).ToString("dd-MM-yyyy");
         string o3;
         
         string a;
         string b;
        

        public doctorui(login p)
        {
            l = p;
            
            InitializeComponent();
            string s = l.Id;
            List<patient> dr = pr.GetAllPatient(l.Id,o,1);
           

            List<patient> pr2 = pr.GetAllPatient(l.Id, o2,1);
            nextp.DataSource = pr2;

     
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            TIME.Text = DateTime.Now.ToString("hh:mm:ss tt");
         
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            loginui l = new loginui();
            this.Close();
            l.Visible = true;
        }

      

        

        private void doctorui_Load(object sender, EventArgs e)
        {

        }

        private void nextp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            nextp.CurrentCell.Selected = true;
            b = nextp.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           o3=dateTimePicker1.Value.ToString("dd-MM-yyyy");
            List<patient> pr2 = pr.GetAllPatient(l.Id, o3,1);
            nextp.DataSource = pr2;
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (b != null && b != "")
            {
                patient k = new patient();
                k = pr.getselected(b);
                doctorui2 dui = new doctorui2(k, l, o3);
                dui.Visible = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("PLEASE SELECT A PATIENT!");
                List<patient> pr2 = pr.GetAllPatient(l.Id, o2, 1);
                nextp.DataSource = pr2;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dhistory dh = new dhistory(l);
            dh.Visible = true;
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            updateui uui = new updateui(l);
            uui.Visible = true;
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            password pw = new password(l);
            pw.Visible = true;
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      
     
    }
}
