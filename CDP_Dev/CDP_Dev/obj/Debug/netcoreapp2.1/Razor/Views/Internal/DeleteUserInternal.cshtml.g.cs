#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c15cd8265db7ca7507b5ef36230b05176902b11d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Internal_DeleteUserInternal), @"mvc.1.0.view", @"/Views/Internal/DeleteUserInternal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Internal/DeleteUserInternal.cshtml", typeof(AspNetCore.Views_Internal_DeleteUserInternal))]
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
#line 1 "E:\git\repo\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev;

#line default
#line hidden
#line 2 "E:\git\repo\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c15cd8265db7ca7507b5ef36230b05176902b11d", @"/Views/Internal/DeleteUserInternal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Internal_DeleteUserInternal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CDP.Core.Internals.UserInternal>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UserInternal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUserInternal", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
  
    ViewData["Title"] = "DeleteUserInternal";

#line default
#line hidden
            BeginContext(96, 139, true);
            WriteLiteral("<h3>Are you sure you want to delete this User Internal?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(236, 38, false);
#line 11 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(274, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(318, 34, false);
#line 14 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(352, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(541, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(568, 40, false);
#line 23 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(608, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(652, 36, false);
#line 26 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(688, 17, true);
            WriteLiteral("\r\n        </dd>\r\n");
            EndContext();
            BeginContext(885, 26, true);
            WriteLiteral("        <dt>\r\n            ");
            EndContext();
            BeginContext(912, 41, false);
#line 35 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(953, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(997, 37, false);
#line 38 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(1034, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1078, 48, false);
#line 41 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingMode));

#line default
#line hidden
            EndContext();
            BeginContext(1126, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1170, 44, false);
#line 44 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.TrainingMode));

#line default
#line hidden
            EndContext();
            BeginContext(1214, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1258, 47, false);
#line 47 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1305, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1349, 43, false);
#line 50 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1392, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1436, 45, false);
#line 53 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1525, 41, false);
#line 56 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1566, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1610, 47, false);
#line 59 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1657, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1701, 43, false);
#line 62 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Internal\DeleteUserInternal.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1744, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1782, 299, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a6cc8ed853c4288a07f6872f11cdfa9", async() => {
                BeginContext(1820, 75, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n");
                EndContext();
                BeginContext(1954, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(1962, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "33f86558eb464fd58df13f43f023ae28", async() => {
                    BeginContext(2012, 52, true);
                    WriteLiteral("<span class=\"glyphicon glyphicon-arrow-left\"></span>");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2068, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2081, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CDP.Core.Internals.UserInternal> Html { get; private set; }
    }
}
#pragma warning restore 1591
