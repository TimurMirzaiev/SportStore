#pragma checksum "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "126aeb3190a0482584a651a3fcea62592e8ca4a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_List), @"mvc.1.0.view", @"/Views/Product/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/List.cshtml", typeof(AspNetCore.Views_Product_List))]
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
#line 1 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\_ViewImports.cshtml"
using Web.Models;

#line default
#line hidden
#line 2 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\_ViewImports.cshtml"
using Web.Models.ViewModels;

#line default
#line hidden
#line 3 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\_ViewImports.cshtml"
using Web.Infrastructure;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"126aeb3190a0482584a651a3fcea62592e8ca4a5", @"/Views/Product/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d5db1226b41990d9ea5d04117027d744d73159a", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Web.Models.ViewModels.ProductsListViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml"
 foreach (var p in Model.Products) {
    

#line default
#line hidden
            BeginContext(97, 33, false);
#line 4 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml"
Write(Html.Partial("ProductSummary", p));

#line default
#line hidden
            EndContext();
#line 4 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml"
                                      
}

#line default
#line hidden
            BeginContext(135, 6, true);
            WriteLiteral("\r\n<div");
            EndContext();
            BeginWriteAttribute("page-model", " page-model=\"", 141, "\"", 171, 1);
#line 7 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml"
WriteAttributeValue("", 154, Model.PagingInfo, 154, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(172, 144, true);
            WriteLiteral(" page-action=\"List\" page-classes-enabled=\"true\"\r\n     page-class=\"btn\" page-class-normal=\"btn-secondary\"\r\n     page-class-selected=\"btn-primary\"");
            EndContext();
            BeginWriteAttribute("page-url-category", " page-url-category=\"", 316, "\"", 358, 1);
#line 9 "C:\Users\timur\source\repos\SportStoreApp\Web\Views\Product\List.cshtml"
WriteAttributeValue("", 336, Model.CurrentCategory, 336, 22, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(359, 50, true);
            WriteLiteral("\r\n     class=\"btn-group pull-right m-1\">\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Web.Models.ViewModels.ProductsListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591