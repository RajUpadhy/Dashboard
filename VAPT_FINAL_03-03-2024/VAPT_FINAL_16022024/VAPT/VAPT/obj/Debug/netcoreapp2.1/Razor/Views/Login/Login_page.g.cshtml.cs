#pragma checksum "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Login\Login_page.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b03eb36cea62fb9332bfc12c4fd3c8fca4a1afad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Login_page), @"mvc.1.0.view", @"/Views/Login/Login_page.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Login/Login_page.cshtml", typeof(AspNetCore.Views_Login_Login_page))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b03eb36cea62fb9332bfc12c4fd3c8fca4a1afad", @"/Views/Login/Login_page.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0334c3eb54015b993c2da8df0e4497ff8e9d9e25", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Login_page : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Operator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Manager", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" mx-1 mx-md-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("loginForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Login\Login_page.cshtml"
  
    ViewData["Title"] = "Login_page";
    Layout = "~/Views/Login/login_MasterPage.cshtml";

#line default
#line hidden
            BeginContext(103, 921, true);
            WriteLiteral(@"

<style>
    .input-group {
        position: relative;
    }

    .password-toggle {
        position: absolute;
        top: 7px;
        right: 10px;
        cursor: pointer;
    }

    .main_form {
        border-radius: 20px;
        background-color: rgb(216 225 249 / 38%);
    }

    .image-div {
        background-size: cover;
        background-repeat: no-repeat;
        transform: scale(1.1)
    }

    .main {
        position: absolute;
        top: 50%;
        left: 50%;
        transform: translate(-50%, -50%);
    }

    i.fa-solid.fa-chevron-down {
        position: absolute;
        top: 50%;
        right: 17px;
        color: black;
        transform: translateY(-50%);
    }

    .icon {
        min-width: 30px;
        margin: 10px 00px;
        color: black;
        position: absolute;
        top: 0px;
        right: 0px;
    }
</style>
");
            EndContext();
            BeginContext(1024, 2687, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac608bfc6bd746b1bbdd22ba103769de", async() => {
                BeginContext(1030, 357, true);
                WriteLiteral(@"
    <div class=""container main"">
        <div class=""row "">
            <div class=""col-12"">
                <div class=""row justify-content-center align-items-center py-5 "">
                    <div class=""main_form col-lg-4 col-7 "">
                        <p class=""text-center h2 fw-bold mb-4 mx-1 mx-4 mt-4"">Sign In</p>
                        ");
                EndContext();
                BeginContext(1387, 2215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b4a3a3f696a141e2aab609fc6f7f13e4", async() => {
                    BeginContext(1430, 1345, true);
                    WriteLiteral(@"
                            <div class=""d-flex flex-row align-items-center mb-5"">
                                <div class=""form-outline flex-fill mb-0"">
                                    <input type=""text"" id=""Username"" class=""form-control shadow-none""
                                           placeholder=""User Name"" />
                                </div>
                            </div>
                            <div class=""d-flex flex-row align-items-center mb-5 input-group position-relative"">
                                <div class=""form-outline flex-fill mb-0"">
                                    <input type=""password"" id=""Password"" class=""form-control shadow-none""
                                           placeholder=""Password"" />
                                    <i class=""fa-regular fa-eye icon "" id=""hide"" style=""display: none;""></i>
                                    <i class=""fa-regular fa-eye-slash icon"" id=""show""></i>
                                </div>
       ");
                    WriteLiteral(@"                     </div>
                            <div class=""d-flex flex-row align-items-center mb-5"">
                                <div class=""form-outline flex-fill mb-0"">
                                    <select id=""SelectType"" class=""form-select shadow-none"">
                                        ");
                    EndContext();
                    BeginContext(2775, 46, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e6107556cc44f40ae56eaf670258979", async() => {
                        BeginContext(2801, 11, true);
                        WriteLiteral("Select Type");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2821, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(2863, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "978374f31d044425bbd368579e4c528e", async() => {
                        BeginContext(2885, 5, true);
                        WriteLiteral("Admin");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2899, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(2941, 42, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2855b90a60534855a499a295e52617f5", async() => {
                        BeginContext(2966, 8, true);
                        WriteLiteral("Operator");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2983, 42, true);
                    WriteLiteral("\r\n                                        ");
                    EndContext();
                    BeginContext(3025, 40, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef9444afac4d4dc0ba107d9ffa8aba9e", async() => {
                        BeginContext(3049, 7, true);
                        WriteLiteral("Manager");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(3065, 530, true);
                    WriteLiteral(@"
                                    </select>
                                </div>
                            </div>
                            <div class="" justify-content-center text-center  mb-3 mb-lg-4"">
                                <button type=""submit"" class=""btn btn-primary px-md-5 px-sm-4""
                                        style=""border-radius: 20px;"">
                                    LogIn
                                </button>
                            </div>
                        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3602, 102, true);
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3711, 1201, true);
            WriteLiteral(@"
<script>
    $(document).ready(function () {
        $('#show').click(function () {
            $(""#Password"").attr('type', 'text');
            $(""#show"").hide();
            $(""#hide"").show();
        });
        $('#hide').click(function () {
            $(""#Password"").attr('type', 'password');
            $(""#hide"").hide();
            $(""#show"").show();
        });
    });
</script>


<script>
    $(document).ready(function () {
        $('#loginForm').submit(function (e) {
            e.preventDefault();
            //var Applicationid = $('#sapp :selected').text();
            //var role = $('#form3Example4cd').val();
            //var roletext = $('#sutype :selected').text();
            //var datas = {
            //    Username: $('#Username').val(),
            //    Password: $('#pass').val(),
            //    Roll: $('#SelectType').val(),
            //}

            if ($('#Username').val() === 'admin' && $('#Password').val() == 'admin@123' && $('#SelectType').val");
            WriteLiteral("() ==\'Admin\') {\r\n                //document.getElementById(\'MessageText\').innerText = res;\r\n                $(\"#loginForm\")[0].reset();\r\n                window.location.href = \'");
            EndContext();
            BeginContext(4913, 32, false);
#line 132 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Login\Login_page.cshtml"
                                   Write(Url.Content("~/Admin/indexpage"));

#line default
#line hidden
            EndContext();
            BeginContext(4945, 309, true);
            WriteLiteral(@"';
            } else if ($('#Username').val() === 'operator' && $('#Password').val() == 'operator@123' && $('#SelectType').val() == 'Operator') {
                //document.getElementById('MessageText').innerText = res;
                $(""#loginForm"")[0].reset();
                window.location.href = '");
            EndContext();
            BeginContext(5255, 32, false);
#line 136 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Login\Login_page.cshtml"
                                   Write(Url.Content("~/Operator/Target"));

#line default
#line hidden
            EndContext();
            BeginContext(5287, 306, true);
            WriteLiteral(@"';
            } else if ($('#Username').val() === 'manager' && $('#Password').val() == 'manager@123' && $('#SelectType').val() == 'Manager') {
                //document.getElementById('MessageText').innerText = res;
                $(""#loginForm"")[0].reset();
                window.location.href = '");
            EndContext();
            BeginContext(5594, 35, false);
#line 140 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Login\Login_page.cshtml"
                                   Write(Url.Content("~/Manager/CWE_Master"));

#line default
#line hidden
            EndContext();
            BeginContext(5629, 280, true);
            WriteLiteral(@"';
            }else {
                //document.getElementById('MessageText').innerText = 'Invalid username or password';
                alert('Invalid username or password');
                $(""#loginForm"")[0].reset();
            }

        });
    });
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