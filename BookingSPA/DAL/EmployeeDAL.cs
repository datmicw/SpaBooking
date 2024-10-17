using System;
using System.Collections.Generic;
using BookingSPA.Entities;
using System.Data.SqlClient;

namespace BookingSPA.DAL
{
    public class EmployeeDAL
    {
        private readonly DbConnection dbConnection;
        public EmployeeDAL()
        {
            dbConnection = new DbConnection();
        }
        public void AddEmployee(EmployeeEnti employee)
        {
            using(SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "INSERT INTO Employee (FullName, Position, Phone, DateHired) VALUES (@FullName, @Position, @Phone, @DateHired)";
                using(SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FullName", employee.FullName);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@Phone", employee.Phone);
                    command.Parameters.AddWithValue("@DateHired", employee.DateHired);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
         
            }
        }
        public List<EmployeeEnti> GetAllEmployees()
        {
            var employees = new List<EmployeeEnti>();

            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "SELECT * FROM Employee"; 
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var employee = new EmployeeEnti
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                FullName = reader["FullName"].ToString(),
                                Position = reader["Position"].ToString(),
                                Phone = reader["Phone"].ToString(),
                                DateHired = reader["DateHired"] != DBNull.Value
                                    ? (DateTime)reader["DateHired"]
                                    : DateTime.MinValue
                            };
                            employees.Add(employee);
                        }
                    }
                }
            }
            return employees;
        }
        public void UpdateEmployee(EmployeeEnti employee)
        {
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "UPDATE Employee SET FullName = @FullName, Position = @Position, Phone = @Phone, DateHired = @DateHired WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", employee.Id);
                    command.Parameters.AddWithValue("@FullName", employee.FullName);
                    command.Parameters.AddWithValue("@Position", employee.Position);
                    command.Parameters.AddWithValue("@Phone", employee.Phone);
                    command.Parameters.AddWithValue("@DateHired", employee.DateHired);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
        public void DeleteEmployee(EmployeeEnti employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));
            using (SqlConnection connection = dbConnection.GetConnection())
            {
                string query = "DELETE Employee WHERE Id = @Id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", employee.Id);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

    }
}
