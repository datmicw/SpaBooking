using BookingSPA.Entities;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingSPA.DAL
{
    public class BookingDAL
    {
        private readonly DbConnection dbConnection;
        public BookingDAL()
        {
            dbConnection = new DbConnection();
        }
        public List<ServiceEnti> GetAllServices()
        {
            var services = new List<ServiceEnti>();
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT Id, Name FROM Service"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var service = new ServiceEnti
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                            };
                            services.Add(service);
                        }
                    }
                }
            }
            return services;
        }

    }
}
