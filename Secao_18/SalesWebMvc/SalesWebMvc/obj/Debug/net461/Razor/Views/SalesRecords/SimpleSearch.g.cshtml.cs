#pragma checksum "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "904871cd8f94d3a5a7acd74785db17566e4592ad"
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
#line 1 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc;

#line default
#line hidden
#line 2 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\_ViewImports.cshtml"
using SalesWebMvc.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"904871cd8f94d3a5a7acd74785db17566e4592ad", @"/Views/SalesRecords/SimpleSearch.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70dafd425af89a5439216963c7093f2ead686e4a", @"/Views/_ViewImports.cshtml")]
    public class Views_SalesRecords_SimpleSearch : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SalesWebMvc.Models.SalesRecord>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-form navbar-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
   ViewData["Title"] = "Simple Search"; 

#line default
#line hidden
            BeginContext(94, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(100, 17, false);
#line 5 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(117, 85, true);
            WriteLiteral("</h2>\n\n<nav class=\"navbar navbar-inverse\">\n    <div class=\"container-fluid\">\n        ");
            EndContext();
            BeginContext(202, 652, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f0bb7a10ccd0427d979f5aab79db133f", async() => {
                BeginContext(254, 211, true);
                WriteLiteral("\n            <div class=\"form-group\">\n                <div class=\"form-group\">\n                    <label for=\"minDate\">Min Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"minDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 465, "", 492, 1);
#line 13 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 472, ViewData["minDate"], 472, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(492, 200, true);
                WriteLiteral(" />\n                </div>\n                <div class=\"form-group\">\n                    <label for=\"maxDate\">Max Date</label>\n                    <input type=\"date\" class=\"form-control\" name=\"maxDate\"");
                EndContext();
                BeginWriteAttribute("value", " value=", 692, "", 719, 1);
#line 17 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
WriteAttributeValue("", 699, ViewData["maxDate"], 699, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(719, 128, true);
                WriteLiteral(" />\n                </div>\n            </div>\n            <button type=\"submit\" class=\"btn btn-primary\">Filter</button>\n        ");
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
            BeginContext(854, 131, true);
            WriteLiteral("\n    </div>\n</nav>\n<div class=\"panel panel-primary\">\n    <div class=\"panel-heading\">\n        <h3 class=\"panel-title\">Total sales = ");
            EndContext();
            BeginContext(986, 43, false);
#line 26 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                                         Write(Model.Sum(obj => obj.Amount).ToString("F2"));

#line default
#line hidden
            EndContext();
            BeginContext(1029, 208, true);
            WriteLiteral("</h3>\n    </div>\n    <div class=\"panel-body\">\n        <table class=\"table table-striped table-hover\">\n            <thead>\n                <tr class=\"success\">\n                    <th>\n                        ");
            EndContext();
            BeginContext(1238, 38, false);
#line 33 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1276, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1353, 40, false);
#line 36 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1470, 42, false);
#line 39 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller));

#line default
#line hidden
            EndContext();
            BeginContext(1512, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1589, 53, false);
#line 42 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Seller.Department));

#line default
#line hidden
            EndContext();
            BeginContext(1642, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1719, 42, false);
#line 45 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(1761, 76, true);
            WriteLiteral("\n                    </th>\n                    <th>\n                        ");
            EndContext();
            BeginContext(1838, 42, false);
#line 48 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                   Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1880, 90, true);
            WriteLiteral("\n                    </th>\n                </tr>\n            </thead>\n            <tbody>\n");
            EndContext();
#line 53 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(2033, 34, true);
            WriteLiteral("    <tr>\n        <td>\n            ");
            EndContext();
            BeginContext(2068, 37, false);
#line 57 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(2146, 39, false);
#line 60 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(2185, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(2226, 46, false);
#line 63 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Seller.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2272, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(2313, 57, false);
#line 66 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Seller.Department.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2370, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(2411, 41, false);
#line 69 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
            EndContext();
            BeginContext(2452, 40, true);
            WriteLiteral("\n        </td>\n        <td>\n            ");
            EndContext();
            BeginContext(2493, 41, false);
#line 72 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
            EndContext();
            BeginContext(2534, 24, true);
            WriteLiteral("\n        </td>\n    </tr>");
            EndContext();
#line 74 "C:\D2Ponto\GoogleDrive\Udemy\C#_Completo\Secao_18\SalesWebMvc\SalesWebMvc\Views\SalesRecords\SimpleSearch.cshtml"
         }

#line default
#line hidden
            BeginContext(2560, 55, true);
            WriteLiteral("            </tbody>\n        </table>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SalesWebMvc.Models.SalesRecord>> Html { get; private set; }
    }
}
#pragma warning restore 1591
