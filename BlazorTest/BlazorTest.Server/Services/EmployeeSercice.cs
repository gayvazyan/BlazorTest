using BlazorTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Services
{
    public class EmployeeSercice : IEmployeeSercice
    {
      
            public List<Employee> GetAllEmployee()
            {
                var listEmployee = new List<Employee>();

                listEmployee.Add(new Employee() { EmployeeId = 1, FirstName = "Poxos", LastName = "Poxosyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 2, FirstName = "Petros", LastName = "Petrosyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 3, FirstName = "Martiros", LastName = "Martirosyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 4, FirstName = "Kirakos", LastName = "Kirakosyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 6, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 7, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 8, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 9, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 10, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 11, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 12, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });
                listEmployee.Add(new Employee() { EmployeeId = 5, FirstName = "Garegin", LastName = "Ayvazyan", Age = 15 });

                return listEmployee;
            }
        }
    }

