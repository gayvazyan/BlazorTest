#pragma checksum "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\Components\CounterComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69ac01c07ca09e47c6d5ee4701f1d67642a58581"
// <auto-generated/>
#pragma warning disable 1591
namespace TestBlazor.Server.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server.Components;

#line default
#line hidden
#nullable disable
    public partial class CounterComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Counter Component</h3>\r\n\r\n\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn btn-primary");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\Components\CounterComponent.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Click me");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 7 "C:\Users\Garegin\source\repos\TestBlazor\TestBlazor.Server\Components\CounterComponent.razor"
       
    private int currentCount = 0;

    [Parameter]
    public EventCallback<int> Count { get; set; }

    private void IncrementCount()
    {
        currentCount++;
        Count.InvokeAsync(currentCount);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
