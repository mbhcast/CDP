#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85acb7f7e796a0938fbfab9a6a0f609687a7ab48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_TrainingList), @"mvc.1.0.view", @"/Views/Training/TrainingList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/TrainingList.cshtml", typeof(AspNetCore.Views_Training_TrainingList))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85acb7f7e796a0938fbfab9a6a0f609687a7ab48", @"/Views/Training/TrainingList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_TrainingList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CDP.Core.Training.TrainingMaster>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateTrainingMaster", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
  
    ViewData["Title"] = "Training List";

#line default
#line hidden
            BeginContext(105, 306, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />
");
            EndContext();
            BeginContext(506, 35, true);
            WriteLiteral("<h3>Training List</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(541, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e8143c15e25b4b4686ae5af371e69d65", async() => {
                BeginContext(616, 62, true);
                WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-plus\"></span>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(682, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(688, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "331907d52bb94659bbf5cb7bf8fac2ef", async() => {
                BeginContext(745, 80, true);
                WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-list\"></span> Training Category\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(829, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1153, 267, true);
            WriteLiteral(@"</p>
<div class=""container"">
    <br />
    <div style=""margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(1421, 38, false);
#line 37 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1491, 40, false);
#line 38 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.Code));

#line default
#line hidden
            EndContext();
            BeginContext(1531, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1563, 40, false);
#line 39 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1603, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1635, 52, false);
#line 40 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1687, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1719, 47, false);
#line 41 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1766, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1798, 39, false);
#line 42 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.TOC));

#line default
#line hidden
            EndContext();
            BeginContext(1837, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1869, 46, false);
#line 43 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\TrainingList.cshtml"
                   Write(Html.DisplayNameFor(model => model.IsExternal));

#line default
#line hidden
            EndContext();
            BeginContext(1915, 162, true);
            WriteLiteral("</th>\r\n                    <th>Edit</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(4179, 2209, true);
            WriteLiteral(@"<script type=""text/javascript"">
    $(document).ready(function () {
        $(document).ajaxStart(function () {
            $(""#wait"").css(""display"", ""block"");
        });
        $(document).ajaxError(function () {
            $(""#wait"").css(""display"", ""none"");
        });
        $(document).ajaxComplete(function () {
            $(""#wait"").css(""display"", ""none"");
        });
    });
</script>
<script type=""text/javascript"">
    $(document).ready(function () {
        $(""#example"").DataTable({
            ""processing"": true, // for show progress bar
            ""serverSide"": false, // for process server side
            ""filter"": true, // this is for disable filter (search box)
            ""orderMulti"": false, // for disable multiple column at once
            ""order"": [[ 2, ""asc"" ]],
            ""ajax"": {
                ""url"": ""/Training/LoadTrainingMasterData/0"",
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""contentType"": ""applica");
            WriteLiteral(@"tion/json"",
            ""columns"": [
                { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                { ""data"": ""Code"", ""name"": ""Code"", ""autoWidth"": true },
                { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth"": true },
                { ""data"": ""TrainingCategory"", ""name"": ""TrainingCategory"", ""autoWidth"": true },
                { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": true },
                { ""data"": ""TOC"", ""name"": ""TOC"", ""autoWidth"": true },
                { ""data"": ""IsExternal"", ""name"": ""IsExternal"", ""autoWidth"": true },
                {  
                        ""render"": function (data, type, row)  
                        { return '<a class=""btn btn-warning"" href=""/Training/EditTrainingMaster/' + row.Id + '""><span class=""glyphicon glyphicon-edit""></span></a>'; }  
                },
                {  
                        ""render"": function (data, type, row)  
                        { return '<a class=""btn btn-danger"" href=""/Training/D");
            WriteLiteral("eleteTrainingMaster/\' + row.Id + \'\"><span class=\"glyphicon glyphicon-remove\"></span></a>\'; }\r\n                }, \r\n            ]\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CDP.Core.Training.TrainingMaster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
