#pragma checksum "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ab4d3689520f99567c382ce8c5d6e154518b9c"
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
#line 5 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using Syncfusion.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using Syncfusion.Blazor.Charts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
using Syncfusion.Blazor.Calendars;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
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
#line 17 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(stock==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<a>...</a>");
#nullable restore
#line 20 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h1");
#nullable restore
#line 21 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(2, stock.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(3, "p");
            __builder.AddContent(4, "Ticker: ");
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(5, stock.ticker);

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, " ");
#nullable restore
#line 23 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(7, stock.locale);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "p");
#nullable restore
#line 24 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(10, stock.description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, "Market:  ");
#nullable restore
#line 25 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
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
#line 26 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
              stock.homepage_url

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 26 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(19, stock.homepage_url);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"

}

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if(prices==null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(20, "<p>...</p>");
#nullable restore
#line 35 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
}
else
{


#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(21, "<h3>Latest Close</h3>\r\n        ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, " Open : ");
#nullable restore
#line 40 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(24, prices.o);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n        ");
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, " High: ");
#nullable restore
#line 41 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(28, prices.h);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "p");
            __builder.AddContent(31, " Low: ");
#nullable restore
#line 42 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(32, prices.l);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "p");
            __builder.AddContent(35, " Close: ");
#nullable restore
#line 43 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(36, prices.c);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.OpenElement(38, "p");
            __builder.AddContent(39, " Volume: ");
#nullable restore
#line 44 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(40, prices.v);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
    
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
 if (StockPrices.Count>1)
{

   

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
    foreach(var p in StockPrices)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "p");
#nullable restore
#line 52 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(42, p.Date);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n        ");
            __builder.OpenElement(44, "p");
#nullable restore
#line 53 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(45, p.o);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n        ");
            __builder.OpenElement(47, "p");
#nullable restore
#line 54 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(48, p.h);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "p");
#nullable restore
#line 55 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(51, p.l);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n        ");
            __builder.OpenElement(53, "p");
#nullable restore
#line 56 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(54, p.c);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n        ");
            __builder.OpenElement(56, "p");
#nullable restore
#line 57 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
__builder.AddContent(57, p.v);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Syncfusion.Blazor.Charts.SfStockChart>(58);
            __builder.AddAttribute(59, "Title", "Stock Chart");
            __builder.AddAttribute(60, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeriesCollection>(61);
                __builder2.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<Syncfusion.Blazor.Charts.StockChartSeries>(63);
                    __builder3.AddAttribute(64, "DataSource", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Collections.Generic.IEnumerable<System.Object>>(
#nullable restore
#line 65 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
                                       StockPrices

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(65, "Type", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Syncfusion.Blazor.Charts.ChartSeriesType>(
#nullable restore
#line 65 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
                                                          ChartSeriesType.Candle

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(66, "XName", "Date");
                    __builder3.AddAttribute(67, "High", "h");
                    __builder3.AddAttribute(68, "Low", "l");
                    __builder3.AddAttribute(69, "Open", "o");
                    __builder3.AddAttribute(70, "Close", "c");
                    __builder3.AddAttribute(71, "Volume", "v");
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 68 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 72 "C:\Users\Davido\Desktop\APBD\APBD_Project\APBDProject\APBDProject\Client\Pages\StockDetails.razor"
      
    [Parameter]
    public string id { get; set; }

    public StockInfo stock { get; set; }
    public OHLC prices { get; set; }

    public List<StockPriceDate> StockPrices = new List<StockPriceDate>();
    public List<StockPriceDate> Prices2 = new List<StockPriceDate>();



    protected override async Task OnInitializedAsync()
    {
        try{
            StockPriceDate[] tabPrices = await Http.GetFromJsonAsync<StockPriceDate[]>($"api/stocks/prices/{id}");


           
                StockPrices.AddRange(tabPrices);
        }
        catch (Exception e)
        {

        }

      

        stock = await Http.GetFromJsonAsync<StockInfo>($"api/stocks/details/{id}");


        prices = await Http.GetFromJsonAsync<OHLC>($"api/stocks/previousclose/{id}");




        var postOHCL = new StockPriceDate
            {
                Date = DateTime.Now,
                o = prices.o,
                c = prices.c,
                h = prices.h,
                l = prices.l,
                v = prices.v
            };

        var postStock = new StockInfoOHLC
            {
                Prices = postOHCL,
                Stock = stock
            };


        var postStockInfo = await Http.PostAsJsonAsync<StockInfoOHLC>($"api/stocks", postStock);
    }
     public class StockChartData
    {
        public DateTime Date { get; set; }
        public double Open { get; set; }
        public double Low { get; set; }
        public double Close { get; set; }
        public double High { get; set; }
        public double Volume { get; set; }
    }

    public List<StockChartData> StockDetailss = new List<StockChartData>
    {
        new StockChartData { Date = new DateTime(2012, 04, 02), Open = 85.9757, High = 90.6657, Low = 85.7685, Close = 90.5257, Volume = 660187068},
        new StockChartData { Date = new DateTime(2012, 04, 09), Open = 89.4471, High = 92, Low = 86.2157, Close = 86.4614, Volume = 912634864},
        new StockChartData { Date = new DateTime(2012, 04, 16), Open = 87.1514, High = 88.6071, Low = 81.4885, Close = 81.8543, Volume = 1221746066},
        new StockChartData { Date = new DateTime(2012, 04, 23), Open = 81.5157, High = 88.2857, Low = 79.2857, Close = 86.1428, Volume = 965935749},
        new StockChartData { Date = new DateTime(2012, 04, 30), Open = 85.4, High =  85.4857, Low = 80.7385, Close = 80.75, Volume = 615249365},
        new StockChartData { Date = new DateTime(2012, 05, 07), Open = 80.2143, High = 82.2685, Low = 79.8185, Close = 80.9585, Volume = 541742692},
        new StockChartData { Date = new DateTime(2012, 05, 14), Open = 80.3671, High = 81.0728, Low = 74.5971, Close = 75.7685, Volume = 708126233},
        new StockChartData { Date = new DateTime(2012, 05, 21), Open = 76.3571, High = 82.3571, Low = 76.2928, Close = 80.3271, Volume = 682076215},
        new StockChartData { Date = new DateTime(2012, 05, 28), Open = 81.5571, High = 83.0714, Low = 80.0743, Close = 80.1414, Volume = 480059584},
    };




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
