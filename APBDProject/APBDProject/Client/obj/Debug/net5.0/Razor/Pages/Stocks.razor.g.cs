#pragma checksum "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42d4faf02d2233593aadb61d92ac8690f7972bec"
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
#line 2 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
using APBDProject.Shared.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
using APBDProject.Shared.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dashboard")]
    public partial class Stocks : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Search for stocks</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group w-25 p-3 ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "class", "form-control");
            __builder.AddAttribute(6, "placeholder", "Ticker ");
            __builder.AddAttribute(7, "aria-label", "Recipient\'s username");
            __builder.AddAttribute(8, "aria-describedby", "basic-addon2");
            __builder.AddAttribute(9, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
                                                                                                                                          str

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => str = __value, str));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n  ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "input-group-append");
            __builder.OpenElement(14, "button");
            __builder.AddAttribute(15, "class", "btn btn-outline-secondary");
            __builder.AddAttribute(16, "type", "button");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
                                                                          ()=> OnChangeTickers()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Search");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
  if (stocks == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(19, "<p><em>...</em></p>");
#nullable restore
#line 31 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
}
else if (stocks != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(20, "table");
            __builder.AddAttribute(21, "style", "width: 100%; text-align : center");
            __builder.AddMarkupContent(22, "<thead><tr><th>Ticker</th> \r\n                <th>Locale</th>\r\n                <th>Name</th>\r\n                <th>Market</th>\r\n                <th>Type</th>\r\n                <th>Action</th>\r\n                <th>Add to watchlist</th></tr></thead>\r\n        ");
            __builder.OpenElement(23, "tbody");
#nullable restore
#line 47 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
             foreach (var stock in stocks)
            {
               

#line default
#line hidden
#nullable disable
            __builder.OpenElement(24, "tr");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "style", "border-bottom : 1px solid ");
#nullable restore
#line 52 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
__builder.AddContent(27, stock.ticker);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, " \r\n                    ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "style", "border-bottom : 1px solid ");
#nullable restore
#line 53 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
__builder.AddContent(31, stock.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                    ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "style", "border-bottom : 1px solid ");
#nullable restore
#line 54 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
__builder.AddContent(35, stock.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "style", "border-bottom : 1px solid ");
#nullable restore
#line 55 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
__builder.AddContent(39, stock.market);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "style", "border-bottom : 1px solid ");
#nullable restore
#line 56 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
__builder.AddContent(43, stock.type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                    ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "style", "border-bottom : 1px solid ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "type", "button");
            __builder.AddAttribute(49, "class", "btn btn-info");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
                                                                                                                     () => { OpenDetails(stock.ticker); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Details");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                    ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "style", "border-bottom : 1px solid ");
            __builder.OpenElement(55, "button");
            __builder.AddAttribute(56, "type", "button");
            __builder.AddAttribute(57, "class", "btn btn-primary");
            __builder.AddAttribute(58, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
                                                                                                                       () => AddToWatchlist(stock.ticker)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(59, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"

              
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\Stocks.razor"
       
    private StockDTO[] stocks;
    private StockInfo stock;
    private string userID;
    private string str;
    

    
    protected override async Task OnInitializedAsync()
    {
         var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
            userID = authState.User.Identity.Name;
    }


    private async void OnChangeTickers()
    {
        //???zacina się przy spamowaniu
        if (str != null && str.Length != 0) 
        {
            try
            {
                stocks = await Http.GetFromJsonAsync<StockDTO[]>($"api/stocks/{str}");
            }
            catch(Exception e)
            {
                OnChangeTickers();
            }
        }
    }

    private void OpenDetails(string id)
    {
        navigationManager.NavigateTo($"/details/{id}");
    }

    private async void AddToWatchlist(string id)
    {
         

           
        stock = await Http.GetFromJsonAsync<StockInfo>($"api/stocks/details/{id}");


        var post = await Http.PostAsJsonAsync($"api/watchlist/{userID}",stock);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
