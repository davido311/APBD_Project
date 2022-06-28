// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace APBDProject.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\_Imports.razor"
using APBDProject.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using APBDProject.Shared.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/details/{id}")]
    public partial class StockDetails : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
      
    [Parameter]
    public string id { get; set; }

    public StockInfo stock { get; set; }
    public OHLC prices { get; set; }




    private List<StockPriceDate> Prices = new List<StockPriceDate>();

    protected override async Task OnInitializedAsync()
    {
        stock = await Http.GetFromJsonAsync<StockInfo>($"api/stocks/details/{id}");


        prices = await Http.GetFromJsonAsync<OHLC>($"api/stocks/previousclose/{id}");

        var postOHCL = new StockPriceDate
            {
                DateTime = DateTime.Now,
                o = prices.o,
                c = prices.c,
                h = prices.h,
                l = prices.l,
                v = prices.v
            };

       




    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
