#pragma checksum "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2920a819a9b345b61d51752b3d532322cf51b6f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produit_Produits), @"mvc.1.0.view", @"/Views/Produit/Produits.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Produit/Produits.cshtml", typeof(AspNetCore.Views_Produit_Produits))]
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
#line 1 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\_ViewImports.cshtml"
using MyCatalog;

#line default
#line hidden
#line 2 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\_ViewImports.cshtml"
using MyCatalog.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2920a819a9b345b61d51752b3d532322cf51b6f4", @"/Views/Produit/Produits.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a35163efe3fd5499a77c0690e0e10e9ba73e32", @"/Views/_ViewImports.cshtml")]
    public class Views_Produit_Produits : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MyCatalog.Service.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateFrom", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ToSwitch", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(47, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
  
    ViewData["Title"] = "Produits";

#line default
#line hidden
            BeginContext(93, 32, true);
            WriteLiteral("\r\n<h2>Produits</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(125, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "830d31e79e304df38397e5b142b26c37", async() => {
                BeginContext(152, 16, true);
                WriteLiteral("Add new Product ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(172, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(178, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4931ba23b8c46d1bc9dd1288aa82a32", async() => {
                BeginContext(203, 13, true);
                WriteLiteral("List Category");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(220, 95, true);
            WriteLiteral("\r\n</p>\r\n\r\n<table class=\"table\">\r\n  \r\n    <thead>\r\n        <div class=\"container\">\r\n            ");
            EndContext();
            BeginContext(315, 235, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "319933bd21fd4b65a9b1decde38bbd44", async() => {
                BeginContext(353, 190, true);
                WriteLiteral("\r\n                <label>Mot cle : </label>\r\n                <input type=\"text\" name=\"motCle\" />\r\n                <button type=\"submit\" class=\"btn btn-primary\">Search </button>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(550, 66, true);
            WriteLiteral("\r\n        </div>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(617, 47, false);
#line 26 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
           Write(Html.DisplayNameFor(model => model.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(664, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(720, 41, false);
#line 29 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
           Write(Html.DisplayNameFor(model => model.price));

#line default
#line hidden
            EndContext();
            BeginContext(761, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(817, 44, false);
#line 32 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
           Write(Html.DisplayNameFor(model => model.Quantite));

#line default
#line hidden
            EndContext();
            BeginContext(861, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(917, 44, false);
#line 35 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(961, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 41 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1096, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1157, 46, false);
#line 45 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.DisplayFor(modelItem => item.Designation));

#line default
#line hidden
            EndContext();
            BeginContext(1203, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1271, 40, false);
#line 48 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.DisplayFor(modelItem => item.price));

#line default
#line hidden
            EndContext();
            BeginContext(1311, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1379, 43, false);
#line 51 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.DisplayFor(modelItem => item.Quantite));

#line default
#line hidden
            EndContext();
            BeginContext(1422, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1490, 56, false);
#line 54 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.DisplayFor(modelItem => item.Category.Categoryname));

#line default
#line hidden
            EndContext();
            BeginContext(1546, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1614, 71, false);
#line 57 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.ActionLink("Edit", "EditFrom", new { ProductId = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1685, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1708, 80, false);
#line 58 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.ActionLink("Details", "DetailsProduct", new { ProductId = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1788, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1811, 75, false);
#line 59 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
               Write(Html.ActionLink("Delete", "DeleteForm", new { ProductId = item.ProductId }));

#line default
#line hidden
            EndContext();
            BeginContext(1886, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 62 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
        }

#line default
#line hidden
            BeginContext(1941, 64, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n<div>\r\n    <ul class=\" nav nav-pills\">\r\n");
            EndContext();
#line 67 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
          
            for (int i = 0; i < ViewBag.totalPages; i++)
            {
                string className = "";

                if (i == ViewBag.currentPage)
                {
                    className = "active";
                }

#line default
#line hidden
            BeginContext(2260, 19, true);
            WriteLiteral("                <li");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 2279, "\"", 2297, 1);
#line 76 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
WriteAttributeValue("", 2287, className, 2287, 10, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2298, 23, true);
            WriteLiteral(">\r\n                    ");
            EndContext();
            BeginContext(2321, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d899bea58fad4950a339c7b1029b858b", async() => {
                BeginContext(2400, 5, false);
#line 77 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
                                                                                             Write(i + 1);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-page", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
                                              WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["page"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 77 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
                                                                    WriteLiteral(ViewBag.motCle);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["motCle"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-motCle", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["motCle"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2410, 25, true);
            WriteLiteral("\r\n                </li>\r\n");
            EndContext();
#line 79 "C:\Users\elaism00\source\repos\DemoCatalog\MyCatalog\Views\Produit\Produits.cshtml"
            }
        

#line default
#line hidden
            BeginContext(2461, 17, true);
            WriteLiteral("\r\n    </ul>\r\n    ");
            EndContext();
            BeginContext(2478, 139, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca8d6b3bf74e4eaebb3592926ffb03d7", async() => {
                BeginContext(2516, 94, true);
                WriteLiteral("\r\n        <button type=\"submit\"  class=\"btn btn-primary\"  >Back To All Product </button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2617, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MyCatalog.Service.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591