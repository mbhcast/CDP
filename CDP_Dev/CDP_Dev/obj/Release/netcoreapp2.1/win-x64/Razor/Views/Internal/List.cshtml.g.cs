#pragma checksum "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7617f70e76927d691f3093795fa83643cbfcf56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Internal_List), @"mvc.1.0.view", @"/Views/Internal/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Internal/List.cshtml", typeof(AspNetCore.Views_Internal_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7617f70e76927d691f3093795fa83643cbfcf56", @"/Views/Internal/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Internal_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CDP.Core.Internals.Internal>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml"
  
    ViewData["Title"] = "Allocation List";

#line default
#line hidden
            BeginContext(102, 429, true);
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

<h2>Internal List</h2>

<p>
    ");
            EndContext();
            BeginContext(531, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e4ecade5a5bb42fa9cbdbb5121234d8d", async() => {
                BeginContext(592, 10, true);
                WriteLiteral("Create New");
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
            BeginContext(606, 280, true);
            WriteLiteral(@"
</p>
<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(887, 38, false);
#line 22 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(925, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(957, 41, false);
#line 23 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.Topic));

#line default
#line hidden
            EndContext();
            BeginContext(998, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1030, 48, false);
#line 24 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.TrainingMode));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1110, 47, false);
#line 25 "E:\MBH\Projects\CDP_Dev\CDP_Dev\Views\Internal\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1157, 162, true);
            WriteLiteral("</th>\r\n                    <th>Edit</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(3368, 1790, true);
            WriteLiteral(@"
<script type=""text/javascript"">
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
            ""order"": [[ 1, ""asc"" ]],
            ""ajax"": {
                ""url"": ""/Internal/LoadInternalData"",
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""contentType"": ""application/j");
            WriteLiteral(@"son"",
            ""columns"": [
                { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                { ""data"": ""Topic"", ""name"": ""Topic"", ""autoWidth"": true },
                { ""data"": ""TrainingMode"", ""name"": ""TrainingMode"", ""autoWidth"": true },
                { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": true },
                {
                    ""render"": function (data, type, row) { return '<a class=""btn btn-warning"" href=""/Internal/Edit/' + row.Id + '"">Edit</a>'; }
                },
                {
                    ""render"": function (data, type, row) { return '<a class=""btn btn-danger"" href=""/Internal/Delete/' + row.Id + '"">Delete</a>'; }
                },
            ]
        });
    });
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CDP.Core.Internals.Internal>> Html { get; private set; }
    }
}
#pragma warning restore 1591