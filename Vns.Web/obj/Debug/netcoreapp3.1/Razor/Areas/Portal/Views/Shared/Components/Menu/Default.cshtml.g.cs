#pragma checksum "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0db607437452ce8488e52e20bfa3d166983ec4a0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Vns.Web.Areas.Portal.Views.Shared.Shared.Components.Menu.Areas_Portal_Views_Shared_Components_Menu_Default), @"mvc.1.0.view", @"/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml")]
namespace Vns.Web.Areas.Portal.Views.Shared.Shared.Components.Menu
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0db607437452ce8488e52e20bfa3d166983ec4a0", @"/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6a54ae0213bc18bafab37c816a3d57acaee73e1", @"/Areas/Portal/Views/_ViewImports.cshtml")]
    public class Areas_Portal_Views_Shared_Components_Menu_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Vns.Core.Entities.Menu>>
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
            WriteLiteral("<!-- Sidebar Menu -->\n");
#nullable restore
#line 3 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml"
 foreach (var menu in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"sidebar-menu\" data-widget=\"tree\">\n\n        <li>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0db607437452ce8488e52e20bfa3d166983ec4a03310", async() => {
                WriteLiteral("\n                <i class=\"fa fa-link\"></i> <span>");
#nullable restore
#line 9 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml"
                                            Write(menu.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml"
                   WriteLiteral(menu.Controller);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-controller", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml"
                                                 WriteLiteral(menu.Index);

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
            WriteLiteral("\n\n        </li>\n    </ul>\n");
#nullable restore
#line 14 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Areas/Portal/Views/Shared/Components/Menu/Default.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- /.sidebar-menu -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Vns.Core.Entities.Menu>> Html { get; private set; }
    }
}
#pragma warning restore 1591
