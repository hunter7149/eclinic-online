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
    public partial class updateui : Form
    {
        login l;
        Doctor s = new Doctor();
        DoctorRepo dr = new DoctorRepo();
        public updateui(login p)
        {
            this.l = p;
         
            s=dr.getInfo(p);
            
            InitializeComponent();
            label4.Text = s.Name;
            label5.Text = s.Phone;
            label6.Text = s.Adress;
        }

        private void updateui_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            doctorui dui = new doctorui(l);
            this.Close();
            dui.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            button1.Enabled = false;
            textBox1.Text = s.Name;
            textBox2.Text = s.Phone;
            textBox3.Text = s.Adress;
        }

    



        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
             button2.Visible = true;
             button2.PerformClick();
             
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text.Count() == 11 && textBox3.Text != null && textBox3.Text != "")
            {
                s.Name = textBox1.Text;
                s.Phone = textBox2.Text;
                s.Adress = textBox3.Text;
                bool b=dr.updateDoctor(s);
                if(b == true)
                {
                    panel3.Visible=true;
                    panel1.Visible=false;
                    button1.Enabled = true;
                    button3.Visible = false;
                    s = dr.getInfo(l);
                    label4.Text = s.Name;
                    label5.Text = s.Phone;
                    label6.Text = s.Adress;
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            doctorui dui = new doctorui(l);
            this.Close();
            dui.Visible = true;

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            doctorui dui = new doctorui(l);
            this.Close();
            dui.Visible = true;

        }
    }
}
