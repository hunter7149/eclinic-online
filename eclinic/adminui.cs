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
    public partial class adminui : Form
    {
        login l;
        int mng = 0;
        DoctorRepo dr = new DoctorRepo();
        EmployeeRepo er = new EmployeeRepo();
        Doctor d = new Doctor();
        Employee emp = new Employee();
        LoginRepo lr = new LoginRepo();
        
        public adminui(login p)
        {
            this.l = p;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            label7.Visible = true;
            textBox7.Visible = true;
            textBox1.ReadOnly = false;
            panel2.Visible = false;
            panel4.Visible = false;
            textBox1.Text = "";
            mng = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            loginui2 lui = new loginui2();
            MessageBox.Show("SIGNED OUT!");
            lui.Visible = true;
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            password p = new password(l);
            p.Visible = true;
            this.Close();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cashier ch = new cashier(l);
            ch.Visible = true;
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            panel2.Visible = true;
            if (mng == 1)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Adress"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Cat"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Sal"].Value.ToString();
                textBox7.Text = dataGridView1.Rows[e.RowIndex].Cells["Fee"].Value.ToString();
                textBox1.ReadOnly = true;
            }
            else if(mng == 2)
            {
                dataGridView1.CurrentCell.Selected = true;
                textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells["Id"].Value.ToString();
                textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells["Name"].Value.ToString();
                textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells["Phone"].Value.ToString();
                textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells["Adress"].Value.ToString();
                textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells["Cat"].Value.ToString();
                textBox6.Text = dataGridView1.Rows[e.RowIndex].Cells["Sal"].Value.ToString();
               
                textBox1.ReadOnly = true;

            }

        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (mng == 1)
            {
                panel4.Visible = true;
                panel2.Visible = false;
                textBox1.Text = "";
                List<Doctor> l = new List<Doctor>();
                l = dr.getAll();
                dataGridView1.DataSource = l;
            }
            else if (mng == 2)
            {
                panel4.Visible = true;
                panel2.Visible = false;
                textBox1.Text = "";
                List<Employee> l = new List<Employee>();
                l = er.getAll();
                dataGridView1.DataSource = l;
 
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "UPDATE")
            {
                if (mng == 1)
                {
                    if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "" && textBox4.Text != null && textBox4.Text != "" && textBox5.Text != null && textBox5.Text != "" && textBox6.Text != null && textBox6.Text != "" && textBox7.Text != null && textBox7.Text != "")
                    {
                        int success = 0;
                        if (textBox1.Text != null && textBox1.Text.Count() > 2)
                        {
                            d.Id = textBox1.Text;
                            success++;
                        }
                        else
                        { MessageBox.Show("INVALID ID!"); }

                        if (textBox2.Text != null && textBox2.Text.Count() > 2)
                        {
                            d.Name = textBox2.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("INVALID NAME!");
                        }

                        if (textBox3.Text != null && textBox3.Text.Count() == 11)
                        {
                            d.Phone = textBox3.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER ONLY 11 DIGIT NUMBER!");
                        }

                        if (textBox4.Text != null && textBox4.Text.Count() > 3)
                        {
                            d.Adress = textBox4.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID ADDRESS");
                        }

                        if (textBox5.Text != null && textBox5.Text.Count() > 3)
                        {
                            d.Cat = textBox5.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID CATAGORY");
                        }
                        long test = Int64.Parse(textBox6.Text);

                        if (textBox6.Text != null && test > 0)
                        {
                            d.Sal = textBox6.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID SALARY");
                        }

                        int fee2 = Int32.Parse(textBox7.Text);
                        if (textBox7.Text != null && fee2 > 0)
                        {
                            d.Fee = fee2;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID FEE!");
                        }

                        if (success == 7)
                        {
                            if (dr.updateDoctor(d) == true)
                            {
                                MessageBox.Show("UPDATED!");
                                List<Doctor> l = new List<Doctor>();
                                l = dr.getAll();
                                dataGridView1.DataSource = l;
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                textBox1.ReadOnly = false;


                            }
                        }
                        else
                        { MessageBox.Show("NOT UPDATED"); }
                    }
                    else
                    { MessageBox.Show("PLEASE DON'T LEAVE ANY INFORMATION BLANK \n TRY AGAIN!!"); }
                }

                else if (mng == 2)
                {

                    if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "" && textBox4.Text != null && textBox4.Text != "" && textBox5.Text != null && textBox5.Text != "" && textBox6.Text != null && textBox6.Text != "")
                    {
                        int success = 0;
                        if (textBox1.Text != null && textBox1.Text.Count() > 2)
                        {
                            emp.Id = textBox1.Text;
                            success++;
                        }
                        else
                        { MessageBox.Show("INVALID ID!"); }

                        if (textBox2.Text != null && textBox2.Text.Count() > 2)
                        {
                            emp.Name = textBox2.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("INVALID NAME!");
                        }

                        if (textBox3.Text != null && textBox3.Text.Count() == 11)
                        {
                            emp.Phone = textBox3.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER ONLY 11 DIGIT NUMBER!");
                        }

                        if (textBox4.Text != null && textBox4.Text.Count() > 3)
                        {
                            emp.Adress = textBox4.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID ADDRESS");
                        }

                        if (textBox5.Text != null && textBox5.Text.Count() > 3)
                        {
                            emp.Cat = textBox5.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID CATAGORY");
                        }
                        long test = Int64.Parse(textBox6.Text);

                        if (textBox6.Text != null && test > 0)
                        {
                            emp.Sal = textBox6.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID SALARY");
                        }

                        if (success == 6)
                        {
                            if (er.updateEmployee(emp) == true)
                            {
                                MessageBox.Show("UPDATED!");
                                List<Employee> l = new List<Employee>();
                                l = er.getAll();
                                dataGridView1.DataSource = l;
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                button9.Text = "DELETE";
                                textBox1.ReadOnly = false;
                                panel2.Visible = false;



                            }

                        }

                        else
                        {
                            MessageBox.Show("NOT UPDATED!");
                        }

                    }
                    else
                    { MessageBox.Show("PLEASE DON'T LEAVE ANY INFORMATION BLANK \n TRY AGAIN!!"); }
 
                }
            }



            else 
            {

                if (mng == 1)
                {
                    if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "" && textBox4.Text != null && textBox4.Text != "" && textBox5.Text != null && textBox5.Text != "" && textBox6.Text != null && textBox6.Text != "" && textBox7.Text != null && textBox7.Text != "")
                    {
                        Random rnd = new Random();
                        int txd = rnd.Next(100000, 5000000);
                        int success = 0;
                        if (textBox1.Text != null && textBox1.Text.Count() > 2)
                        {
                            d.Id = textBox1.Text;
                            success++;
                        }
                        else
                        { MessageBox.Show("INVALID ID!"); }

                        if (textBox2.Text != null && textBox2.Text.Count() > 2)
                        {
                            d.Name = textBox2.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("INVALID NAME!");
                        }

                        if (textBox3.Text != null && textBox3.Text.Count() == 11)
                        {
                            d.Phone = textBox3.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER ONLY 11 DIGIT NUMBER!");
                        }

                        if (textBox4.Text != null && textBox4.Text.Count() > 3)
                        {
                            d.Adress = textBox4.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID ADDRESS");
                        }

                        if (textBox5.Text != null && textBox5.Text.Count() > 3)
                        {
                            d.Cat = textBox5.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID CATAGORY");
                        }
                        long test = Int64.Parse(textBox6.Text);

                        if (textBox6.Text != null && test > 0)
                        {
                            d.Sal = textBox6.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID SALARY");
                        }

                        int fee2 = Int32.Parse(textBox7.Text);
                        if (textBox7.Text != null && fee2 > 0)
                        {
                            d.Fee = fee2;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID FEE!");
                        }



                        string pass = txd.ToString();

                        if (success == 7)
                        {

                            if (dr.insertDoctor(d) == true && lr.insertUser(d.Id, pass, 1) == true)
                            {

                                MessageBox.Show("NEW DOCTOR ADDED! \n USER ID: " + d.Id + "\n PASSWPORD: " + pass);
                                List<Doctor> l = new List<Doctor>();
                                l = dr.getAll();
                                dataGridView1.DataSource = l;
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                panel3.Visible = true;
                                button6.Visible = true;
                                button7.Visible = true;
                                button10.Visible = true;
                                button8.Text = "UPDATE";
                                button9.Text = "DELETE";
                                panel4.Visible = true;



                            }
                        }
                        else
                        {
                            MessageBox.Show("DOCTOR NOT ADDED! \n PLEASE CHECK ALL INFORMATION AGAIN!");
                        }

                    }

                    else
                    {
                        MessageBox.Show("PLEASE INPUT EACH INFORMATION! TRY AGAIN!");
                    }
                }
                else if (mng == 2)
                {
                    if (textBox1.Text != null && textBox1.Text != "" && textBox2.Text != null && textBox2.Text != "" && textBox3.Text != null && textBox3.Text != "" && textBox4.Text != null && textBox4.Text != "" && textBox5.Text != null && textBox5.Text != "" && textBox6.Text != null && textBox6.Text != "")
                    {
                        Random rnd = new Random();
                        int txd = rnd.Next(100000, 5000000);
                        int success = 0;
                        if (textBox1.Text != null && textBox1.Text.Count() > 2)
                        {
                            emp.Id = textBox1.Text;
                            success++;
                        }
                        else
                        { MessageBox.Show("INVALID ID!"); }

                        if (textBox2.Text != null && textBox2.Text.Count() > 2)
                        {
                            emp.Name = textBox2.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("INVALID NAME!");
                        }

                        if (textBox3.Text != null && textBox3.Text.Count() == 11)
                        {
                            emp.Phone = textBox3.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER ONLY 11 DIGIT NUMBER!");
                        }

                        if (textBox4.Text != null && textBox4.Text.Count() > 3)
                        {
                            emp.Adress = textBox4.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID ADDRESS");
                        }

                        if (textBox5.Text != null && textBox5.Text.Count() > 3)
                        {
                            emp.Cat = textBox5.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID CATAGORY");
                        }
                        long test = Int64.Parse(textBox6.Text);

                        if (textBox6.Text != null && test > 0)
                        {
                            emp.Sal = textBox6.Text;
                            success++;
                        }
                        else
                        {
                            MessageBox.Show("PLEASE ENTER VALID SALARY");
                        }


                        if (success == 6)
                        {

                            string pass = txd.ToString();
                            if (emp.Cat.ToUpper() == "CASHIER")
                            {

                                lr.insertUser(emp.Id, pass, 2);

                            }
                            else if (emp.Cat.ToUpper() == "MANAGER")
                            {

                                lr.insertUser(emp.Id, pass, 0);

                            }



                            if (er.insertEmployee(emp) == true)
                            {
                                if (emp.Cat.ToUpper() == "CASHIER" || emp.Cat.ToUpper() == "MANAGER")
                                {
                                    MessageBox.Show("NEW EMPLOYEE ADDED WITH USERNAME: " + emp.Id + " \n PASSWORD: " + pass);
                                }
                                else
                                {

                                    MessageBox.Show("NEW EMPLOYEE ADDED!");
                                }

                                MessageBox.Show("NEW EMPLOYEE ADDED!");
                                List<Employee> l = new List<Employee>();
                                l = er.getAll();
                                dataGridView1.DataSource = l;
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";
                                panel3.Visible = true;
                                button6.Visible = true;
                                button7.Visible = true;
                                button10.Visible = true;
                                button8.Text = "UPDATE";
                                button9.Text = "DELETE";
                                panel4.Visible = true;



                            }
                        }
                        else
                        {
                            MessageBox.Show("EMPLOYEE NOT ADDED! PLEASE ENTER ALL INFORMATION CORRECTLY!");
                        }
                    }
 
                }
            }


        }

        private void button9_Click(object sender, EventArgs e)
        {

            if (button9.Text == "DELETE")
            {
                if (mng == 1)
                {

                    if (lr.deleteUser(textBox1.Text))
                    {
                        if (dr.deleteDoctor(textBox1.Text))
                        {
                            MessageBox.Show("DOCTOR REMOVED!");
                            List<Doctor> lpp = new List<Doctor>();
                            lpp = dr.getAll();
                            dataGridView1.DataSource = lpp;
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";

                        }
                    }
                }
                else if (mng == 2)
                {
                    if (l.Id.Equals(emp.Id))
                    {
                        MessageBox.Show("YOU CAN'T REMOVE YOURSELF!");
                    }
                    else if (textBox5.Text.ToUpper() == "CASHIER" || textBox5.Text.ToUpper() == "MANAGER")
                    {
                        if (lr.deleteUser(textBox1.Text))
                        {
                            if (er.deleteEmployee(textBox1.Text))
                            {

                                MessageBox.Show("EMPLOYEE REMOVED!");
                                List<Employee> lpp= new List<Employee>();
                                lpp= er.getAll();
                                dataGridView1.DataSource = lpp;
                                textBox1.Text = "";
                                textBox2.Text = "";
                                textBox3.Text = "";
                                textBox4.Text = "";
                                textBox5.Text = "";
                                textBox6.Text = "";
                                textBox7.Text = "";

                            }
                        }
                    }
                    else
                    {
                        if (er.deleteEmployee(textBox1.Text))
                        {

                            MessageBox.Show("EMPLOYEE REMOVED!");
                            List<Employee> lpp = new List<Employee>();
                            lpp = er.getAll();
                            dataGridView1.DataSource = lpp;
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";

                        }
                    }
                }
                else
                {
                    MessageBox.Show("ERROR!!");
                }
            }
            else if (button9.Text == "CANCEL")
            {
                

                panel2.Visible = false;
                panel3.Visible = true;
                button6.Visible = true;
                button7.Visible = true;
                button10.Visible = true;
                button8.Text = "UPDATE";
                button9.Text = "DELETE";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }
            else if (button9.Text == "BACK")
            {
                panel1.Visible = false;
                panel2.Visible = false;
                button9.Text = "DELETE";

                
                
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            panel4.Visible = false;

            panel2.Visible = true;
            panel3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button10.Visible = false;
            button8.Text = "ADD";
            button9.Text = "CANCEL";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "")
            {
                if (mng == 1)
                {
                    d = dr.getDoctor(textBox1.Text);
                    if (d.Name != null && d.Name != "")
                    {
                        textBox1.Text = d.Id;
                        textBox2.Text = d.Name;
                        textBox3.Text = d.Phone;
                        textBox4.Text = d.Adress;
                        textBox5.Text = d.Cat;
                        textBox6.Text = d.Sal;
                        textBox7.Text = d.Fee.ToString();
                        panel2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("USER NOT FOUND!!");
                    }
                }
                else if (mng == 2)
                {
                    emp = er.getEmployee(textBox1.Text);
                    if (emp.Name != null && emp.Name != "")
                    {
                        textBox1.Text = emp.Id;
                        textBox2.Text = emp.Name;
                        textBox3.Text = emp.Phone;
                        textBox4.Text = emp.Adress;
                        textBox5.Text = emp.Cat;
                        textBox6.Text = emp.Sal;
                        panel2.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("USER NOT FOUND!!");
                    }
                }

            }
            else
            {
                MessageBox.Show("ENTER A ID FIRST!!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            panel1.Visible = true;
            label7.Visible = false;
            textBox7.Visible = false;
            panel2.Visible = false;
            panel4.Visible = false;
            textBox1.Text = "";
            mng = 2;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            if (mng == 2)
            {
                List<Employee> listOfEmployee = er.getAll();
                String keyword = this.search.Text;
                List<Employee> searchedEmployee = listOfEmployee.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.Phone.ToLower()).Contains(keyword.ToLower()) || (x.Cat.ToLower()).Contains(keyword.ToLower()));
                dataGridView1.DataSource = searchedEmployee;
            }
            else if(mng == 1)
            {
                List<Doctor> listOfDoctor = dr.getAll();
                String keyword = this.search.Text;
                List<Doctor> searchedDoctor = listOfDoctor.FindAll(x => (x.Id.ToLower()).Contains(keyword.ToLower()) || (x.Name.ToLower()).Contains(keyword.ToLower()) || (x.Phone.ToLower()).Contains(keyword.ToLower()) || (x.Cat.ToLower()).Contains(keyword.ToLower()));
                dataGridView1.DataSource = searchedDoctor;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            dhistory dui = new dhistory(l);
            dui.Visible = true;
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            mng = 2;
            panel1.Visible = false;
            panel4.Visible = false;
            emp = er.getEmployee(l.Id);
            textBox1.Text = emp.Id;
            textBox2.Text = emp.Name;
            textBox3.Text = emp.Phone;
            textBox4.Text = emp.Adress;
            textBox5.Text = emp.Cat;
            textBox6.Text = emp.Sal;
            panel2.Visible = true;
            label7.Visible = false;
            textBox7.Visible = false;
            button9.Text = "BACK";
        }

        private void adminui_Load(object sender, EventArgs e)
        {

        }

        
    }
}
