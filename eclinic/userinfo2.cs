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

namespace eclinic
{
    public partial class userinfo2 : Form
    {
        internal patient p;
        int align;
        PatientRepo pr = new PatientRepo();
        DoctorRepo dr = new DoctorRepo();
        public userinfo2(patient p)
        {
            this.p = p;
            InitializeComponent();

        }

        private void emed_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "MEDICINE";
            allergy.Visible = false;
            dermat.Visible = false;
            radiology.Visible = false;
            help.Visible = false;
            cancer.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            info4.Visible = true;
            info5.Visible = true;
            info6.Visible = true;
            INFO.Visible = true;
            info1.Text = "Name: " + p.Name;
            info2.Text = "Phone: " + p.Phone;
            info3.Text = "Age: " + p.Age.ToString();
            info4.Text = "Blood Group: " + p.Bgroup;
            info5.Text = "Category: \n" + p.Cat;
            align = 0;

        }

        private void next_Click(object sender, EventArgs e)
        {






            if (dateTimePicker1.Value >= DateTime.Now.Date)
            {
                button2.Visible = false;
                panel5.Visible = true;
                p.Date = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                p.Comment = textBox1.Text;
                if (info6.Visible == true)
                {
                    info6.Text = "Appointment Date :\n" + p.Date;
                }
                else
                {
                    label5.Text = "Appointment Date :\n" + p.Date;
                }
                List<Doctor> dr = pr.GetAllDoctor(p.Cat);
                doctorlist1.DataSource = dr;
                doctorlist1.Columns[2].Visible = false;
                doctorlist1.Columns[3].Visible = false;
                doctorlist1.Columns[4].Visible = false;
                doctorlist1.Columns[6].Visible = false;
            }
            else
            {

                MessageBox.Show("Enter only upcoming date please! \n You can't go to past!");
                p.Date = "";
                if (info6.Visible == true)
                {
                    info6.Text = "Appointment Date :\n" + p.Date;
                }
                else
                {
                    label5.Text = "Appointment Date :\n" + p.Date;
                }

            }







        }

