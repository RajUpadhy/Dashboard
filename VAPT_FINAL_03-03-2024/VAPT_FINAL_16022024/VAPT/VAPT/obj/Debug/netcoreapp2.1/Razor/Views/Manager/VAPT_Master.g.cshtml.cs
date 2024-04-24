#pragma checksum "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\VAPT_Master.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "489f98d1908fe207835ecc195fc6ff134a8dab42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_VAPT_Master), @"mvc.1.0.view", @"/Views/Manager/VAPT_Master.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/VAPT_Master.cshtml", typeof(AspNetCore.Views_Manager_VAPT_Master))]
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
#line 1 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\_ViewImports.cshtml"
using VAPT;

#line default
#line hidden
#line 2 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\_ViewImports.cshtml"
using VAPT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"489f98d1908fe207835ecc195fc6ff134a8dab42", @"/Views/Manager/VAPT_Master.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0334c3eb54015b993c2da8df0e4497ff8e9d9e25", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_VAPT_Master : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onload", new global::Microsoft.AspNetCore.Html.HtmlString("getTable()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\VAPT_Master.cshtml"
  
    ViewData["Title"] = "VAPT_Master";
    Layout = "~/Views/Manager/masterpage.cshtml";

#line default
#line hidden
            BeginContext(100, 10695, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc0684c010894631851654c3be9a7a85", async() => {
                BeginContext(126, 3040, true);
                WriteLiteral(@"
    <div class=""page-wrapper"">
        <div class=""content container-fluid"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <h2>Vulnerability Master</h2>
                </div>
            </div>
            <div id=""activecontent"">
                <div class=""card p-3 tcard"">
                    <div class=""row"">
                        <div class=""col-sm-12 col-lg-8"">
                            <div class=""row"">
                                <div class=""col-sm-4  mt-1"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm dropdown-toggle col-sm-12"" style=""overflow:hidden"" href=""#"" role=""button"" id=""VAPT_MGR_VAMST_SEL01"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            Vulnerabality Name
                                        </a>
                                        <ul class=""dropdown-menu"" aria-labelledby=""VAPT_MGR_VAMST_SEL01"">");
                WriteLiteral(@"
                                            <li><a class=""dropdown-item"" href=""#"">http-enum</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">http-sql-injection</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">mysql-enum</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-sm-4   mt-1"">
                                    <div class=""dropdown"">
                                        <a class=""btn btn-sm dropdown-toggle col-sm-12 "" style=""overflow:hidden"" href=""#"" role=""button"" id=""VAPT_MGR_VAMST_SEL02"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                            Vulnerabality Type
                                        </a>
                                        <ul class=""dropdown-menu"" aria-labelledby=""VAPT_MGR_VAMST_SEL02"">
                        ");
                WriteLiteral(@"                    <li><a class=""dropdown-item"" href=""#"">Website Scanning</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">penetration testing</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">Vulnerability scanning</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">Compliance</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">Threat detection</a></li>
                                            <li><a class=""dropdown-item"" href=""#"">Database detection</a></li>
                                        </ul>
                                    </div>
                                </div>
                                <div class=""col-sm-4  mt-1"">
                                    <div class=""button"">
                                        <button class=""btn btn-sm"" id=""VAPT_MGR_VAMST_B01"">Search</button>");
                EndContext();
                BeginContext(3195, 366, true);
                WriteLiteral(@"
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>

                    <div class=""row"">
                        <div class=""col-sm-12"">
                            <div id=""VAPT_MGR_MST_D01_Parent"" class=""table-responsive mt-4"">
");
                EndContext();
                BeginContext(7750, 168, true);
                WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
                BeginContext(7992, 1150, true);
                WriteLiteral(@"    <div class=""modal"" tabindex=""1"" role=""dialog"" data-bs-backdrop=""static"" id=""VAPT_MGR_VAMST_M01"">
        <div class=""modal-dialog modal-lg"" role=""document"" >
            <div class=""modal-content"">
                <div class=""modal-body"">
                    <div class=""container-fluid"">
                        <div class=""row"">
                            <div class=""col-sm-6"">
                                <h3>Details</h3>
                            </div>
                            <div class=""col-sm-6 text-end"">
                                <button type=""button"" class=""btn-close"" data-bs-dismiss=""modal"" aria-label=""Close"" id=""VAPT_MGR_VAMST_M01""></button>
                            </div>
                        </div>
                        <div id=""activecontent"">
                            <div class=""card tcard"">
                                <div class=""card-body"">
                                    <div class=""row"">
                                        <div class");
                WriteLiteral("=\"col-sm-12\">\r\n                                            <div class=\"table-responsive\" id=\"VAPT_MGR_VAMST_M01_T01_Parent\">\r\n");
                EndContext();
                BeginContext(10436, 352, true);
                WriteLiteral(@"                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10795, 1638, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#VAPT_MGR_VAMST_T01').DataTable();
        $('#VAPT_MGR_VAMST_M01_T01').DataTable();
    });

</script>
<script>
    function getTable() {
        var jsonData = `{""data"":[{""Vul. Name"":""mysql-enum"",""Vul. External Reference"":""https://roxsd.com"",""Vul. Type"":""Penetration Testing"",""Vul. Description"":""Performs valid-user enumeration against MySQL server using a bug discovered"",""Vul. Classifier"":""-"",""Severity"":""high"",""Info"":""""}]}`
        var tbdata = JSON.parse(jsonData).data;
        var disArry = [];
        // if true
        //modifiedTable('VAPT_MGR_TM_T01_Parent', 'VAPT_MGR_TM_T01', tbdata, disArry, 4, true);
        //other
        modifiedTable('VAPT_MGR_MST_D01_Parent', 'VAPT_MGR_VAMST_T01', tbdata, disArry, 4, false);
        customTable_01(disArry, 4, 'VAPT_MGR_VAMST_T01');
    };

    function customTable_01(dtHide, pgLength, chid) {
        const tablName = document.getElementById(chid);
        $(tablName).DataTable({
   ");
            WriteLiteral(@"         pageLength: pgLength,
            ""aoColumnDefs"": [
                { ""bSearchable"": false, ""bVisible"": false, ""aTargets"": dtHide },
                //{ ""bVisible"": false, ""aTargets"": [3] }
                {
                    ""targets"": 6, ""render"": function (data, type, row) {
                        var detailsview = '<button class=""btn btn-sm btn-primary"" data-bs-toggle=""modal"" data-bs-target=""#VAPT_MGR_VAMST_M01"" onclick=""getTable_01()"">View</button>';
                        return detailsview
                    }
                }
            ],

        });
    }
</script>
");
            EndContext();
            BeginContext(12454, 607, true);
            WriteLiteral(@"<script>
    function getTable_01() {
        var jsonData = `{""data"":[{""Parameter"":""mysql-enum"",""Value"":""https://roxsd.com""},{""Parameter"":""mysql-enum"",""Value"":""https://roxsd.com""}]}`
        var tbdata = JSON.parse(jsonData).data;
        var disArry = [];
        // if true
        modifiedTable('VAPT_MGR_VAMST_M01_T01_Parent', 'VAPT_MGR_VAMST_M01_T01', tbdata, disArry, 4, true);
        //other
       // modifiedTable('VAPT_MGR_VAMST_M01_T01_Parent', 'VAPT_MGR_VAMST_M01_T01', tbdata, disArry, 4, false);
        //customTable_01(disArry, 4, 'VAPT_MGR_VAMST_M01_T01');
    };
</script>

");
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
