#pragma checksum "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\sidemenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e17d30755af85bdb4daac40475878c5b5ac9933"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manager_sidemenu), @"mvc.1.0.view", @"/Views/Manager/sidemenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Manager/sidemenu.cshtml", typeof(AspNetCore.Views_Manager_sidemenu))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e17d30755af85bdb4daac40475878c5b5ac9933", @"/Views/Manager/sidemenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0334c3eb54015b993c2da8df0e4497ff8e9d9e25", @"/Views/_ViewImports.cshtml")]
    public class Views_Manager_sidemenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 5358, true);
            WriteLiteral(@"
<style>


    * {
        padding: 0;
        margin: 0;
        font-family: ""Ubuntu"", sans-serif;
        -webkit-font-smoothing: antialiased;
    }

    .fas, .fa-solid {
        font-family: ""Font Awesome 6 Free"" !important;
    }

    ol, ul {
        padding: 0px;
    }
    /*-------------------------------sidemnu dynamcially function  style-------------------*/
    #sideMenu {
        width: 100%;
        height: 100%;
        position: fixed;
        top: 40px;
        left: 0;
        right: 0;
        max-width: 180px;
        box-shadow: -12px -5px 6px -13px rgba(0,0,0,0.3) inset;
        background-color: #fafbfc; /*#2d4456*/
        transition: all 1s ease-in-out;
    }

    ul#menuItems {
        margin: 0;
        text-decoration: none;
        list-style: none;
        outline: none;
        padding-top: 43px;
        padding-left: 0;
    }

        ul#menuItems > li {
            padding: 10px 10px;
        }

            ul#menuItems > li > span ");
            WriteLiteral(@"{
                padding-right: 15px;
                color: #fff;
                font-size: 13px;
                padding-left: 8px;
                font-weight: lighter;
                padding-top: 5px;
            }

    #menuItems > a {
        text-decoration: none;
        color: black;
        padding: 0 10px;
        display: block;
    }

    #menuItems > li > a {
        text-decoration: none;
        padding: 0 10px;
        display: inline-flex;
        color: black;
        align-items: center;
        column-gap: 10px;
    }

        #menuItems > li > a > span.fa {
            font-size: 15px;
            font-weight: lighter;
        }

    ul#menuItems > li:hover {
        background-color: #f3f3f3; /*#263e50e0*/
        border-right: 4px solid #67aae6;
        color: #65a8e6;
    }

    #menuItems > li > a:hover {
    }

    ul#menuItems > li:hover span {
        color: black;
    }

    ul.submenu li:hover {
        background: #1b354abd;
    }");
            WriteLiteral(@"

    ul#menuItems > li:hover a {
        color: black;
        /*-webkit-transition: inherit;*/
    }

    ul.submenu li {
        text-decoration: none;
        list-style: none;
        outline: none;
        padding: 9px 12px;
    }

        ul.submenu li a {
            list-style: none;
            text-decoration: none;
            color: #fff;
            display: block;
            padding-left: 3px;
        }

    ul.submenu > li > span {
        display: none;
    }

    .submenu-arrow {
        transition: transform 0.3s ease;
        position: absolute;
        right: 18px;
        transform: rotate(0deg);
        padding-right: 40px;
    }

    .has-submenu.collapsed .submenu-arrow {
        transform: rotate(-90deg);
    }

    div#sideMenu.collaps {
        width: 60px;
        transition: all 0.1s ease-in-out;
    }

        div#sideMenu.collaps label {
            display: none;
            /*transition: all 0.5s ease-in-out;*/
            transi");
            WriteLiteral(@"tion-delay: 2s !important;
        }

    .page-wrapper {
        margin-left: 165px !important;
    }

    div#sideMenu label {
        transition: all ease 1s;
        font-size: 13px;
        cursor: pointer;
        width: 131px;
        padding-left: 8px;
    }

    #sideMenu.collaps ~ .page-wrapper {
        margin-left: 60px !important;
        transition: all 0.5s ease-in-out;
    }

    .collaps .submenu-arrow {
        right: 0px;
    }

    #sideMenu.collaps ul#menuItems > li > span {
        padding-left: 14px;
    }

    /*Toggle Button Style*/
    /*button#toggleButton {
        background: gray !important;
        border: 1px solid gray !important;
        float: right;
        margin: 10px;
        border-radius: 30px;
        position: relative;
        width: 32px;
        height: 18px;
        border-radius: 30px;
    }
     button#toggleButton:after {
        width: 16px;
        height: 16px;
        background: white;
        position: absolute");
            WriteLiteral(@";
        content: """";
        border-radius: 50%;
        top: 0;
        right: 0;
     }
     #sideMenu.collaps button#toggleButton:after {
        left: 0;
     }*/

    #toggleButton {
        box-shadow: 0px 0px 2px gray;
        border: none;
        float: right;
        position: relative;
        top: 19px;
        right: -11px;
        cursor: pointer;
        border-radius: 50%;
        background: white;
        /*background-color:black;*/
    }

    .submenu span {
        padding-right: 10px;
        font-size: 11px;
    }

    .fa-chevron-right:before {
        font-family: 'FontAwesome';
    }

    .arrow-down {
        transform: rotate(90deg);
    }

    #rightSVG {
        transform: rotate(180deg);
    }
