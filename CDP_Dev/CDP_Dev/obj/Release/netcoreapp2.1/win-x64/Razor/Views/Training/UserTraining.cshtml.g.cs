#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a9825cb7bda44af4905b636094615f7c6d9cabf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Training_UserTraining), @"mvc.1.0.view", @"/Views/Training/UserTraining.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Training/UserTraining.cshtml", typeof(AspNetCore.Views_Training_UserTraining))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a9825cb7bda44af4905b636094615f7c6d9cabf", @"/Views/Training/UserTraining.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Training_UserTraining : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CDP.Core.Training.UserTraining>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TrainingList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("Create"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateUserTraining", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-bottom: 29px;color:white;font-size:20px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
  
    ViewData["Title"] = "User Training";

#line default
#line hidden
            BeginContext(103, 306, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />
");
            EndContext();
            BeginContext(505, 31, true);
            WriteLiteral("<h3>User Training</h3>\r\n\r\n<p>\r\n");
            EndContext();
            BeginContext(697, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(701, 146, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf7f4d590ccf41468f277c42b6ae9191", async() => {
                BeginContext(765, 78, true);
                WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-list\"></span> Training Master\r\n    ");
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
            BeginContext(847, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(853, 141, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "673d6ac9860842de887893f499d7d918", async() => {
                BeginContext(910, 80, true);
                WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-list\"></span> Training Category\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(994, 56, true);
            WriteLiteral("\r\n</p>\r\n<div id=\"goToTop\" style=\"display: block;\">\r\n    ");
            EndContext();
            BeginContext(1050, 180, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "400586ac31364540bb111ceee1dc9cda", async() => {
                BeginContext(1164, 62, true);
                WriteLiteral("\r\n        <span class=\"glyphicon glyphicon-plus\"></span>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1230, 167, true);
            WriteLiteral("\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n            <div class=\"form-group\">\r\n                <label  class=\"control-label\"></label>\r\n                ");
            EndContext();
            BeginContext(1397, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16fac62cc2aa49b7bb624b6700f93a91", async() => {
                BeginContext(1507, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
#line 37 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.UserList,"Id", "DisplayName"));

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1517, 303, true);
            WriteLiteral(@"
            </div>
    </div>
</div>
<div class=""container"">
    <br />
    <div style=""margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(1821, 38, false);
#line 47 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 7, true);
            WriteLiteral("</th>\r\n");
            EndContext();
            BeginContext(1942, 24, true);
            WriteLiteral("                    <th>");
            EndContext();
            BeginContext(1967, 44, false);
#line 49 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
                   Write(Html.DisplayNameFor(model => model.Training));

#line default
#line hidden
            EndContext();
            BeginContext(2011, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(2043, 52, false);
#line 50 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
                   Write(Html.DisplayNameFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(2095, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(2127, 44, false);
#line 51 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Training\UserTraining.cshtml"
                   Write(Html.DisplayNameFor(model => model.Priority));

#line default
#line hidden
            EndContext();
            BeginContext(2171, 164, true);
            WriteLiteral("</th>\r\n                    <th>Edit</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(4387, 3102, true);
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
        var Createhref = $(""#Create"").attr(""href"");
        //var UserId = getUrlVars()[""UserId""];
        var UserId = localStorage.getItem(""UserId"");
        //alert(UserId);
        if (UserId != null) {
            $(""#UserId"").val(UserId);
            //$(""#Create"").attr(""href"", Createhref + ""?UserId="" + UserId);
        }
        LoadData($(""#UserId"").val());
        $(""#UserId"").change(function() {
            var Id = $(""#UserId"").val();
            //$(""#Create"").attr(""href"", Createhref + ""?UserId="" + Id);
         ");
            WriteLiteral(@"   LoadData(Id);
            setUserIdForLink(Id);
        });

        function LoadData(Id) {
            $(""#example"").DataTable({
                destroy: true,
                ""processing"": true, 
                ""serverSide"": false,
                ""filter"": true,
                ""orderMulti"": false,
                ""order"": [[ 1, ""asc"" ]],
                ""ajax"": {
                    ""url"": ""/Training/LoadUserTrainingData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                    //{ ""data"": ""User"", ""name"": ""User"", ""autoWidth"": true },
                    { ""data"": ""Training"", ""name"": ""Training"", ""autoWidth"": true },
                    { ""data"": ""TrainingCategory"", ""name"": ""TrainingCategory"", ""autoWidth"": true },
                    { ""data"": ""Priori");
            WriteLiteral(@"ty"", ""name"": ""Priority"", ""autoWidth"": true },
                    {
                        ""render"": function (data, type, row) { return '<a class=""btn btn-warning"" href=""/Training/EditUserTraining/' + row.Id + '?UserId=' + $(""#UserId"").val() + '""><span class=""glyphicon glyphicon-edit""></span></a>'; }
                    },
                    {
                        ""render"": function (data, type, row) { return '<a class=""btn btn-danger"" href=""/Training/DeleteUserTraining/' + row.Id + '""><span class=""glyphicon glyphicon-remove""></span></a>'; }
                    },
                ]
            });
        }

        function getUrlVars() {
            var vars = [], hash;
            var hashes = window.location.href.slice(window.location.href.indexOf('?') + 1).split('&');
            for (var i = 0; i < hashes.length; i++) {
                hash = hashes[i].split('=');
                vars.push(hash[0]);
                vars[hash[0]] = hash[1];
            }
            return vars;");
            WriteLiteral("\n        }\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CDP.Core.Training.UserTraining>> Html { get; private set; }
    }
}
#pragma warning restore 1591
