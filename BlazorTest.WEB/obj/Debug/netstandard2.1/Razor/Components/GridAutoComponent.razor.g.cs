#pragma checksum "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a35c4ed2a59840cd5ee98c101168ddfa79aef70f"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTest.WEB.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using BlazorTest.WEB;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using BlazorTest.WEB.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using BlazorTest.WEB.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\_Imports.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
    public partial class GridAutoComponent<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
 if (memberInfo != null && memberInfo.Length > 0)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "thead");
            __builder.AddMarkupContent(5, "\r\n            ");
            __builder.OpenElement(6, "tr");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 8 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
                 foreach (var member in memberInfo)
                {
                    if (member.MemberType == MemberTypes.Property)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                        ");
            __builder.OpenElement(9, "th");
            __builder.AddMarkupContent(10, "\r\n                            ");
            __builder.AddContent(11, 
#nullable restore
#line 13 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
                             member.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(12, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 15 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
                    }
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n");
#nullable restore
#line 20 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\gareg\source\repos\BlazorTest\BlazorTest.WEB\Components\GridAutoComponent.razor"
  
    MemberInfo[] memberInfo;

    protected override void OnParametersSet()
    {
        base.OnParametersSet();

        if (Items != null && Items.Count() > 0)
        {
            Type typeofItem = this.Items.GetType();
            memberInfo = typeofItem.GetMembers();
        }
    }

    [Parameter]
    public List<TItem> Items { get; set; }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
