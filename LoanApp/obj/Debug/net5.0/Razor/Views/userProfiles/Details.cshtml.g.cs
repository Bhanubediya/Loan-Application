#pragma checksum "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b3d4b75542f7ef246b3f2a17099cb69354347f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_userProfiles_Details), @"mvc.1.0.view", @"/Views/userProfiles/Details.cshtml")]
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
#line 1 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\_ViewImports.cshtml"
using LoanApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\_ViewImports.cshtml"
using LoanApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b3d4b75542f7ef246b3f2a17099cb69354347f4", @"/Views/userProfiles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db2c20013ea6631cfd83b7909f86767482856a1b", @"/Views/_ViewImports.cshtml")]
    public class Views_userProfiles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LoanApp.Models.userProfile>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Details</h1>




<div class=""table-responsive-lg"">
    <table class=""table table-striped table-hover table-bordered border-light w-auto"">
        <thead class=""bg-dark text-light "">
            <tr>
                <th>
                    ");
#nullable restore
#line 18 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 24 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 30 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 33 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.idProof));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.loanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 39 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Loans));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 42 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Tenure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 45 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 48 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 51 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.loginId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\" \" >\r\n\r\n            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 59 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.firstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.lastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.dateOfBirth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.occupation));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.income));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.idProof));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 77 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.loanAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 80 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.Loans.loanType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 83 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.Tenure.months));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 86 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n");
#nullable restore
#line 88 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                 if (Model.Status.statusId == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-warning\">\r\n                        ");
#nullable restore
#line 91 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Status.loanStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 93 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                }
                else if (Model.Status.statusId == 2)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-success\">\r\n                        ");
#nullable restore
#line 97 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Status.loanStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 99 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                }
                else if (Model.Status.statusId == 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-danger\">\r\n                        ");
#nullable restore
#line 103 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                   Write(Html.DisplayFor(model => model.Status.loanStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 105 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\r\n                    ");
#nullable restore
#line 107 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
               Write(Html.DisplayFor(model => model.loginId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 115 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
     if (User.IsInRole(Utility.WC.AdminRole)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3d4b75542f7ef246b3f2a17099cb69354347f414381", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                           WriteLiteral(Model.profileId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" ");
#nullable restore
#line 116 "C:\Users\Bhanu\source\repos\LoanApp\LoanApp\Views\userProfiles\Details.cshtml"
                                                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("    |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b3d4b75542f7ef246b3f2a17099cb69354347f416794", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LoanApp.Models.userProfile> Html { get; private set; }
    }
}
#pragma warning restore 1591
