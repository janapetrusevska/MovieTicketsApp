#pragma checksum "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff2b73671d1714c47940894a45cd1839c9d8216b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
namespace AspNetCore
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
#line 1 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\_ViewImports.cshtml"
using Eshop.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\_ViewImports.cshtml"
using Eshop.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff2b73671d1714c47940894a45cd1839c9d8216b", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"186fec18b0db8eedd013d16e579c9af50038ec0e", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Eshop.Web.Models.DTO.ShoppingCartDto>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderNow", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteProductFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div class=\"container\">\r\n    <div class=\"row m-3\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2b73671d1714c47940894a45cd1839c9d8216b4505", async() => {
                WriteLiteral("Order Now");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""row m-5"">
        <table class=""table"">
            <thead class=""thead-dark"">
                <tr>
                    <th scope=""col"">#</th>
                    <th scope=""col"">Movie Name</th>
                    <th scope=""col"">Price</th>
                    <th scope=""col"">Quantity</th>
                    <th scope=""col"">Sum</th>
                    <th scope=""col""></th>


                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 22 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                 if (Model.Tickets.Count == 0 || Model.Tickets == null)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <tr>\r\n                      <td colspan=\"5\">No active Products</td>\r\n                  </tr> \r\n");
#nullable restore
#line 27 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                     for (int i = 0; i < Model.Tickets.Count; i++)
                    {
                        var item = Model.Tickets[i];

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th scope=\"row\">");
#nullable restore
#line 34 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                                        Write(i + 1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <td>");
#nullable restore
#line 35 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                           Write(item.Ticket.MovieName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 36 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                           Write(item.Ticket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                           Write(item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
#nullable restore
#line 38 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                            Write(item.Ticket.Price * item.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff2b73671d1714c47940894a45cd1839c9d8216b8742", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-productId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 39 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                                            WriteLiteral(item.TicketId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-productId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["productId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 41 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"             </tbody>

            <tfoot>
                <tr>
                    <th scope=""col"">Total Price: </th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col""></th>
                    <th scope=""col"">");
#nullable restore
#line 52 "C:\Users\User\Desktop\IS\Eshop.Web\Eshop.Web\Views\ShoppingCart\Index.cshtml"
                               Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                </tr>\r\n            </tfoot>\r\n\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Eshop.Web.Models.DTO.ShoppingCartDto> Html { get; private set; }
    }
}
#pragma warning restore 1591
