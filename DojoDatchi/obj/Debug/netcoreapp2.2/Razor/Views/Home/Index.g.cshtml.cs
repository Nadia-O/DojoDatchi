#pragma checksum "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74df48be59cda13eab86e3ca52c32072d112da6f"
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
#line 1 "/Users/nadiaouzounova/DojoDatchi/Views/_ViewImports.cshtml"
using DojoDatchi;

#line default
#line hidden
#line 2 "/Users/nadiaouzounova/DojoDatchi/Views/_ViewImports.cshtml"
using DojoDatchi.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74df48be59cda13eab86e3ca52c32072d112da6f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"229c8240ac9fb15b33207b9ae261bf08a1995d8b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Datchi>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Reset", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning font-weight-bold"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(16, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(63, 272, true);
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-3"">Welcome to Dojo Datchi!</h1><br>
        <div class=""mx-auto"" style=""width: 40%;"">
            <ul class=""list-group list-group-horizontal-sm"">
                <li class=""list-group-item font-weight-bold"">Fullness ");
            EndContext();
            BeginContext(336, 16, false);
#line 11 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
                                                                 Write(ViewBag.Fullness);

#line default
#line hidden
            EndContext();
            BeginContext(352, 78, true);
            WriteLiteral("</li>\r\n                <li class=\"list-group-item font-weight-bold\">Happiness ");
            EndContext();
            BeginContext(431, 17, false);
#line 12 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
                                                                  Write(ViewBag.Happiness);

#line default
#line hidden
            EndContext();
            BeginContext(448, 74, true);
            WriteLiteral("</li>\r\n                <li class=\"list-group-item font-weight-bold\">Meals ");
            EndContext();
            BeginContext(523, 13, false);
#line 13 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
                                                              Write(ViewBag.Meals);

#line default
#line hidden
            EndContext();
            BeginContext(536, 75, true);
            WriteLiteral("</li>\r\n                <li class=\"list-group-item font-weight-bold\">Energy ");
            EndContext();
            BeginContext(612, 14, false);
#line 14 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
                                                               Write(ViewBag.Energy);

#line default
#line hidden
            EndContext();
            BeginContext(626, 134, true);
            WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n        <img src=\"/Dog.gif\" width=\"200\" height=\"200\" alt=\"\">\r\n        <h5 class=\"display-4\">");
            EndContext();
            BeginContext(761, 15, false);
#line 18 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
                         Write(ViewBag.Message);

#line default
#line hidden
            EndContext();
            BeginContext(776, 11, true);
            WriteLiteral("</h5><br>\r\n");
            EndContext();
#line 19 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
         if(ViewBag.Energy > 0 && ViewBag.Happiness < 100 && ViewBag.Fullness < 100)
        {

#line default
#line hidden
            BeginContext(884, 318, true);
            WriteLiteral(@"            <a href=""/feed"" class=""btn btn-warning font-weight-bold"">Feed</a>
            <a href=""/play"" class=""btn btn-warning font-weight-bold"">Play</a>
            <a href=""/work"" class=""btn btn-warning font-weight-bold"">Work</a>
            <a href=""/sleep"" class=""btn btn-warning font-weight-bold"">Sleep</a>
");
            EndContext();
#line 25 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1213, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 27 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
         if(ViewBag.Energy < 1)
        {   

#line default
#line hidden
            BeginContext(1262, 75, true);
            WriteLiteral("            <h5 class=\"display-4\">Your Datchi has fallen</h5>\r\n            ");
            EndContext();
            BeginContext(1337, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74df48be59cda13eab86e3ca52c32072d112da6f7503", async() => {
                BeginContext(1400, 8, true);
                WriteLiteral("RESTART?");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1412, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1439, 8, true);
            WriteLiteral("        ");
            EndContext();
#line 33 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
         if(ViewBag.Happiness > 101 || ViewBag.Fullness >  101 || ViewBag.Energy > 101)
        {

#line default
#line hidden
            BeginContext(1539, 61, true);
            WriteLiteral("            <h5 class=\"display-4\">You win!</h5>\r\n            ");
            EndContext();
            BeginContext(1600, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "74df48be59cda13eab86e3ca52c32072d112da6f9522", async() => {
                BeginContext(1663, 8, true);
                WriteLiteral("RESTART?");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1675, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 37 "/Users/nadiaouzounova/DojoDatchi/Views/Home/Index.cshtml"
            
        }

#line default
#line hidden
            BeginContext(1702, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Datchi> Html { get; private set; }
    }
}
#pragma warning restore 1591
