using Interfaces;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Repository
{
    public class PatientRepo : IPatientRepo
    {

        DataAccess dcc;

        public PatientRepo()
        {
            dcc = new DataAccess();
        }

        public bool insertDB(patient q)
        {
            string query = "INSERT into Patients VALUES ('" + q.Name + "', '" + q.Phone + "', " + q.Age + ", '" + q.Bgroup + "', '" + q.Cat + "', '" + q.Date + "', '" + q.Comment + "', '" + q.Did + "'," + q.Refer+ "," + q.Status + ")";
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

       public  List<Doctor> GetAllDoctor (string cat)
        {
            List<Doctor> listOfDoctors = new List<Doctor>();

            string query = "SELECT name,id,fee from Doctors WHERE cat = '" + cat + "'";

            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                Doctor d = new Doctor();
                d.Name = sdr["name"].ToString();
                d.Id = sdr["id"].ToString();
                d.Fee = Int32.Parse(sdr["fee"].ToString());
                
               

                listOfDoctors.Add(d);
            }

            dcc.CloseConnection();

            return listOfDoctors;
        }

       public List<patient> GetAllPatient(string id,string w,int i)
       {
           List<patient> listOfPatient = new List<patient>();

           string query = "SELECT * from Patients WHERE did = '" + id + "' AND stat = " + i + " AND date = '" + w + "'";

           dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
           {
               patient p = new patient();
               p.Name = sdr["name"].ToString();
               p.Phone = sdr["phone"].ToString();
               p.Cat = sdr["cat"].ToString();
               p.Date = sdr["date"].ToString();
               p.Did = sdr["did"].ToString();
               p.Age = Int32.Parse(sdr["age"].ToString());
               p.Bgroup = sdr["bgroup"].ToString();
               p.Comment = sdr["comment"].ToString();
               p.Refer = Int32.Parse(sdr["refer"].ToString());
               p.Status = Int32.Parse(sdr["stat"].ToString());
               
               listOfPatient.Add(p);
           }

           dcc.CloseConnection();

           return listOfPatient;
       }

       public bool insertfee(int n,int m)
       {
           string query = "INSERT into Payment VALUES ("+n+","+m+")";
           try
           {
               dcc.ConnectWithDB();
               int rn = dcc.GetData(query);
               dcc.CloseConnection();
               return true;
           }
           catch (Exception exp)
           {
               return false;
           }
       }
       public int getfee(int n)
       {
           int m = 0;
           string query = "SELECT fee from Payment WHERE refer = " + n + "";
           dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
           {
            
              m =  Int32.Parse(sdr["fee"].ToString());
           }

           dcc.CloseConnection();

           return m ;
       }

       public patient getpatient(int n)
       {

           patient p = new patient();
           string query = "SELECT * from Patients WHERE refer = " + n + "";
           dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
           {
               p.Name = sdr["name"].ToString();
               p.Phone = sdr["phone"].ToString();
               p.Cat = sdr["cat"].ToString();
               p.Date = sdr["date"].ToString();
               p.Did= sdr["did"].ToString();
               p.Age = Int32.Parse(sdr["age"].ToString());
               p.Bgroup = sdr["bgroup"].ToString();
               p.Comment = sdr["comment"].ToString();
               p.Refer= Int32.Parse(sdr["refer"].ToString());
               p.Status= Int32.Parse(sdr["stat"].ToString());

               
               
           }

           dcc.CloseConnection();

           return p;
       }
       public patient getselected(string n)
       {

           patient p = new patient();
           string query = "SELECT * from Patients WHERE phone = '" + n + "'";
           dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
           {
               p.Name = sdr["name"].ToString();
               p.Phone = sdr["phone"].ToString();
               p.Cat = sdr["cat"].ToString();
               p.Date = sdr["date"].ToString();
               p.Did = sdr["did"].ToString();
               p.Age = Int32.Parse(sdr["age"].ToString());
               p.Bgroup = sdr["bgroup"].ToString();
               p.Comment = sdr["comment"].ToString();
               p.Refer = Int32.Parse(sdr["refer"].ToString());
               p.Status = Int32.Parse(sdr["stat"].ToString());



           }

           dcc.CloseConnection();

           return p;
       }
       public bool updateStatus(patient p)
       {
           string query = "UPDATE Patients SET name = '" + p.Name + "', phone = '" + p.Phone + "', age = " + p.Age + ", bgroup = '" + p.Bgroup + "', cat = '" + p.Cat + "', date = '" + p.Date + "', comment = '" + p.Comment + "', did = '" + p.Did + "' , refer = " + p.Refer + " , stat = " + p.Status + " WHERE refer = " + p.Refer + "";
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

       public bool insertprescribed(patient q, login qw, string s)
       {
           string query = "INSERT into Prescribed VALUES ('" + qw.Id + "','" + q.Name + "', '" + q.Phone + "'," + q.Age + ",'" + q.Bgroup + "','" + q.Comment + "', '" + s + "', '" + q.Date + "')";
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

       public bool DeletePrescribed(patient p)
       {
           string query = "DELETE from Patients WHERE phone = '" +p.Phone+ "'";
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

       public List<prescribed> getprescribed(login l)
       {

           List<prescribed> lp = new List<prescribed>();
           
           string query = "SELECT * from Prescribed WHERE did = '" + l.Id + "'";
           dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
           {
               prescribed p = new Entity.prescribed();
               p.Name = sdr["name"].ToString();
               p.Phone = sdr["phone"].ToString();

               p.Date = sdr["date"].ToString();
               p.Did = sdr["did"].ToString();
               p.Age = Int32.Parse(sdr["age"].ToString());
               p.Bgroup = sdr["bgroup"].ToString();
               p.Comment = sdr["comment"].ToString();
               p.Pres = sdr["pres"].ToString();
               lp.Add(p);


           }
           dcc.CloseConnection();

           return lp;
       }

     
    

    }
}