#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\Sergen\SergenIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53af2d65f6a92e5af77d28ac78d85927a071b95c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Administration_Sergen_SergenIndex), @"mvc.1.0.view", @"/Modules/Administration/Sergen/SergenIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53af2d65f6a92e5af77d28ac78d85927a071b95c", @"/Modules/Administration/Sergen/SergenIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Administration_Sergen_SergenIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\Sergen\SergenIndex.cshtml"
  
    ViewData["Title"] = Serenity.LocalText.Get("Db.Administration.Translation.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"PanelDiv\"></div>\r\n\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 9 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\Sergen\SergenIndex.cshtml"
Write(Html.Script("~/Scripts/vue.js"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new VantagePoint.Administration.SergenPanel($(\'#PanelDiv\'), {}).init();\r\n    });\r\n</script>");
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
