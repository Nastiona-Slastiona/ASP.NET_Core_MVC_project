#pragma checksum "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd229b3bad5b374aae3cd8a37b6ff8fed072b569"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Menu/Default.cshtml")]
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
#nullable restore
#line 1 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\_ViewImports.cshtml"
using WEB_953506_Kruglaya;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\_ViewImports.cshtml"
using WEB_953506_Kruglaya.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fd229b3bad5b374aae3cd8a37b6ff8fed072b569", @"/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e30ec69431abe94b1365ad1a0911eac158f5596", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MenuItem>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n<ul>\r\n");
#nullable restore
#line 6 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
     foreach (var item in Model)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
         if (item.IsPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd229b3bad5b374aae3cd8a37b6ff8fed072b5693857", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 14 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
               Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 165, "nav-item", 165, 8, true);
            AddHtmlAttributeValue(" ", 173, "nav-link", 174, 9, true);
#nullable restore
#line 11 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 182, item.Active, 183, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
                  WriteLiteral(item.Area);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-area", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
                  WriteLiteral(item.Page);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-page", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 17 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd229b3bad5b374aae3cd8a37b6ff8fed072b5697457", async() => {
                WriteLiteral("\r\n                    ");
#nullable restore
#line 24 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
               Write(item.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "class", 3, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 438, "nav-item", 438, 8, true);
            AddHtmlAttributeValue(" ", 446, "nav-link", 447, 9, true);
#nullable restore
#line 21 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
AddHtmlAttributeValue(" ", 455, item.Active, 456, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 22 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
                        WriteLiteral(item.Controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            WriteLiteral("/");
#nullable restore
#line 23 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
                     WriteLiteral(item.Action);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-action", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </li>\r\n");
#nullable restore
#line 27 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Universe\3course\ИГИ\Labs\Lab_1\WEB_953506_Kruglaya\WEB_953506_Kruglaya\Views\Shared\Components\Menu\Default.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MenuItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
