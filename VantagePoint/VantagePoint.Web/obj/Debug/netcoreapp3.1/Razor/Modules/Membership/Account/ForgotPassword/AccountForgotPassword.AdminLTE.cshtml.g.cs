#pragma checksum "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f045e927c845959761f98f0cd49ee2e49c3bcf6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Modules_Membership_Account_ForgotPassword_AccountForgotPassword_AdminLTE), @"mvc.1.0.view", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f045e927c845959761f98f0cd49ee2e49c3bcf6e", @"/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80744f0d30d3774e02a8d83691fd1a0c9313f33d", @"/Modules/_ViewImports.cshtml")]
    public class Modules_Membership_Account_ForgotPassword_AccountForgotPassword_AdminLTE : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
  
    ViewData["Title"] = Texts.Forms.Membership.ForgotPassword.FormTitle;
    ViewData["PageId"] = "ForgotPassword";
    ViewData["BodyClass"] = "login-page";
    Layout = MVC.Views.Shared._LayoutNoNavigation;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script id=""Template_Membership_ForgotPasswordPanel"" type=""text/template"">
    <div class=""s-Form"">
        <form id=""~_Form"" action="""">            
            <div id=""~_PropertyGrid""></div>
            <div class=""row"">
                <div class=""col-xs-9 col-xs-offset-3"">
                    <button id=""~_SubmitButton"" type=""submit"" class=""btn btn-primary btn-block btn-flat"">");
#nullable restore
#line 14 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
                                                                                                    Write(Texts.Forms.Membership.ForgotPassword.SubmitButton);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n                </div>\r\n            </div>\r\n        </form>\r\n    </div>    \r\n</script>\r\n\r\n<div class=\"login-box\">\r\n    <div class=\"login-logo\">\r\n        <b>");
#nullable restore
#line 23 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
      Write(Texts.Navigation.SiteTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n    </div>\r\n    <div class=\"login-box-body\">\r\n        <h3 class=\"page-title\">");
#nullable restore
#line 26 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
                          Write(Texts.Forms.Membership.ForgotPassword.FormTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n        <p class=\"login-box-msg\">");
#nullable restore
#line 27 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
                            Write(Texts.Forms.Membership.ForgotPassword.FormInfo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div id=\"ForgotPasswordPanel\">\r\n        </div>  \r\n        <a");
            BeginWriteAttribute("href", " href=\"", 1148, "\"", 1186, 1);
#nullable restore
#line 30 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
WriteAttributeValue("", 1155, Url.Content("~/Account/Login"), 1155, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">");
#nullable restore
#line 30 "C:\Users\esgrd\source\repos\VantagePoint.DK31.Dev\VantagePoint\VantagePoint.Web\Modules\Membership\Account\ForgotPassword\AccountForgotPassword.AdminLTE.cshtml"
                                                                 Write(Texts.Forms.Membership.ForgotPassword.BackToLogin);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
    </div>
</div>

<script type=""text/javascript"">
$(function() {
    new VantagePoint.Membership.ForgotPasswordPanel($('#ForgotPasswordPanel')).init();
    $('.field.Email').addClass(""has-icon"");
    $('.emaildomain').after(""<span class='glyphicon glyphicon-envelope form-control-feedback'></span>"");
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
