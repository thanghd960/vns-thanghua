#pragma checksum "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7bb001a97bfce7027d01188c28aa07e296ddc28"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
#line 1 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/_ViewImports.cshtml"
using Vns.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/_ViewImports.cshtml"
using Vns.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7bb001a97bfce7027d01188c28aa07e296ddc28", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8150541ec42fd7df9c25d8d2db03d81147803d0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bb001a97bfce7027d01188c28aa07e296ddc283807", async() => {
                WriteLiteral(@"
    <meta http-equiv=""Content-Type"" content=""text/html; charset=UTF-8"" />
    <!-- Basic Page Needs
    ================================================== -->
    <meta charset=""utf-8"">
    <title>Digiqole - News Magazine Newspaper HTML Template</title>
    <!-- Mobile Specific Metas
    ================================================== -->
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <!--Favicon-->
    <link rel=""shortcut icon"" href=""/static/images/favicon.ico"" type=""image/x-icon"">
    <link rel=""icon"" href=""/static/images/favicon.ico"" type=""image/x-icon"">
    <!-- CSS
    ================================================== -->
    <!-- Bootstrap -->
    <link rel=""stylesheet"" href=""/static/css/bootstrap.min.css"">
    <!-- IconFont -->
    <link rel=""stylesheet"" href=""/static/css/iconfonts.css"">
    <!-- FontAwesome -->
    <link rel=""stylesheet"" href=""/static/css/font-awesome.min.");
                WriteLiteral(@"css"">
    <!-- Owl Carousel -->
    <link rel=""stylesheet"" href=""/static/css/owl.carousel.min.css"">
    <link rel=""stylesheet"" href=""/static/css/owl.theme.default.min.css"">
    <!-- magnific -->
    <link rel=""stylesheet"" href=""/static/css/magnific-popup.css"">
    <link rel=""stylesheet"" href=""/static/css/animate.css"">
    <!-- Template styles-->
    <link rel=""stylesheet"" href=""/static/css/style.css"">
    <!-- Responsive styles-->
    <link rel=""stylesheet"" href=""/static/css/responsive.css"">
    <!-- Colorbox -->
    <link rel=""stylesheet"" href=""/static/css/colorbox.css"">


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bb001a97bfce7027d01188c28aa07e296ddc286477", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 40 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_TrendingBar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 41 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_Header"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 42 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_Navbar"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"gap-30\"></div>\r\n    ");
#nullable restore
#line 44 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div class=\"gap-50\"></div>\r\n    ");
#nullable restore
#line 46 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_NewsLetter"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 47 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_Footer"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 48 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_CopyRight"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    ");
#nullable restore
#line 49 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(await Html.PartialAsync("_TopUp"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
    <!-- Javascript Files
    ================================================== -->
    <!-- initialize jQuery Library -->
    <script src=""/static/js/jquery.js""></script>
    <!-- Popper Jquery -->
    <script src=""/static/js/popper.min.js""></script>
    <!-- Bootstrap jQuery -->
    <script src=""/static/js/bootstrap.min.js""></script>
    <!-- magnific-popup -->
    <script src=""/static/js/jquery.magnific-popup.min.js""></script>
    <!-- Owl Carousel -->
    <script src=""/static/js/owl.carousel.min.js""></script>
    <!-- Color box -->
    <script src=""/static/js/jquery.colorbox.js""></script>
    <!-- Template custom -->
    <script src=""/static/js/custom.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7bb001a97bfce7027d01188c28aa07e296ddc289490", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 66 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
#nullable restore
#line 67 "/Users/thanghd/workplace/freelancer/thanghd-vnstyle/Vns.Web/Views/Shared/_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
            WriteLiteral("\r\n</html>");
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