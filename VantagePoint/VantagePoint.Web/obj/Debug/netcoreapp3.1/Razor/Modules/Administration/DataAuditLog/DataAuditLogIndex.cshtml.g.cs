#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\DataAuditLog\DataAuditLogIndex.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "66b5cc7be6955de64954ffa48b43aea781c6c2ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Administration_DataAuditLog_DataAuditLogIndex), @"mvc.1.0.view", @"/Modules/Administration/DataAuditLog/DataAuditLogIndex.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"66b5cc7be6955de64954ffa48b43aea781c6c2ea", @"/Modules/Administration/DataAuditLog/DataAuditLogIndex.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Administration_DataAuditLog_DataAuditLogIndex : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\DataAuditLog\DataAuditLogIndex.cshtml"
  
    ViewData["Title"] = Serenity.LocalText.Get("Db.Administration.DataAuditLog.EntityPlural");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("ContentHeader", async() => {
                WriteLiteral("\n    <h1>");
#nullable restore
#line 6 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\DataAuditLog\DataAuditLogIndex.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("<small></small></h1>\n");
            }
            );
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\DataAuditLog\DataAuditLogIndex.cshtml"
 if (VantagePoint.Administration.Repositories.UserRepository.isPublicDemo)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""alert alert-info alert-dismissable"">
    <button type=""button"" class=""close"" data-dismiss=""alert"" aria-hidden=""true"">&times;</button>
    <p>VantagePoint provides a zero configuration data logging system that allows auditing changes made to an entity by simply adding a [DataAuditLog] attribute.
    Make any change to an order and you'll see that its details are logged here.</p>    
</div>
");
#nullable restore
#line 16 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Administration\DataAuditLog\DataAuditLogIndex.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"GridDiv\"></div>\r\n\r\n<script type=\"text/javascript\">\r\n    jQuery(function () {\r\n        new VantagePoint.Administration.DataAuditLogGrid($(\'#GridDiv\'), {}).init();\r\n\r\n        Q.initFullHeightGridPage($(\'#GridDiv\'));\r\n    });\r\n</script>");
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
