#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3717e7caed49851ba2dafc4b577116e4d09629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdvancedSamples_Forms_BootstrapForm_BootstrapFormList), @"mvc.1.0.view", @"/Modules/AdvancedSamples/Forms/BootstrapForm/BootstrapFormList.cshtml")]
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
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Serenity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Serenity.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using VantagePoint;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using Microsoft.AspNetCore.Html;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\_ViewImports.cshtml"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3717e7caed49851ba2dafc4b577116e4d09629", @"/Modules/AdvancedSamples/Forms/BootstrapForm/BootstrapFormList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdvancedSamples_Forms_BootstrapForm_BootstrapFormList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VantagePoint.Northwind.Entities.ProductRow>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
  
    ViewBag.Title = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"box\">\r\n    <div class=\"box-header\">\r\n        <h3 class=\"box-title\">Product List</h3>\r\n        <div class=\"box-tools\">\r\n            ");
#nullable restore
#line 12 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
       Write(Html.PagedListPager((IPagedList)ViewBag.PagedList, page => Url.Action("BootstrapFormList", new { page = page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"box-body no-padding\">\r\n        <div style=\"margin: 6px\">\r\n            ");
#nullable restore
#line 17 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
       Write(Html.ActionLink("New Product", "BootstrapFormEdit", null, new { @class = "btn btn-primary" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <table class=""table table-striped"">
        <tr>
            <th>Product Name</th>
            <th style=""width: 100px;"">Discontinued</th>
            <th>Supplier</th>
            <th>Category</th>
            <th>Unit Price</th>
            <th>Units in Stock</th>
            <th></th>
        </tr>

");
#nullable restore
#line 30 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
         foreach (var item in Model)
        {
            string rowClass = "";
            if (item.ProductID == ViewBag.ProductID)
            {
                rowClass = "success";
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr");
            BeginWriteAttribute("class", " class=\"", 1186, "\"", 1203, 1);
#nullable restore
#line 37 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
WriteAttributeValue("", 1194, rowClass, 1194, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td class=\"align-center\">\r\n                    ");
#nullable restore
#line 42 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
                Write(item.Discontinued == true ? "yes" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.DisplayFor(modelItem => item.SupplierCompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.DisplayFor(modelItem => item.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.DisplayFor(modelItem => item.UnitsInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.ActionLink("Select", "BootstrapFormList", new { productID = item.ProductID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                    ");
#nullable restore
#line 58 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
               Write(Html.ActionLink("Edit", "BootstrapFormEdit", new { productID = item.ProductID }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 61 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\Forms\BootstrapForm\BootstrapFormList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VantagePoint.Northwind.Entities.ProductRow>> Html { get; private set; }
    }
}
#pragma warning restore 1591
