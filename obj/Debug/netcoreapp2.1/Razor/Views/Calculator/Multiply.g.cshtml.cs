#pragma checksum "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\Calculator\Multiply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf7e6295a22b440271b6c6778ba2021708f4a97f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculator_Multiply), @"mvc.1.0.view", @"/Views/Calculator/Multiply.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculator/Multiply.cshtml", typeof(AspNetCore.Views_Calculator_Multiply))]
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
#line 1 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator;

#line default
#line hidden
#line 2 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\_ViewImports.cshtml"
using MyWebCalculator.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf7e6295a22b440271b6c6778ba2021708f4a97f", @"/Views/Calculator/Multiply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"723c93cf8501ee692a6dcd53c1cb5152db45382f", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculator_Multiply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\Calculator\Multiply.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 31, true);
            WriteLiteral("\r\n<h1>Multiply Result</h1>\r\n<p>");
            EndContext();
            BeginContext(59, 26, false);
#line 6 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\Calculator\Multiply.cshtml"
Write(ViewData["MultiplyResult"]);

#line default
#line hidden
            EndContext();
            BeginContext(85, 8, true);
            WriteLiteral("</p>\r\n\r\n");
            EndContext();
#line 8 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\Calculator\Multiply.cshtml"
  
    int left = Convert.ToInt32(ViewData["Left"]);
    int right = Convert.ToInt32(ViewData["Right"]);
    int result = left * right;

#line default
#line hidden
            BeginContext(236, 33, true);
            WriteLiteral("\r\n<p>The final answer is <strong>");
            EndContext();
            BeginContext(270, 6, false);
#line 14 "C:\Users\Catherine\Desktop\5360-Ob-des-abd-Anal\Babb-Class\MVC-InClass-11-12-F\MyWebCalculator\Views\Calculator\Multiply.cshtml"
                          Write(result);

#line default
#line hidden
            EndContext();
            BeginContext(276, 13, true);
            WriteLiteral("</strong></p>");
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