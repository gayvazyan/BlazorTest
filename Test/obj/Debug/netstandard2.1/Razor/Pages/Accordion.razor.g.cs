#pragma checksum "C:\Users\gareg\source\repos\BlazorTest\Test\Pages\Accordion.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dac6d3b72f7f405916da1d68940ec27e2857c4de"
// <auto-generated/>
#pragma warning disable 1591
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Accordion")]
    public partial class Accordion : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Accordion</h3>\r\n\r\n");
            __builder.OpenComponent<Test.Components.AccordionComponent>(1);
            __builder.AddAttribute(2, "Text1", @"1-Bootstrap is developed mobile first, a strategy in which we optimize code for mobile devices first and then scale up components as necessary using CSS media queries. To ensure proper rendering and touch zooming for all devices, add the responsive viewport meta tag to your <head>.");
            __builder.AddAttribute(3, "Text2", @"2-Bootstrap is developed mobile first, a strategy in which we optimize code for mobile devices first and then scale up components as necessary using CSS media queries. To ensure proper rendering and touch zooming for all devices, add the responsive viewport meta tag to your <head>.");
            __builder.AddAttribute(4, "Text3", @"3-Bootstrap is developed mobile first, a strategy in which we optimize code for mobile devices first and then scale up components as necessary using CSS media queries. To ensure proper rendering and touch zooming for all devices, add the responsive viewport meta tag to your <head>.");
            __builder.AddAttribute(5, "Menu1", "Մենյու—1");
            __builder.AddAttribute(6, "Menu2", "ՄԵնյու-2");
            __builder.AddAttribute(7, "Menu3", "Մենյու-3");
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
