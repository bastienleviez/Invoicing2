#pragma checksum "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5abd8f63dd58b0d0f1168bbca0bf02534604bbf4"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/createInvoice")]
    public partial class CreateInvoice : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
 if (IsSuccess == 3)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<h1>Create an invoice</h1>");
            __builder.OpenElement(1, "p");
            __builder.AddContent(2, "Erreur ");
            __builder.AddContent(3, 
#nullable restore
#line 9 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
               errorMessage

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(4, ", la facture n\'a pas pu être créée");
            __builder.CloseElement();
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                      newInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "form-group");
                __builder2.AddMarkupContent(11, "<label>Client</label>\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                   newInvoice.Customer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(16, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Customer = __value, newInvoice.Customer))));
                __builder2.AddAttribute(17, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Customer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(18, "\r\n        ");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "form-group");
                __builder2.AddMarkupContent(21, "<label>Reference</label>\r\n            ");
                __builder2.OpenElement(22, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "numero");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                     newInvoice.Reference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Reference = __value, newInvoice.Reference))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Reference));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Expected date</label>\r\n            ");
                __builder2.OpenElement(32, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputDate_0(__builder2, 33, 34, "dateExpected", 35, 
#nullable restore
#line 28 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                           newInvoice.Expected

#line default
#line hidden
#nullable disable
                , 36, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Expected = __value, newInvoice.Expected)), 37, () => newInvoice.Expected);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group");
                __builder2.AddMarkupContent(41, "<label>Amount</label>\r\n            ");
                __builder2.OpenElement(42, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputNumber_1(__builder2, 43, 44, "amount", 45, 
#nullable restore
#line 34 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                       newInvoice.Amount

#line default
#line hidden
#nullable disable
                , 46, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Amount = __value, newInvoice.Amount)), 47, () => newInvoice.Amount);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n\r\n        ");
                __builder2.AddMarkupContent(49, "<button type=\"submit\">Submit</button>\r\n        ");
                __builder2.AddMarkupContent(50, "<button type=\"reset\">Reset</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
}
else if (IsSuccess == 2)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(51, "<h1>Create an invoice</h1>");
            __builder.AddMarkupContent(52, "<h2>Votre facture a bien été créée</h2>");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(53);
            __builder.AddAttribute(54, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 48 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                      newInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 48 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label>Client</label>\r\n            ");
                __builder2.OpenElement(60, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "name");
                __builder2.AddAttribute(63, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 53 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                   newInvoice.Customer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(64, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Customer = __value, newInvoice.Customer))));
                __builder2.AddAttribute(65, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Customer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "form-group");
                __builder2.AddMarkupContent(69, "<label>Reference</label>\r\n            ");
                __builder2.OpenElement(70, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(71);
                __builder2.AddAttribute(72, "id", "numero");
                __builder2.AddAttribute(73, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 59 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                     newInvoice.Reference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(74, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Reference = __value, newInvoice.Reference))));
                __builder2.AddAttribute(75, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Reference));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n        ");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group");
                __builder2.AddMarkupContent(79, "<label>Expected date</label>\r\n            ");
                __builder2.OpenElement(80, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputDate_2(__builder2, 81, 82, "dateExpected", 83, 
#nullable restore
#line 65 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                           newInvoice.Expected

#line default
#line hidden
#nullable disable
                , 84, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Expected = __value, newInvoice.Expected)), 85, () => newInvoice.Expected);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group");
                __builder2.AddMarkupContent(89, "<label>Amount</label>\r\n            ");
                __builder2.OpenElement(90, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputNumber_3(__builder2, 91, 92, "amount", 93, 
#nullable restore
#line 71 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                       newInvoice.Amount

#line default
#line hidden
#nullable disable
                , 94, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Amount = __value, newInvoice.Amount)), 95, () => newInvoice.Amount);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n\r\n        ");
                __builder2.AddMarkupContent(97, "<button type=\"submit\">Submit</button>\r\n        ");
                __builder2.AddMarkupContent(98, "<button type=\"reset\">Reset</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 78 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(99, "<h1>Create an invoice</h1>");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(100);
            __builder.AddAttribute(101, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 85 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                      newInvoice

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(102, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 85 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                  HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group");
                __builder2.AddMarkupContent(106, "<label>Client</label>\r\n            ");
                __builder2.OpenElement(107, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(108);
                __builder2.AddAttribute(109, "id", "name");
                __builder2.AddAttribute(110, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 90 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                   newInvoice.Customer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(111, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Customer = __value, newInvoice.Customer))));
                __builder2.AddAttribute(112, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Customer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n        ");
                __builder2.OpenElement(114, "div");
                __builder2.AddAttribute(115, "class", "form-group");
                __builder2.AddMarkupContent(116, "<label>Reference</label>\r\n            ");
                __builder2.OpenElement(117, "div");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(118);
                __builder2.AddAttribute(119, "id", "numero");
                __builder2.AddAttribute(120, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                     newInvoice.Reference

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Reference = __value, newInvoice.Reference))));
                __builder2.AddAttribute(122, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newInvoice.Reference));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(123, "\r\n        ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "form-group");
                __builder2.AddMarkupContent(126, "<label>Expected date</label>\r\n            ");
                __builder2.OpenElement(127, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputDate_4(__builder2, 128, 129, "dateExpected", 130, 
#nullable restore
#line 102 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                           newInvoice.Expected

#line default
#line hidden
#nullable disable
                , 131, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Expected = __value, newInvoice.Expected)), 132, () => newInvoice.Expected);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n        ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "form-group");
                __builder2.AddMarkupContent(136, "<label>Amount</label>\r\n            ");
                __builder2.OpenElement(137, "div");
                __Blazor.Invoicing.Client.Pages.CreateInvoice.TypeInference.CreateInputNumber_5(__builder2, 138, 139, "amount", 140, 
#nullable restore
#line 108 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
                                                       newInvoice.Amount

#line default
#line hidden
#nullable disable
                , 141, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newInvoice.Amount = __value, newInvoice.Amount)), 142, () => newInvoice.Amount);
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(143, "\r\n\r\n        ");
                __builder2.AddMarkupContent(144, "<button type=\"submit\">Submit</button>\r\n        ");
                __builder2.AddMarkupContent(145, "<button type=\"reset\">Reset</button>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 115 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\levie\Documents\EPSI\B3\C#\Invoicing\Invoicing\Client\Pages\CreateInvoice.razor"
       

    private int currentCount = 0;
    private Invoice newInvoice = new Invoice();
    private EditContext editContext;
    private int IsSuccess = 1;
    private bool created = false;
    private string errorMessage = "";

    protected override void OnInitialized()
    {
        editContext = new EditContext(newInvoice);
    }

    private async Task HandleValidSubmit()
    {
        Console.Out.WriteLine(newInvoice.Customer);

        DateTime td = DateTime.Now;
        Invoice invoiceToCreate = new Invoice(newInvoice.Reference, newInvoice.Customer, newInvoice.Amount, td, newInvoice.Expected);

        var response = await http.PostAsJsonAsync("api/Invoices", invoiceToCreate);

        var statut = response.IsSuccessStatusCode;

        if (statut)
        {
            IsSuccess = 2;
        }
        else
        {
            IsSuccess = 3;
            errorMessage = response.ReasonPhrase;
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.Invoicing.Client.Pages.CreateInvoice
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
