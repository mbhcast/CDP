#pragma checksum "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\Allocation\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0f97d9f390311bbab3741074e128de62615b4fa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Allocation_List), @"mvc.1.0.view", @"/Views/Allocation/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Allocation/List.cshtml", typeof(AspNetCore.Views_Allocation_List))]
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
#line 1 "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev;

#line default
#line hidden
#line 2 "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\_ViewImports.cshtml"
using CDP_Dev.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0f97d9f390311bbab3741074e128de62615b4fa", @"/Views/Allocation/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Allocation_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CDP.Core.Allocations.Allocation>>
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
            BeginContext(53, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\Allocation\List.cshtml"
  
    ViewData["Title"] = "Allocation List";

#line default
#line hidden
            BeginContext(106, 431, true);
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<script src=""https://cdn.datatables.net/1.10.15/js/jquery.dataTables.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

<h2>Allocation List</h2>

<p>
    ");
            EndContext();
            BeginContext(537, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6bd2406d24574abd801be2909b047728", async() => {
                BeginContext(598, 10, true);
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
            BeginContext(612, 280, true);
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
            BeginContext(893, 38, false);
#line 22 "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\Allocation\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(931, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(963, 40, false);
#line 23 "C:\Users\MBH\source\repos\CDP_Dev\CDP_Dev\Views\Allocation\List.cshtml"
                   Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1003, 162, true);
            WriteLiteral("</th>\r\n                    <th>Edit</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(2560, 1582, true);
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
            ""ajax"": {
                ""url"": ""/Allocation/LoadAllocationData"",
                ""type"": ""POST"",
                ""datatype"": ""json""
            },
            ""contentType"": ""application/json"",
            ""columns"": [
   ");
            WriteLiteral(@"             { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true },
                { ""data"": ""Name"", ""name"": ""Name"", ""autoWidth"": true },
                {
                    ""render"": function (data, type, row) { return '<a class=""btn btn-warning"" href=""/Allocation/Edit/' + row.Id + '"">Edit</a>'; }
                },
                {
                    ""render"": function (data, type, row) { return '<a class=""btn btn-danger"" href=""/Allocation/Delete/' + row.Id + '"">Delete</a>'; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CDP.Core.Allocations.Allocation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