        private void allergy_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "ALLERGY";
            emed.Visible = false;
            dermat.Visible = false;
            radiology.Visible = false;
            help.Visible = false;
            cancer.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            info4.Visible = true;
            info5.Visible = true;
            info6.Visible = true;
            INFO.Visible = true;
            info1.Text = "Name: " + p.Name;
            info2.Text = "Phone: " + p.Phone;
            info3.Text = "Age: " + p.Age.ToString();
            info4.Text = "Blood Group: " + p.Bgroup;
            info5.Text = "Category: \n" + p.Cat;
            align = 0;

        }

        private void dermat_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "DERMATOLOGY";
            allergy.Visible = false;
            emed.Visible = false;
            radiology.Visible = false;
            help.Visible = false;
            cancer.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            info4.Visible = true;
            info5.Visible = true;
            info6.Visible = true;
            INFO.Visible = true;
            info1.Text = "Name: " + p.Name;
            info2.Text = "Phone: " + p.Phone;
            info3.Text = "Age: " + p.Age.ToString();
            info4.Text = "Blood Group: " + p.Bgroup;
            info5.Text = "Category: \n" + p.Cat;
            align = 0;

        }

        private void radiology_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "RADIOLOGY";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            cancer.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            info4.Visible = true;
            info5.Visible = true;
            info6.Visible = true;
            INFO.Visible = true;
            info1.Text = "Name: " + p.Name;
            info2.Text = "Phone: " + p.Phone;
            info3.Text = "Age: " + p.Age.ToString();
            info4.Text = "Blood Group: " + p.Bgroup;
            info5.Text = "Category: \n" + p.Cat;
            align = 0;

        }

        private void help_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "COMMON";
            allergy.Visible = false;
            dermat.Visible = false;
            radiology.Visible = false;
            emed.Visible = false;
            cancer.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            info1.Visible = true;
            info2.Visible = true;
            info3.Visible = true;
            info4.Visible = true;
            info5.Visible = true;
            info6.Visible = true;
            INFO.Visible = true;
            info1.Text = "Name: " + p.Name;
            info2.Text = "Phone: " + p.Phone;
            info3.Text = "Age: " + p.Age.ToString();
            info4.Text = "Blood Group: " + p.Bgroup;
            info5.Text = "Category: \n" + p.Cat;
            align = 0;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancer_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "ONCOLOGY";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            emed.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            radiology.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label10.Text = "Name: " + p.Name;
            label9.Text = "Phone: " + p.Phone;
            label8.Text = "Age: " + p.Age.ToString();
            label7.Text = "Blood Group: " + p.Bgroup;
            label6.Text = "Category: \n" + p.Cat;
            align = 1;
        }

        private void surgery_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "SURGERY";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            emed.Visible = false;
            cancer.Visible = false;
            radiology.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label10.Text = "Name: " + p.Name;
            label9.Text = "Phone: " + p.Phone;
            label8.Text = "Age: " + p.Age.ToString();
            label7.Text = "Blood Group: " + p.Bgroup;
            label6.Text = "Category: \n" + p.Cat;
            align = 1;
        }

        private void pediat_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "PEDIATRICS";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            emed.Visible = false;
            surgery.Visible = false;
            radiology.Visible = false;
            cancer.Visible = false;
            gyn.Visible = false;
            neuro.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label10.Text = "Name: " + p.Name;
            label9.Text = "Phone: " + p.Phone;
            label8.Text = "Age: " + p.Age.ToString();
            label7.Text = "Blood Group: " + p.Bgroup;
            label6.Text = "Category: \n" + p.Cat;
            align = 1;
        }

        private void gyn_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "GYNECOLOGY";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            emed.Visible = false;
            radiology.Visible = false;
            surgery.Visible = false;
            pediat.Visible = false;
            cancer.Visible = false;
            neuro.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label10.Text = "Name: " + p.Name;
            label9.Text = "Phone: " + p.Phone;
            label8.Text = "Age: " + p.Age.ToString();
            label7.Text = "Blood Group: " + p.Bgroup;
            label6.Text = "Category: \n" + p.Cat;
            align = 1;
        }

        private void neuro_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
            p.Cat = "NEUROLOGY";
            allergy.Visible = false;
            dermat.Visible = false;
            emed.Visible = false;
            help.Visible = false;
            emed.Visible = false;
            surgery.Visible = false;
            radiology.Visible = false;
            pediat.Visible = false;
            gyn.Visible = false;
            cancer.Visible = false;
            label10.Visible = true;
            label9.Visible = true;
            label8.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            label10.Text = "Name: " + p.Name;
            label9.Text = "Phone: " + p.Phone;
            label8.Text = "Age: " + p.Age.ToString();
            label7.Text = "Blood Group: " + p.Bgroup;
            label6.Text = "Category: \n" + p.Cat;
            align = 1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            loginui l = new loginui();
            l.Visible = true;
        }

        private void INFO_Click(object sender, EventArgs e)
        {

        }

        private void info6_Click(object sender, EventArgs e)
        {

        }

        private void info1_Click(object sender, EventArgs e)
        {

        }

        private void info2_Click(object sender, EventArgs e)
        {

        }

        private void info3_Click(object sender, EventArgs e)
        {

        }

        private void info4_Click(object sender, EventArgs e)
        {

        }

        private void info5_Click(object sender, EventArgs e)
        {

        }

        
        Bitmap bmp;
        private void confirm_Click(object sender, EventArgs e)

        {




            if (align == 0)
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics m = Graphics.FromImage(bmp);
                m.CopyFromScreen(this.Location.X + 218, this.Location.Y + 11, 250, 0, new Size(200, 425));
                if (p.Did != null)
                {
                    p.Status = 0;
                    pr.insertDB(p);
                    int fr = Int32.Parse(label12.Text);
                    int hk = Int32.Parse(label16.Text);
                    pr.insertfee(hk, fr);

                    this.Close();
                    loginui l = new loginui();
                    l.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please select a doctor!");
                }
                MessageBox.Show("PLEASE TAKE THIS DOCUMENT FROM PRINTER  \n AND PLEASE PAY THE FEE IN PAYMENT SECTION!");
                printPreviewDialog1.ShowDialog();


            }
            else
            {
                Graphics g = this.CreateGraphics();
                bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
                Graphics m = Graphics.FromImage(bmp);
                m.CopyFromScreen(this.Location.X + 12, this.Location.Y + 11, 300, 0, new Size(200, 425));
                if (p.Did != null)
                {
                    int fr = Int32.Parse(label13.Text);
                    int jk = Int32.Parse(label15.Text);
                    pr.insertfee(jk, fr);
                    p.Status = 0;
                    pr.insertDB(p);
                    this.Close();
                    loginui l = new loginui();
                    l.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please select a doctor!");
                }
                MessageBox.Show("PLEASE TAKE THIS DOCUMENT FROM PRINTER  \n AND PAY THE FEE IN PAYMENT SECTION!");
                printPreviewDialog1.ShowDialog();


            }





        }

        private void doctorlist1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            doctorlist1.CurrentCell.Selected = true;
            p.Did = doctorlist1.Rows[e.RowIndex].Cells["id"].Value.ToString();
            Random rnd = new Random();
            int txd = rnd.Next(100000, 5000000);
            p.Refer = txd;



            if (align == 0)
            {
                label14.Visible = true;
                label12.Visible = true;
                label16.Visible = true;
                label19.Visible = true;
                label21.Visible = true;
                label14.Text = "Doctor name:\n" + doctorlist1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                label12.Text = doctorlist1.Rows[e.RowIndex].Cells["fee"].Value.ToString();
                label16.Text = txd.ToString();
            }
            else if (align == 1)
            {
                label11.Visible = true;
                label13.Visible = true;
                label15.Visible = true;
                label18.Visible = true;
                label20.Visible = true;


                label11.Text = "Doctor name:\n" + doctorlist1.Rows[e.RowIndex].Cells["name"].Value.ToString();
                label13.Text = doctorlist1.Rows[e.RowIndex].Cells["fee"].Value.ToString();
                label15.Text = txd.ToString();


            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            panel4.Visible = false;
            radiology.Visible = true;
            allergy.Visible = true;
            dermat.Visible = true;
            emed.Visible = true;
            help.Visible = true;
            cancer.Visible = true;
            surgery.Visible = true;
            pediat.Visible = true;
            gyn.Visible = true;
            neuro.Visible = true;
            info1.Visible = false;
            info2.Visible = false;
            info3.Visible = false;
            info4.Visible = false;
            info5.Visible = false;
            info6.Visible = false;

            INFO.Visible = false;
            label10.Visible = false;
            label9.Visible = false;
            label8.Visible = false;
            label7.Visible = false;
            label6.Visible = false;
            label5.Visible = false;
            label4.Visible = false;


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            List<Doctor> listOfDoctor = dr.getAll();
            String keyword = this.textBox2.Text;
            List<Doctor> searchedDoctor = listOfDoctor.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.Fee.ToString().ToLower()).Contains(keyword.ToLower()));
            doctorlist1.DataSource = searchedDoctor;
            doctorlist1.Columns[2].Visible = false;
            doctorlist1.Columns[3].Visible = false;
            doctorlist1.Columns[4].Visible = false;
            doctorlist1.Columns[6].Visible = false;
        }

    }
}
