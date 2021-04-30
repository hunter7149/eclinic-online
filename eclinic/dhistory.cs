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
    public partial class dhistory : Form
    {
        login l2;
        PatientRepo pr = new PatientRepo();
        DoctorRepo dr = new DoctorRepo();
        public dhistory(login l)
        {
            InitializeComponent();
            this.l2 = l;
            if (l.Role == 1)
            {

                List<prescribed> lp = pr.getprescribed(l);
                dataGridView1.DataSource = lp;
            }
            else if (l.Role == 0)
            {
                List<Complain> cop = dr.getCmp();
               
                dataGridView1.DataSource = cop;
            }
            

        }

        private void dhistory_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (l2.Role == 1)
            {
                doctorui dui = new doctorui(l2);
                dui.Visible = true;
                this.Close();
            }
            else if (l2.Role == 0)
            {
                adminui aui = new adminui(l2);
                aui.Visible = true;
                this.Close();
                
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
