#pragma checksum "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f41f937b603f3c0dc6fb4f4b6b17127c83488dd2"
// <auto-generated/>
#pragma warning disable 1591
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
#nullable restore
#line 14 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(stock==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<a>...</a>");
#nullable restore
#line 17 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
#nullable restore
#line 18 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(2, stock.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Ticker: ");
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(5, stock.ticker);

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(7, stock.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
#nullable restore
#line 21 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(10, stock.description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Market:  ");
#nullable restore
#line 22 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(14, stock.market);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.OpenElement(16, "p");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", 
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
              stock.homepage_url

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(19, stock.homepage_url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 24 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(prices==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p>...</p>");
#nullable restore
#line 32 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}
else
{

   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(21, "p");
            __builder.AddContent(22, " Open : ");
#nullable restore
#line 37 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(23, prices.o);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "p");
            __builder.AddContent(26, " High: ");
#nullable restore
#line 38 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(27, prices.h);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "p");
            __builder.AddContent(30, " Low: ");
#nullable restore
#line 39 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(31, prices.l);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, " Close: ");
#nullable restore
#line 40 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(35, prices.c);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n        ");
            __builder.OpenElement(37, "p");
            __builder.AddContent(38, " Volume: ");
#nullable restore
#line 41 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(39, prices.v);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 42 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
    
}

#line default
#line hidden
#nullable disable
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
