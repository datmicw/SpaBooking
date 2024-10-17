using System;
using BookingSPA.Entities;
using BookingSPA.DAL;

namespace BookingSPA.BLL
{
    public class EmployeeBLL
    {
        private readonly EmployeeDAL employeeDAL;

        public EmployeeBLL()
        {
            employeeDAL = new EmployeeDAL();
        }

        public void AddEmployee(EmployeeEnti employee)
        {
            ValidateEmployee(employee);
            employeeDAL.AddEmployee(employee);
        }

        public void UpdateEmployee(EmployeeEnti employee) 
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            employeeDAL.UpdateEmployee(employee);
        }
        public void DeleteEmployee(EmployeeEnti employee)
        {
            employeeDAL.DeleteEmployee(employee);
        }

        private void ValidateEmployee(EmployeeEnti employee)
        {
            if (string.IsNullOrWhiteSpace(employee.FullName))
                throw new ArgumentException("Tên nhân viên không được để trống.");

            if (string.IsNullOrWhiteSpace(employee.Position))
                throw new ArgumentException("Vị trí không được để trống.");

            if (string.IsNullOrWhiteSpace(employee.Phone))
                throw new ArgumentException("Số điện thoại không được để trống.");
        }
    }
}
