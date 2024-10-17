using System;
using BookingSPA.Entities;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BookingSPA.DAL
{
    public class ServiceDAL
    {
        private readonly DbConnection dbConnection;
        public ServiceDAL()
        {
            dbConnection = new DbConnection();
        }
        public void AddService(ServiceEnti serviceEnti)
        {
            using(SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Service (Name, Price) VALUES(@Name, @Price)";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Name", serviceEnti.Name);
                    command.Parameters.AddWithValue("@Price", serviceEnti.Price);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void UpdateService(ServiceEnti service)
        {
            using(SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE Service SET Name = @Name, Price = @Price WHERE Id = @Id";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", service.Id);
                    command.Parameters.AddWithValue("@Name", service.Name);
                    command.Parameters.AddWithValue("@Price", service.Price);
                    connection.Open ();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteService(ServiceEnti service)
        {
            if (service == null)
                throw new ArgumentNullException(nameof(service));
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "DELETE FROM Service WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", service.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public List<ServiceEnti> GetAllService()
        {
            var service = new List<ServiceEnti>();

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT Id, Name, Price FROM Service";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var serviceenti = new ServiceEnti
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader["Name"].ToString(),
                                Price = reader.GetDecimal(reader.GetOrdinal("Price"))
                            };
                            service.Add(serviceenti);
                        }
                    }
                }
            }
            return service;
        }
    }
}
