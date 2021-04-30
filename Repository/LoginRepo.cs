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
    public class LoginRepo : ILoginRepo
    {
         DataAccess dcc;
         public LoginRepo() { dcc = new DataAccess(); }

        public login GetUser(string id, string password)
        {

            login l = null;
            string query = "SELECT * from Login WHERE ID = '" + id + "' AND PASS = '" + password + "'";
            dcc.ConnectWithDB();
            SqlCommand sqlCommand = new SqlCommand(query, dcc.conn);
            SqlDataReader sdr = sqlCommand.ExecuteReader();


            while (sdr.Read())
            {
                l = new login();
                l.Id = sdr["ID"].ToString();
                l.Pass = sdr["PASS"].ToString();
                l.Role = Convert.ToInt32(sdr["ROLE"]);
            }

            dcc.CloseConnection();

            return l;

        }

        public bool updateUser(login p)
        {
            string query = "UPDATE Login SET  ID = '" + p.Id + "', PASS = '" +p.Pass + "', ROLE = "+p.Role+" WHERE id = '" + p.Id + "'";
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

        public bool deleteUser(string s)
        {
            string query = "DELETE from Login WHERE ID = '" + s + "'";
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


        public bool insertUser(string s,string p,int r)
        {
            string query = "INSERT into Login VALUES ('" + s + "','" + p + "'," + r + ")";
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
