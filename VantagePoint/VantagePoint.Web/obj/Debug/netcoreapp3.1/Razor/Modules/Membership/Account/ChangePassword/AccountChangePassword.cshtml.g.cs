#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "778c5a0eaf1f8ca574afac98e3f2dfed7c947f0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ChangePassword_AccountChangePassword), @"mvc.1.0.view", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"778c5a0eaf1f8ca574afac98e3f2dfed7c947f0b", @"/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ChangePassword_AccountChangePassword : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ChangePassword.FormTitle;
    ViewData["PageId"] = "ChangePassword";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script id=\"Template_Membership_ChangePasswordPanel\" type=\"text/template\">\r\n<div>\r\n    <h3 class=\"page-title\">");
#nullable restore
#line 8 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
                      Write(Texts.Forms.Membership.ChangePassword.FormTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
    <form id=""~_Form"" action="""">
        <div class=""s-Form"">
            <div class=""fieldset ui-widget ui-widget-content ui-corner-all"">
                <div id=""~_PropertyGrid""></div>
                <div class=""clear""></div>
            </div>
            <div class=""buttons"">
                <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary"">
                    ");
#nullable restore
#line 17 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ChangePassword\AccountChangePassword.cshtml"
               Write(Texts.Forms.Membership.ChangePassword.SubmitButton);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </button>
            </div>
        </div>
    </form>
</div>
</script>

<div class=""page-content"">
    <div id=""ChangePasswordPanel"">
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new VantagePoint.Membership.ChangePasswordPanel($('#ChangePasswordPanel')).init();
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