using System;
using System.Data.SqlClient;
using System.Data;
namespace BookingSPA.DAL
{
    public class DbConnection
    {
        private readonly string connectionString = "Data Source=DESKTOP-2TTEBT8;Initial Catalog=SPA;Integrated Security=True;TrustServerCertificate=True;";

        public SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

        public void OpenConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void CloseConnection(SqlConnection connection)
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}
