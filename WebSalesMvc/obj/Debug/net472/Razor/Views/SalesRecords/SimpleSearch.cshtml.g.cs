#pragma checksum "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "cc68bf9bd7c7ce0273c52ffe96e3765648b439a3a5be1187b4dc7160a2c7e292"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SalesRecords_SimpleSearch), @"mvc.1.0.view", @"/Views/SalesRecords/SimpleSearch.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SalesRecords/SimpleSearch.cshtml", typeof(AspNetCore.Views_SalesRecords_SimpleSearch))]
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
#line 1 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\_ViewImports.cshtml"
using WebSalesMvc;

#line default
#line hidden
#line 2 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\_ViewImports.cshtml"
using WebSalesMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"cc68bf9bd7c7ce0273c52ffe96e3765648b439a3a5be1187b4dc7160a2c7e292", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"ee71b63c0fb96b4894e815535a6b25f7b3e4547dca9aaf57a47c48cbf84739bd", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebSalesMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Sellers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
  
    ViewData["Title"] = "Busca simples";

#line default
#line hidden
            BeginContext(103, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(110, 17, false);
#line 7 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(127, 89, true);
            WriteLiteral("</h2>\r\n\r\n<nav class=\"navbar navbar-inverse\">\r\n    <div class=\"container-fluid\">\r\n        ");
            EndContext();
            BeginContext(216, 676, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc68bf9bd7c7ce0273c52ffe96e3765648b439a3a5be1187b4dc7160a2c7e2925882", async() => {
                BeginContext(268, 221, true);
                WriteLiteral("\r\n            <div class=\"form-group\">\r\n                <div class=\"form-group\">\r\n                    <label for=\"minDate\">Data de início</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 489, "\"", 517, 1);
#line 15 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 497, ViewData["minDate"], 497, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(518, 205, true);
                WriteLiteral("/>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    <label for=\"maxDate\">Data final</label>\r\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 723, "\"", 751, 1);
#line 19 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 731, ViewData["maxDate"], 731, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(752, 133, true);
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <button type=\"submit\" class=\"btn btn-primary\">Filtrar</button>\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(892, 144, true);
            WriteLiteral("\r\n    </div>\r\n</nav>\r\n\r\n<div class=\"panel panel-primary\">\r\n    <div class=\"panel-heading\">\r\n        <h3 class=\"panel-title\">Total das vendas: = ");
            EndContext();
            BeginContext(1037, 43, false);
#line 29 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                               Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 172, true);
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"panel-body\">\r\n        <table class=\"table table-stripped table-hover\">\r\n          <thead>\r\n        <tr class=\"success\">\r\n            <th>");
            EndContext();
            BeginContext(1253, 38, false);
#line 35 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1291, 63, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                        ");
            EndContext();
            BeginContext(1355, 40, false);
#line 38 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 63, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                        ");
            EndContext();
            BeginContext(1459, 42, false);
#line 41 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1501, 63, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                        ");
            EndContext();
            BeginContext(1565, 53, false);
#line 44 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1618, 64, true);
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                        ");
            EndContext();
            BeginContext(1683, 42, false);
#line 47 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1725, 63, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                        ");
            EndContext();
            BeginContext(1789, 42, false);
#line 50 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 87, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n         </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 56 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
         foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(1975, 69, true);
            WriteLiteral("                     <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2045, 37, false);
#line 60 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2082, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2150, 39, false);
#line 63 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2189, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2257, 46, false);
#line 66 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2303, 23, true);
            WriteLiteral("\r\n                     ");
            EndContext();
            BeginContext(2326, 136, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc68bf9bd7c7ce0273c52ffe96e3765648b439a3a5be1187b4dc7160a2c7e29214388", async() => {
                BeginContext(2450, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 69 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                       WriteLiteral(item.Seller.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2462, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2530, 52, false);
#line 72 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(2582, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2650, 41, false);
#line 75 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2691, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2759, 41, false);
#line 78 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
               Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 48, true);
            WriteLiteral("\r\n                </td>\r\n                </tr>\r\n");
            EndContext();
#line 81 "C:\Users\gst20\OneDrive\Área de Trabalho\SalesWeb\WebSalesMvc\WebSalesMvc\Views\SalesRecords\SimpleSearch.cshtml"
                }

#line default
#line hidden
            BeginContext(2867, 58, true);
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebSalesMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
