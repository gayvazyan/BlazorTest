using BlazorTest.Core.Models;
using BlazorTest.Server.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Pages.TestGridView
{
    public class GridViewBase : ComponentBase
    {
        [Inject]
        IEmployeeSercice employeeSercice { get; set; }
        public List<Employee> employeeList { get; set; }
        protected override async Task OnInitializedAsync()
        {
            employeeList = employeeSercice.GetAllEmployee();
        }
    }
}
