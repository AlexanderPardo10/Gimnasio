#pragma checksum "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a1e51298a61a33d248100efb7b71a48b125264c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Gym.App.Presentacion.Pages.Pages_QueryCustomers), @"mvc.1.0.razor-page", @"/Pages/QueryCustomers.cshtml")]
namespace Gym.App.Presentacion.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\_ViewImports.cshtml"
using Gym.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9a1e51298a61a33d248100efb7b71a48b125264c", @"/Pages/QueryCustomers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd821f8f4eec28aba1748eed324c6104a1b94bd", @"/Pages/_ViewImports.cshtml")]
    public class Pages_QueryCustomers : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Customers/EditionCustomer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- clase bootstrap ""text-info""-->
<h2 class=""text-info"" style=""text-align: center;"" >Client List</h2>
<!-- clase bootstrap ""border""-->
<div class=""border"">
    <table class=""table"">
        <!-- <tr> = filas y las <td> = columnas -->
        <tr>
            <td>Dni</td>
            <td>Name</td>
            <td>Surname</td>
            <td>Age</td>
            <td>Telephone</td>
            <td>Address</td>
            <td>Edition</td>
        </tr>
");
#nullable restore
#line 20 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
         foreach(var reg in Model.lstCustomer){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Dni);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Age);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 26 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Telephone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
               Write(reg.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a1e51298a61a33d248100efb7b71a48b125264c6943", async() => {
                WriteLiteral("Edition");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-customerId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
                                                                                                            WriteLiteral(reg.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-customerId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["customerId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>   \r\n            </tr>\r\n");
#nullable restore
#line 32 "C:\Users\alexa\OneDrive\Escritorio\curso misión TIC 2022\Desarrollo de Software\Gym Alex\Gimnasio\Gym.App\Gym.App.Presentacion\Pages\QueryCustomers.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gym.App.Presentacion.Pages.QueryCustomersModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gym.App.Presentacion.Pages.QueryCustomersModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Gym.App.Presentacion.Pages.QueryCustomersModel>)PageContext?.ViewData;
        public Gym.App.Presentacion.Pages.QueryCustomersModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
