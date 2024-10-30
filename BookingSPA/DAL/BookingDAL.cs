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
        public void AddBooking(BookingEnti booking)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Booking (CustomerName, ServiceName, StaffName, BookingDate, Status, TotalAmount, Time) VALUES (@CustomerName, @ServiceName, @StaffName, @BookingDate, @Status, @TotalAmount, @Time)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", booking.CustomerName);
                    command.Parameters.AddWithValue("@ServiceName", booking.ServiceName);
                    command.Parameters.AddWithValue("@StaffName", booking.StaffName);
                    command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                    command.Parameters.AddWithValue("@Status", booking.Status);
                    command.Parameters.AddWithValue("@TotalAmount", booking.TotalAmount);
                    command.Parameters.AddWithValue("@Time", booking.Time);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
