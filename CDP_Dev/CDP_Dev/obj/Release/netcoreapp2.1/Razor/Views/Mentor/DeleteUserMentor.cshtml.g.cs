#pragma checksum "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8f8bc00ced0ddbef23f1b6d7270b466c72bb1d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mentor_DeleteUserMentor), @"mvc.1.0.view", @"/Views/Mentor/DeleteUserMentor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mentor/DeleteUserMentor.cshtml", typeof(AspNetCore.Views_Mentor_DeleteUserMentor))]
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
#line 1 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev;

#line default
#line hidden
#line 2 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8f8bc00ced0ddbef23f1b6d7270b466c72bb1d5", @"/Views/Mentor/DeleteUserMentor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Mentor_DeleteUserMentor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CDP.Core.Mentors.UserMentor>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserMentor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUserMentor", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
  
    ViewData["Title"] = "Delete User Mentor";

#line default
#line hidden
            BeginContext(92, 132, true);
            WriteLiteral("<h3>Are you sure you want to delete this Mentor?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 38, false);
#line 11 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(263, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(307, 34, false);
#line 14 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(341, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(530, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(557, 40, false);
#line 23 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(597, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(641, 36, false);
#line 26 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(677, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(870, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(897, 42, false);
#line 35 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.Mentor));

#line default
#line hidden
            EndContext();
            BeginContext(939, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(983, 38, false);
#line 38 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.Mentor));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(1234, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(1261, 52, false);
#line 47 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1313, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1357, 48, false);
#line 50 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1405, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1449, 43, false);
#line 53 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1492, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1536, 39, false);
#line 56 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1575, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1619, 45, false);
#line 59 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1664, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1708, 41, false);
#line 62 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1749, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1793, 47, false);
#line 65 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1840, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1884, 43, false);
#line 68 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Mentor\DeleteUserMentor.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1965, 175, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d284aefe1f649c39e4f440106669752", async() => {
                BeginContext(2001, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2084, 43, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c71dccfa751b42bd943ce02ad4b8a098", async() => {
                    BeginContext(2111, 12, true);
                    WriteLiteral("Back to List");
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
                BeginContext(2127, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2140, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CDP.Core.Mentors.UserMentor> Html { get; private set; }
    }
}
#pragma warning restore 1591
