#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "526979b8c46b4519496e01e6ad5f56baf1ba023c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mentor_UserMentor), @"mvc.1.0.view", @"/Views/Mentor/UserMentor.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Mentor/UserMentor.cshtml", typeof(AspNetCore.Views_Mentor_UserMentor))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"526979b8c46b4519496e01e6ad5f56baf1ba023c", @"/Views/Mentor/UserMentor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Mentor_UserMentor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CDP.Core.Mentors.UserMentor>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(49, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
  
    ViewData["Title"] = "User Mentor";

#line default
#line hidden
            BeginContext(98, 341, true);
            WriteLiteral(@"
<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />

<h2>User Mentor</h2>

<p>
    ");
            EndContext();
            BeginContext(439, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d97e8d664204b62a4965ea0a9d64162", async() => {
                BeginContext(500, 10, true);
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
            BeginContext(514, 152, true);
            WriteLiteral("\r\n</p>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        <div class=\"form-group\">\r\n            <label class=\"control-label\"></label>\r\n            ");
            EndContext();
            BeginContext(666, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c420639839804df5a52d761ddd5819bc", async() => {
                BeginContext(776, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#line 20 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
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
            BeginContext(786, 310, true);
            WriteLiteral(@"
        </div>
    </div>
</div>
<div class=""container"">
    <br />
    <div style=""width:90%; margin:0 auto;"">
        <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
            <thead>
                <tr>
                    <th>");
            EndContext();
            BeginContext(1097, 38, false);
#line 30 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
                   Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(1135, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1167, 42, false);
#line 31 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
                   Write(Html.DisplayNameFor(model => model.Mentor));

#line default
#line hidden
            EndContext();
            BeginContext(1209, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1241, 52, false);
#line 32 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
                   Write(Html.DisplayNameFor(model => model.TrainingCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1293, 31, true);
            WriteLiteral("</th>\r\n                    <th>");
            EndContext();
            BeginContext(1325, 43, false);
#line 33 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Mentor\UserMentor.cshtml"
                   Write(Html.DisplayNameFor(model => model.Comment));

#line default
#line hidden
            EndContext();
            BeginContext(1368, 162, true);
            WriteLiteral("</th>\r\n                    <th>Edit</th>\r\n                    <th>Delete</th>\r\n                </tr>\r\n            </thead>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
            EndContext();
            BeginContext(4529, 2918, true);
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
            $(""#Create"").attr(""href"", Createhref + ""?UserId="" + UserId);
        }
        LoadData($(""#UserId"").val());
        $(""#UserId"").change(function () {
            var Id = $(""#UserId"").val();
            $(""#Create"").attr(""href"", Createhref + ""?UserId="" + Id);
            ");
            WriteLiteral(@"LoadData(Id);
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
                    ""url"": ""/Mentor/LoadUserMentorData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                    { ""data"": ""Mentor"", ""name"": ""Mentor"", ""autoWidth"": true },
                    { ""data"": ""TrainingCategory"", ""name"": ""TrainingCategory"", ""autoWidth"": true },
                    { ""data"": ""Comment"", ""name"": ""Comment"", ""autoWidth"": true },
                    {
                      ");
            WriteLiteral(@"  ""render"": function (data, type, row) { return '<a class=""btn btn-warning"" href=""/Mentor/EditUserMentor/' + row.Id + '?UserId=' + $(""#UserId"").val() + '"">Edit</a>'; }
                    },
                    {
                        ""render"": function (data, type, row) { return '<a class=""btn btn-danger"" href=""/Mentor/DeleteUserMentor/' + row.Id + '"">Delete</a>'; }
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
            return vars;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CDP.Core.Mentors.UserMentor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
