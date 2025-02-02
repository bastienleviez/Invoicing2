#pragma checksum "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "969992c483340019b084d860885d36073aa7470a"
// <auto-generated/>
#pragma warning disable 1591
namespace Invoicing.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\_Imports.razor"
using Invoicing.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Your activity</h1>");
#nullable restore
#line 7 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
 if (allInvoices == null)
{

}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "h2");
            __builder.AddMarkupContent(2, "CA réel : ");
            __builder.OpenElement(3, "strong");
            __builder.AddContent(4, 
#nullable restore
#line 13 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
                           SalesRevenues.ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(5, "h2");
            __builder.AddMarkupContent(6, "CA estimé : ");
            __builder.OpenElement(7, "strong");
            __builder.AddContent(8, 
#nullable restore
#line 15 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
                             CaEstime.ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(9, "h2");
            __builder.AddMarkupContent(10, "Impayé : ");
            __builder.OpenElement(11, "strong");
            __builder.AddContent(12, 
#nullable restore
#line 17 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
                          Outstanding.ToString("€ 0.00")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 18 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\Index.razor"
       



    private IEnumerable<Invoice> allInvoices = null;
    private decimal SalesRevenues;
    private decimal Outstanding;
    private decimal CaEstime;

    protected override async Task OnInitializedAsync()
    {
        allInvoices = await http.GetFromJsonAsync<IEnumerable<Invoice>>("api/dashboard");
        SalesRevenues = allInvoices.Sum(invoice => invoice.Paid);
        Outstanding = allInvoices.Sum(invoice => invoice.Amount - invoice.Paid);
        CaEstime = allInvoices.Sum(invoice => invoice.Amount);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
