#pragma checksum "E:\git\repo\CDP_Dev\CDP_Dev\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee3e2cd6e96dd27a197fba36595bed1a8abaaa48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee3e2cd6e96dd27a197fba36595bed1a8abaaa48", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aaadf07ab9ea935f4720c4961260af0f372c3d8e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("UserId"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 1008, true);
            WriteLiteral(@"<script src=""https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js""></script>
<link href=""https://cdn.datatables.net/1.10.15/css/dataTables.bootstrap.min.css"" rel=""stylesheet"" />
<link href=""https://cdn.datatables.net/responsive/2.1.1/css/responsive.bootstrap.min.css"" rel=""stylesheet"" />
<style type=""text/css"">
    .glyphicon-plus-sign:before {
        color: #5cb85c;
    }

    .glyphicon-minus-sign:before {
        color: #d9534f
    }

    .list-group-item > .badge {
        background-color: #17a2b8
    }

    /*.dataTables_wrapper .form-control {
        font-size: 10px;
        height: 25px;
        font-weight: bold;
    }*/

    .pagination > li > a {
        padding: 0px 6px !important;
    }

    .treeview span.icon {
        font-size: 18px !important;
    }

    .list-group-item {
        padding: 5px 10px !important;
    }

    /*.table > thead > tr > th, .table > tbody > tr > td {
        padding: 6px !important;
    }*/
</style>
");
            EndContext();
            BeginContext(3712, 101, true);
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-6\">\r\n        <h2>Career Development Plan</h2>\r\n    </div>\r\n");
            EndContext();
            BeginContext(5964, 202, true);
            WriteLiteral("</div>\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <div class=\"container-fluid\">\r\n                <label class=\"control-label\"></label>\r\n                ");
            EndContext();
            BeginContext(6166, 113, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "27830c5b8d83491e9a889170e79e6a93", async() => {
                BeginContext(6269, 1, true);
                WriteLiteral(" ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#line 132 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(@ViewBag.UserList,"Id", "Name"));

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
            BeginContext(6279, 3241, true);
            WriteLiteral(@"
            </div>
        </div>
    </div>
    <br />
    <div class=""row"">
        <h4>Employee Detail</h4>
        <div class=""col-sm-12"">
            <div class=""container-fluid"">
                <table class=""table table-bordered"">
                    <thead>
                        <tr>
                            <th scope=""col"">Name</th>
                            <th scope=""col"">Trigram</th>
                            <th scope=""col"">Manager</th>
                            <th scope=""col"">Manager Trigram</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td id=""thName""></td>
                            <td id=""thTrigram""></td>
                            <td id=""thManager""></td>
                            <td id=""thManagerTrigram""></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    ");
            WriteLiteral(@"<div class=""row"">
        <h4>Aspiration</h4>
        <div class=""col-sm-12"">
            <table id=""aspiration"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Description</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
    <div class=""row"">
        <h4>Enablement</h4>
        <div class=""col-sm-12"">
            <div id=""treeview"" class=""container-fluid""></div>
        </div>
    </div>
    <div class=""row"">
        <h4>Mentor</h4>
        <div class=""col-sm-12"">
            <table id=""mentor"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Mentor</th>
                        <th>Training Category</th>
            ");
            WriteLiteral(@"            <th>Comment</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
    <div class=""row"">
        <h4>Allocation</h4>
        <div class=""col-sm-12"">
            <table id=""allocation"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Allocation</th>
                        <th>Comment</th>
                    </tr>
                </thead>
            </table>
        </div>
    </div>
    <div class=""row"">
        <h4>Internal</h4>
        <div class=""col-sm-12"">
            <table id=""internal"" class=""table table-striped table-bordered dt-responsive nowrap"" width=""100%"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Id</th>
                        <th>Topic</th>
                        <th>Training Mode</th>
           ");
            WriteLiteral("             <th>Comment</th>\r\n                    </tr>\r\n                </thead>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n");
            EndContext();
            BeginContext(9680, 51, true);
            WriteLiteral("        <a class=\"btn btn-default\" id=\"GeneratePDF\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 9731, "\"", 9793, 1);
#line 230 "E:\git\repo\CDP_Dev\CDP_Dev\Views\Home\Index.cshtml"
WriteAttributeValue("", 9738, Url.Action("CreateMigraDocPdf", "Home", new { id = 0}), 9738, 55, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9794, 5967, true);
            WriteLiteral(@" target=""_blank""><span style=""color:#ff0000"" class=""glyphicon glyphicon-file""></span> Generate PDF</a>
    </div>
</div>
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
        //var UserId = getUrlVars()[""UserId""];
        var UserId = localStorage.getItem(""UserId"");
        if (UserId != null) {
            $(""#UserId"").val(UserId);
            LoadAllData(UserId);
        }
        else {
            LoadAllData($(""#UserId"").val());
            setUserIdForLink($(""#UserId"").val());
        }

        $(""#GeneratePDF"").attr(""href"", ""/Home/CreateMigraDocPdf/"" + $(""#Use");
            WriteLiteral(@"rId"").val());
        
        $(""#UserId"").change(function () {
            var Id = $(""#UserId"").val();
            $(""#GeneratePDF"").attr(""href"", ""/Home/CreateMigraDocPdf/"" + Id);
            LoadAllData(Id);
            setUserIdForLink(Id);
        });

        function LoadAllData(Id) {
            $.ajax({
                url: '/Home/LoadTrainingData/' + Id
            }).done(function (data) {
                var tree = $('#treeview').treeview({
                    levels: 2,
                    highlightSelected: false,
                    showTags: true,
                    expandIcon: 'glyphicon glyphicon-plus-sign',
                    collapseIcon: 'glyphicon glyphicon-minus-sign',
                    //nodeIcon: ""glyphicon glyphicon-exclamation-sign"",
                    data: data.treedata
                });
            });

            $(""#aspiration"").DataTable({
                destroy: true,
                ""processing"": true,
                ""serverSide"": false,");
            WriteLiteral(@"
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Aspiration/LoadUserAspirationData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                    { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": true },
                ]
            });

            $(""#mentor"").DataTable({
                destroy: true,
                ""processing"": true,
                ""serverSide"": false,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Mentor/LoadUserMentorData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",");
            WriteLiteral(@"
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                    { ""data"": ""Mentor"", ""name"": ""Mentor"", ""autoWidth"": true },
                    { ""data"": ""TrainingCategory"", ""name"": ""TrainingCategory"", ""autoWidth"": true },
                    { ""data"": ""Comment"", ""name"": ""Comment"", ""autoWidth"": true }
                ]
            });

            $(""#allocation"").DataTable({
                destroy: true,
                ""processing"": true,
                ""serverSide"": false,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Allocation/LoadUserAllocationData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                ");
            WriteLiteral(@"    { ""data"": ""Allocation"", ""name"": ""Allocation"", ""autoWidth"": true },
                    { ""data"": ""Comment"", ""name"": ""Comment"", ""autoWidth"": true }
                ]
            });

            $(""#internal"").DataTable({
                destroy: true,
                ""processing"": true,
                ""serverSide"": false,
                ""filter"": true,
                ""orderMulti"": false,
                ""ajax"": {
                    ""url"": ""/Internal/LoadUserInternalData/"" + Id,
                    ""type"": ""POST"",
                    ""datatype"": ""json""
                },
                ""contentType"": ""application/json"",
                ""columns"": [
                    { ""data"": ""Id"", ""name"": ""Id"", ""autoWidth"": true, ""visible"": false },
                    { ""data"": ""Topic"", ""name"": ""Topic"", ""autoWidth"": true },
                    { ""data"": ""TrainingMode"", ""name"": ""TrainingMode"", ""autoWidth"": true },
                    { ""data"": ""Description"", ""name"": ""Description"", ""autoWidth"": ");
            WriteLiteral(@"true }
                ]
            });

            $.ajax({
                url: '/User/LoadUserData/' + Id
            }).done(function (data) {
                $(""#thName"").text(data.data.Name);
                $(""#thTrigram"").text(data.data.Trigram);
                $(""#thManager"").text(data.data.Manager);
                $(""#thManagerTrigram"").text(data.data.ManagerTrigram);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
