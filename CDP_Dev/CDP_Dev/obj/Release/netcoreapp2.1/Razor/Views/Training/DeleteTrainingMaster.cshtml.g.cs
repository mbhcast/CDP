#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b811f6d766ac8768eaf5bb85ada7ec661b19556d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_DeleteTrainingMaster), @"mvc.1.0.view", @"/Views/Training/DeleteTrainingMaster.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/DeleteTrainingMaster.cshtml", typeof(AspNetCore.Views_Training_DeleteTrainingMaster))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b811f6d766ac8768eaf5bb85ada7ec661b19556d", @"/Views/Training/DeleteTrainingMaster.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_DeleteTrainingMaster : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CDP.Core.Training.TrainingMaster>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TrainingList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteTrainingMaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(41, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
  
    ViewData["Title"] = "Delete Training Master";

#line default
#line hidden
            BeginContext(101, 162, true);
            WriteLiteral("\r\n<h3>Delete Training Master</h3>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(264, 38, false);
#line 14 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(302, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(346, 34, false);
#line 17 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(380, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(424, 40, false);
#line 20 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(464, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(508, 36, false);
#line 23 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(544, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(588, 40, false);
#line 26 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 36, false);
#line 29 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(752, 54, false);
#line 32 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingCategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(806, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(850, 50, false);
#line 35 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.TrainingCategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(900, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(944, 52, false);
#line 38 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(996, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1040, 48, false);
#line 41 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1088, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1132, 47, false);
#line 44 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1179, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1223, 43, false);
#line 47 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1310, 39, false);
#line 50 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.TOC));

#line default
#line hidden
            EndContext();
            BeginContext(1349, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1393, 35, false);
#line 53 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.TOC));

#line default
#line hidden
            EndContext();
            BeginContext(1428, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1472, 46, false);
#line 56 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.IsExternal));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1562, 42, false);
#line 59 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.IsExternal));

#line default
#line hidden
            EndContext();
            BeginContext(1604, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1648, 45, false);
#line 62 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1737, 41, false);
#line 65 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.CreatedOn));

#line default
#line hidden
            EndContext();
            BeginContext(1778, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1822, 47, false);
#line 68 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayNameFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1869, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1913, 43, false);
#line 71 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\DeleteTrainingMaster.cshtml"
       Write(Html.DisplayFor(model => model.LastUpdated));

#line default
#line hidden
            EndContext();
            BeginContext(1956, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1994, 301, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e2d6584dca544459dcb3b6daed48f4c", async() => {
                BeginContext(2034, 75, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n");
                EndContext();
                BeginContext(2168, 8, true);
                WriteLiteral("        ");
                EndContext();
                BeginContext(2176, 106, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "809a42d97ccb48c283f411cf74c0838a", async() => {
                    BeginContext(2226, 52, true);
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
                BeginContext(2282, 6, true);
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
            BeginContext(2295, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CDP.Core.Training.TrainingMaster> Html { get; private set; }
    }
}
#pragma warning restore 1591
