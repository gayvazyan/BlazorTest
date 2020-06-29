#pragma checksum "C:\Users\gareg\source\repos\BlazorTest\Test\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05ba2b01c616bce74c224b46a23aaa81017a2a97"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Test.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Test.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gareg\source\repos\BlazorTest\Test\_Imports.razor"
using Test.Configuration;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Users\gareg\source\repos\BlazorTest\Test\Pages\Index.razor"
 
    private List<Employee> listEmployees;
    private List<ColumnDefinition> columnsDefinition;





    protected override void OnInitialized()
    {
        base.OnInitialized();
        Initialize();
    }

    private void Initialize()
    {
        if (listEmployees == null)
        {
            listEmployees = new List<Employee>();

            listEmployees.AddRange(
                new Employee[]
                {
                    new Employee
                    {
                        Name="Martiros",
                        Title="Developer",
                        Department="Software Dev",
                        EmploymentDate=DateTime.Now,
                        Salary=1000000
                    },
                     new Employee
                    {
                        Name="Kirakos",
                        Title="DBA",
                        Department="IT Dev",
                        EmploymentDate=DateTime.Now,
                        Salary=2000000
                    },
                      new Employee
                    {
                        Name="Poxos",
                        Title="Developer",
                        Department="Software Dev",
                        EmploymentDate=DateTime.Now,
                        Salary=3000000
                    },
                       new Employee
                    {
                        Name="Petros",
                        Title="QA",
                        Department="QA Dev",
                        EmploymentDate=DateTime.Now,
                        Salary=8000000
                    },
                }

                );
        }

        if (columnsDefinition == null)
        {
            columnsDefinition = new List<ColumnDefinition>();
            columnsDefinition.AddRange(
                new ColumnDefinition[]{
                    new ColumnDefinition { DataField="Name",Caption="Name"},
                    new ColumnDefinition { DataField="Title",Caption="Title"},
                    new ColumnDefinition { DataField="Department",Caption="Department"},
                    new ColumnDefinition { DataField="EmploymentDate",Caption="EmploymentDate", Format="dd/MM/yyyy", DataType=DataType.Date },
                    new ColumnDefinition { DataField="Salary",Caption="Annual Salary", DataType=DataType.Currency, Alignment=Alignment.Right, Format="c"}

                });
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public DateTime EmploymentDate { get; set; }
        public Decimal Salary { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
