// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Family_Dashboard.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Family_Dashboard;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\lpain\Documents\GitHub\family-dashboard\_Imports.razor"
using Family_Dashboard.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\lpain\Documents\GitHub\family-dashboard\Pages\Counter.razor"
using Family_Dashboard.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "C:\Users\lpain\Documents\GitHub\family-dashboard\Pages\Counter.razor"
       
    private int currentCount = 0;

    private void IncrementCount()
    {
        currentCount++;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\lpain\Documents\GitHub\family-dashboard\Pages\Counter.razor"
       
    private string currentHeading = "Initial heading";
    private Response oresp = new Response();
    private void GetAuthenticationToken(MouseEventArgs args) => oresp.GetJsonResponse();

    //private async void GetNewAuthenticationToken()
    //{
    //    Response oresp = new Response();
    //    await oresp.GetJsonResponse();
    //    Task<string> result = oresp.GetJsonResponse();
    //    currentHeading = result.Result;
    //    Console.WriteLine(oresp.GetJsonResponse());
    //    Console.WriteLine(oresp.GetJsonResponse().Result);
    //    await httpClient.PostJsonAsync("api/contacts", contact);

    //    uriHelper.NavigateTo("contacts");
    //}

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
