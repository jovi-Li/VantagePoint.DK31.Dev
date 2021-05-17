#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e059a1441418eafe3cff3f9a3c8e17f3356f798"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_AdvancedSamples_DataTables_BasicInit), @"mvc.1.0.view", @"/Modules/AdvancedSamples/DataTables/BasicInit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e059a1441418eafe3cff3f9a3c8e17f3356f798", @"/Modules/AdvancedSamples/DataTables/BasicInit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_AdvancedSamples_DataTables_BasicInit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<VantagePoint.Northwind.Entities.CustomerRow>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
  
    ViewData["Title"] = "DataTables.js - Basic Initialization";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\n    <h1>");
#nullable restore
#line 8 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>This sample demonstrates how you could use popular DataTables plugin instead of integrated SlickGrid when desired. Here we access data from Northwind Customers table,
    and load all records as paging / sorting is done client side for this sample.</p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 17 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
   Write(Html.PremiumSourceFile("BasicInit.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 18 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
   Write(Html.PremiumSourceFile("AdvancedSamplesPage.DataTables.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 19 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
          await Html.RenderPartialAsync("~/Modules/AdvancedSamples/PremiumSourceWarning.cshtml");

#line default
#line hidden
#nullable disable
            WriteLiteral("    </p>\n</div>\n\r\n\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 25 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
Write(Html.Script("~/Scripts/datatables/jquery.dataTables.js"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 26 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
Write(Html.Script("~/Scripts/datatables/dataTables.bootstrap.js"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 27 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
Write(Html.Stylesheet("~/Scripts/datatables/dataTables.bootstrap.css"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    <style>\r\n        section.content { background-color: #fff; }\r\n    </style>\r\n");
            }
            );
            WriteLiteral("\r\n<table id=\"example\" class=\"table table-striped table-bordered\" cellspacing=\"0\">\r\n    <thead>\r\n");
#nullable restore
#line 36 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
          var fld = VantagePoint.Northwind.Entities.CustomerRow.Fields;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <th>");
#nullable restore
#line 38 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.CustomerID.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 39 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.CompanyName.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 40 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.ContactName.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 41 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.ContactTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 42 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.Country.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 43 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.City.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 47 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 50 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.CustomerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 51 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.CompanyName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 52 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 53 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.ContactTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 54 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 55 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
               Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 57 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n    <tfoot>\r\n        <tr>\r\n            <th>");
#nullable restore
#line 61 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.CustomerID.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 62 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.CompanyName.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 63 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.ContactName.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 64 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.ContactTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 65 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.Country.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            <th>");
#nullable restore
#line 66 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\AdvancedSamples\DataTables\BasicInit.cshtml"
           Write(fld.City.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n        </tr>\r\n    </tfoot>\r\n</table>\r\n\r\n<script>\r\n    $(\'#example\').DataTable();\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<VantagePoint.Northwind.Entities.CustomerRow>> Html { get; private set; }
    }
}
#pragma warning restore 1591