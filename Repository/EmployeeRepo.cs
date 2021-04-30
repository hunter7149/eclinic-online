using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using Interfaces;
using System.Data.SqlClient;


namespace Repository
{
    public class EmployeeRepo : IEmployeeRepo
    {
       DataAccess dcc;

        public EmployeeRepo()
        {
            dcc = new DataAccess();
        }

        public Employee getEmployee(string l)
        {
            Employee p = new Employee();
            string query = "SELECT * from Employees WHERE id = '" + l + "'";
            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();



            while (sdr.Read())
            {
                p.Name = sdr["name"].ToString();
                p.Phone = sdr["phone"].ToString();
                p.Cat = sdr["cat"].ToString();
                p.Adress = sdr["address"].ToString();
                p.Id = sdr["id"].ToString();
                p.Sal = sdr["sal"].ToString();
            }

            dcc.CloseConnection();

            return p;
        }


        public List<Employee> getAll()
        {
            List<Employee> listOfEmployees = new List<Employee>();

            string query = "SELECT * from Employees ";

            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                Employee p = new Employee();
                p.Name = sdr["name"].ToString();
                p.Phone = sdr["phone"].ToString();
                p.Cat = sdr["cat"].ToString();
                p.Adress = sdr["address"].ToString();
                p.Id = sdr["id"].ToString();
                p.Sal = sdr["sal"].ToString();



                listOfEmployees.Add(p);
            }

            dcc.CloseConnection();

            return listOfEmployees;
        }

        public bool insertEmployee(Employee d)
        {
            string query = "INSERT into Employees VALUES ('" + d.Name + "','" + d.Id + "','" + d.Phone + "','" + d.Adress + "','" + d.Cat + "','" + d.Sal + "')";
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

        public bool deleteEmployee(string s)
        {
            string query = "DELETE from Employees WHERE id = '" + s + "'";
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

        public bool updateEmployee(Employee d)
        {
            string query = "UPDATE Employees SET name = '" + d.Name + "', id = '" + d.Id + "', phone = '" + d.Phone + "', address = '" + d.Adress + "', cat = '" + d.Cat + "', sal = '" + d.Sal + "' WHERE id = '" + d.Id + "'";
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
    }
}