</style>

<div id=""sideMenu"">

    <button id=""toggleButton"">
        <svg id=""rightSVG"" width=""24"" height=""24"" viewBox=""0 0 24 24"" role=""presentation""><path d=""M10.294 9.698a.988.988 0 010-1.407 1.01 1.01 0 011.419 0l2.965 2.94a1.09 1.09 0 010 ");
            WriteLiteral("1.548l-2.955 2.93a1.01 1.01 0 01-1.42 0 .988.988 0 010-1.407l2.318-2.297-2.327-2.307z\" fill=\"#000\" fill-rule=\"evenodd\"></path></svg>\r\n    </button>\r\n\r\n\r\n    <ul id=\"menuItems\">\r\n        <!-- Menu items will be dynamically added here -->\r\n");
            EndContext();
            BeginContext(5468, 111, true);
            WriteLiteral("    </ul>\r\n</div>\r\n\r\n<script>\r\n    \r\n    const menuData = [\r\n        {\r\n            label: \"CWE Master\", url: \"");
            EndContext();
            BeginContext(5580, 35, false);
#line 239 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\sidemenu.cshtml"
                                  Write(Url.Action("CWE_Master", "Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(5615, 159, true);
            WriteLiteral("\", submenus: [/*{label: \"Submenu 1\",url: \"#\" },{label: \"Submenu 2\", url: \"/submenu2\" }*/]\r\n        },\r\n     {\r\n            label:\"Vulnerability Master\", url: \"");
            EndContext();
            BeginContext(5775, 36, false);
#line 242 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\sidemenu.cshtml"
                                           Write(Url.Action("VAPT_Master", "Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(5811, 153, true);
            WriteLiteral("\", submenus: [/*{label: \"Submenu 1\",url: \"#\" },{label: \"Submenu 2\", url: \"/submenu2\" }*/]\r\n        },\r\n           {\r\n        label: \"Tool Master\", url: \"");
            EndContext();
            BeginContext(5965, 36, false);
#line 245 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\sidemenu.cshtml"
                               Write(Url.Action("Tool_Master", "Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(6001, 150, true);
            WriteLiteral("\", submenus: [/*{label: \"Submenu 1\",url: \"#\" },{label: \"Submenu 2\", url: \"/submenu2\" }*/]\r\n        },\r\n        {\r\n       label: \"Tool Linkage\", url: \"");
            EndContext();
            BeginContext(6152, 37, false);
#line 248 "C:\Users\test\Desktop\Dashboard\VAPT_FINAL_03-03-2024\VAPT_FINAL_16022024\VAPT\VAPT\Views\Manager\sidemenu.cshtml"
                               Write(Url.Action("Tool_Linkage", "Manager"));

#line default
#line hidden
            EndContext();
            BeginContext(6189, 103, true);
            WriteLiteral("\", submenus: [/*{label: \"Submenu 1\",url: \"#\" },{label: \"Submenu 2\", url: \"/submenu2\" }*/]\r\n        },\r\n");
            EndContext();
            BeginContext(6479, 1060, true);
            WriteLiteral(@"    ];
</script>

<script>
    var dynamicIcons = [

        { label:'VAPT Manager', iconClass: 'fas fa-user-plus fs-6' },
        { label:'Tool Master', iconClass: 'fa-solid fa-calendar-days fs-6' },
        { label:'CWE Master', iconClass: 'fa-solid fa-clipboard-list fs-5' },
        { label:'Vulnerability Master', iconClass: 'fas fa-user-plus fs-6' },
        { label:'Logout', iconClass: 'fa-solid fa-table fs-6' },
        { label: 'Tool Linkage', iconClass: 'fa-solid fa-table fs-6' },
    ];
</script>

<script>
    $(document).ready(function () {
        $(""#toggleButton"").click(function () {
            //    $(""#sideMenu"").toggleClass(""collaps"");
            if ($(""#sideMenu"").hasClass(""collaps"")) {
                // Sidebar is collapsed, rotate the right SVG
                $(""#rightSVG"").css(""transform"", ""rotate(180deg)"");
            } else {
                // Sidebar is open, reset the rotation
                $(""#rightSVG"").css(""transform"", ""rotate(0deg)"");
            }");
            WriteLiteral("\n        });\r\n    });\r\n</script>\r\n\r\n");
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
