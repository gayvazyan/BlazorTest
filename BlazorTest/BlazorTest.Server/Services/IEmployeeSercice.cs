using BlazorTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Services
{
    public interface IEmployeeSercice
    {
        public List<Employee> GetAllEmployee();
    }
}
