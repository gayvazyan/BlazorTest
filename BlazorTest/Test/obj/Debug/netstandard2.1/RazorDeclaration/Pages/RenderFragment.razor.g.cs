#pragma checksum "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\Pages\RenderFragment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32c21aaa4750ca1266b8725a9d5b186bfcfe2596"
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
#line 1 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Test;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Test.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using Test.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RenderFragment")]
    public partial class RenderFragment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\gareg\Source\Repos\BlazorTest\BlazorTest\Test\Pages\RenderFragment.razor"
       
    private List<Customer> customers;

    protected override void OnInitialized()
    {
        base.OnInitialized();

        customers = new List<Customer>();

        customers.AddRange(new Customer[3]
    {
            new Customer{ Id=1, Name="Պողոս", SureName="Պողոսյան", Age=20},
            new Customer{ Id=2, Name="Պետրոս", SureName="Պետրոսյան", Age=23},
            new Customer{ Id=3, Name="Մարտիրոս", SureName="Մարտիրոսյան", Age=25}
                    });
    }

    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string SureName { get; set; }
        public int Age { get; set; }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
