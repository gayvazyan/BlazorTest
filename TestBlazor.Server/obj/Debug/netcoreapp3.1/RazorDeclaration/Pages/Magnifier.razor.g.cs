// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TestBlazor.Server.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\_Imports.razor"
using TestBlazor.Server.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/magnifier")]
    public partial class Magnifier : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 9 "C:\Users\Garegin\source\repos\BlazorTest\TestBlazor.Server\Pages\Magnifier.razor"
       

    private string imgID = "myimage";
    private int zoom = 5;


    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            await jSRuntime.InvokeAsync<string>("magnify", imgID,zoom);
        }

    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jSRuntime { get; set; }
    }
}
#pragma warning restore 1591
