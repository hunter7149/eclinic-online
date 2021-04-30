using System;
using System.Data.SqlClient;

namespace Repository
{
    class DataAccess
    {
        public SqlConnection conn;
        private SqlCommand command;
        public void ConnectWithDB()
        {
            try
            {
                conn = new SqlConnection(@"Data Source=DESKTOP-KEO6G7Q\SQLEXPRESS01;Initial Catalog=eclinic;Integrated Security=True");
                conn.Open();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void CloseConnection()
        {
            this.conn.Close();
        }

        public int GetData(string sql)
        {

            this.command = new SqlCommand(sql, this.conn);
            return this.command.ExecuteNonQuery();
        }

    }
}
