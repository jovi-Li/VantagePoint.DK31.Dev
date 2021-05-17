#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a452ab89cfbe3af154f236661309ab05120c321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_BasicSamples_Grids_ConditionalFormatting_Index), @"mvc.1.0.view", @"/Modules/BasicSamples/Grids/ConditionalFormatting/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a452ab89cfbe3af154f236661309ab05120c321", @"/Modules/BasicSamples/Grids/ConditionalFormatting/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_BasicSamples_Grids_ConditionalFormatting_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
  
    ViewData["Title"] = "Conditional Formatting In Grid Rows";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\r\n    <h1>");
#nullable restore
#line 6 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\r\n");
            }
            );
            WriteLiteral(@"
<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>
        This sample demonstrates how to style rows depending on data item values.
    </p>
    <p>
        Discontinued rows use grayed text. Rows with Units In Stock &lt; 0 shows with a red background.
        Rows with Units In Stock &lt; 20 shows with a orange background.
        Rows with Units In Stock &gt; 50 are in italic.
        Unit price is colored depending on the price level being higher than 50, or lower than 20.
    </p>
    <p>
        Coloring is done by adding CSS classes to row, by overriding <em>getItemCssClass</em> method.
    </p>

    <p style=""text-align: right;""><b>Source Files:</b> 
        ");
#nullable restore
#line 25 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(Html.AppSourceFile("Index.cshtml"));

#line default
#line hidden
#nullable disable
            WriteLiteral(", \r\n        ");
#nullable restore
#line 26 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\BasicSamples\Grids\ConditionalFormatting\Index.cshtml"
   Write(Html.AppSourceFile("ConditionalFormattingGrid.ts"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    </p>
</div>

<div id=""GridDiv""></div>

<script type=""text/javascript"">
    jQuery(function () {
        new VantagePoint.BasicSamples.ConditionalFormattingGrid($('#GridDiv'), {}).init();

        Q.initFullHeightGridPage($('#GridDiv'));
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
