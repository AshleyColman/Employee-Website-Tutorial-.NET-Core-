using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class MockEmployeeRepository : IEmployeeRepository
    {
        private List<Employee> _employeeList;

        public MockEmployeeRepository()
        {
            _employeeList = new List<Employee>()
            {
                new Employee() {Id = 1, Name = "Name1", Department = Dept.HR, Email = "Email1@Email.com" },
                new Employee() {Id = 2, Name = "Name2", Department = Dept.IT, Email = "Email2@Email.com" },
                new Employee() {Id = 3, Name = "Name3", Department = Dept.Payroll, Email = "Email3@Email.com" },
            };
        }

        public Employee AddEmployee(Employee employee)
        {
            employee.Id = _employeeList.Max(e => e.Id) + 1;
            _employeeList.Add(employee);
            return employee;
        }

        public Employee DeleteEmployee(int id)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == id);

            if (employee != null)
            {
                _employeeList.Remove(employee);
            }

            return employee;
        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return _employeeList;
        }

        public Employee GetEmployee(int id)
        {
            return _employeeList.FirstOrDefault(e => e.Id == id);
        }

        public Employee UpdateEmployee(Employee employeeToUpdate)
        {
            Employee employee = _employeeList.FirstOrDefault(e => e.Id == employeeToUpdate.Id);

            if (employee != null)
            {
                employee.Name = employeeToUpdate.Name;
                employee.Email = employeeToUpdate.Email;
                employee.Department = employeeToUpdate.Department;
            }

            return employee;
        }
    }
}
