using System;
using Entity;
using Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository
{
    public class DoctorRepo: IDoctorRepo
    {
        DataAccess dcc;

        public DoctorRepo()
        {
            dcc = new DataAccess();
        }
        public Doctor getInfo(login l)
        {

            Doctor p = new Doctor();
            string query = "SELECT * from Doctors WHERE id = '" + l.Id+ "'";
            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                p.Name = sdr["name"].ToString();
                p.Phone = sdr["phone"].ToString();
                p.Cat = sdr["cat"].ToString();
                p.Adress = sdr["address"].ToString();
                p.Fee = Int32.Parse(sdr["fee"].ToString());
                p.Id = sdr["id"].ToString();
                p.Sal = sdr["sal"].ToString();
               


            }

            dcc.CloseConnection();

            return p;
        }


        public bool updateDoctor(Doctor d)
        {
            string query = "UPDATE Doctors SET name = '" + d.Name + "', id = '" + d.Id + "', phone = '" + d.Phone + "', address = '" + d.Adress + "', cat = '" + d.Cat + "', fee = " + d.Fee + ", sal = '" +d.Sal + "' WHERE id = '"+d.Id+ "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.GetData(query);
          

                 dcc.CloseConnection();

                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public List<Doctor> getAll()
        {
            List<Doctor> listOfDoctors = new List<Doctor>();

            string query = "SELECT * from Doctors ";

            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                Doctor p = new Doctor();
                p.Name = sdr["name"].ToString();
                p.Phone = sdr["phone"].ToString();
                p.Cat = sdr["cat"].ToString();
                p.Adress = sdr["address"].ToString();
                p.Fee = Int32.Parse(sdr["fee"].ToString());
                p.Id = sdr["id"].ToString();
                p.Sal = sdr["sal"].ToString();



                listOfDoctors.Add(p);
            }

            dcc.CloseConnection();

            return listOfDoctors;
        }

        public bool deleteDoctor(string s)
        {
            string query = "DELETE from Doctors WHERE id = '" + s + "'";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.GetData(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }   
        }

        public bool insertComplain(string s,string d)
        {
            string query = "INSERT into Complain VALUES ('" + s + "','"+d+"')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.GetData(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }

        public bool insertDoctor(Doctor d)
        {
            string query = "INSERT into Doctors VALUES ('" + d.Name + "','" + d.Id + "','" + d.Phone + "','" + d.Adress + "','" + d.Cat + "'," + d.Fee + ",'" + d.Sal + "')";
            try
            {
                dcc.ConnectWithDB();
                int n = dcc.GetData(query);
                dcc.CloseConnection();
                return true;
            }
            catch (Exception exp)
            {
                return false;
            }
        }


        public Doctor getDoctor(string l)
        {

            Doctor p = new Doctor();
            string query = "SELECT * from Doctors WHERE id = '" + l + "'";
            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
            {
                p.Name = sdr["name"].ToString();
                p.Phone = sdr["phone"].ToString();
                p.Cat = sdr["cat"].ToString();
                p.Adress = sdr["address"].ToString();
                p.Fee = Int32.Parse(sdr["fee"].ToString());
                p.Id = sdr["id"].ToString();
                p.Sal = sdr["sal"].ToString();



            }

            dcc.CloseConnection();

            return p;
        }

        public List<Complain> getCmp()
        {
            List<Complain> listOfComplains = new List<Complain>();

            string query = "SELECT * from Complain";

            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                Complain cmp = new Complain();
                cmp.Cmp = sdr["cmp"].ToString();
                cmp.Date = sdr["date"].ToString();
               



                listOfComplains.Add(cmp);
            }

            dcc.CloseConnection();

            return listOfComplains;
 
        }

        public string getName(string s)
        {

      
            string query = "SELECT name from Doctors WHERE id = '" + s + "'";
            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();

            string nam = null;

            while (sdr.Read())
            {
                nam = sdr["name"].ToString();
            }

            dcc.CloseConnection();

            return nam;
        }

    }
}
