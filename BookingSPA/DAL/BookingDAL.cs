using BookingSPA.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

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
                    command.Parameters.AddWithValue("@Time", (object)booking.Time ?? DBNull.Value); // Handle null explicitly

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void UpdateBooking(BookingEnti booking)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE Booking SET CustomerName = @CustomerName, ServiceName = @ServiceName, StaffName = @StaffName, BookingDate = @BookingDate, Status = @Status WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", booking.Id);
                    command.Parameters.AddWithValue("@CustomerName", booking.CustomerName);
                    command.Parameters.AddWithValue("@ServiceName", booking.ServiceName);
                    command.Parameters.AddWithValue("@StaffName", booking.StaffName);
                    command.Parameters.AddWithValue("@BookingDate", booking.BookingDate);
                    command.Parameters.AddWithValue("@Status", booking.Status);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public List<BookingEnti> GetAllBooking()
        {
            var bookings = new List<BookingEnti>();

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Booking";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var booking = new BookingEnti
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                CustomerName = reader["CustomerName"].ToString(),
                                StaffName = reader["StaffName"].ToString(),
                                ServiceName = reader["ServiceName"].ToString(),
                                BookingDate = reader["BookingDate"] != DBNull.Value
                                    ? (DateTime)reader["BookingDate"]
                                    : DateTime.MinValue,
                                Status = reader["Status"].ToString(),
                                TotalAmount = reader["TotalAmount"] != DBNull.Value ? Convert.ToDecimal(reader["TotalAmount"]) : 0m, 
                            };
                            bookings.Add(booking);
                        }
                    }
                }
            }
            return bookings;
        }

    }
}
