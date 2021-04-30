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
    public partial class prescription : Form
    {
        Bitmap bmp;
        login l;
        public prescription(login l2,patient p,string name,string date,string list)
        {
       
            InitializeComponent();
            this.l = l2;
            label4.Text = date;
            label11.Text = p.Name;
            label12.Text = p.Age.ToString();
            label8.Text = list;
            label10.Text = name;
            


        }

        private void prescription_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics m = Graphics.FromImage(bmp);
            m.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, new Size(815,737));
            MessageBox.Show("PRESCRIPTION PRINTING...");
            printPreviewDialog1.ShowDialog();
            
                doctorui dui = new doctorui(l);
                dui.Visible = true;
                this.Close();
            
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
