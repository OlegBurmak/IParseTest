#pragma checksum "D:\C#Projects\ASP.NET MVC\IParse\Views\Shared\FeaturesItemSummary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "055ba1bbded4edeb024a529e603d8d7bb20081a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_FeaturesItemSummary), @"mvc.1.0.view", @"/Views/Shared/FeaturesItemSummary.cshtml")]
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
#line 1 "D:\C#Projects\ASP.NET MVC\IParse\Views\_ViewImports.cshtml"
using IParse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#Projects\ASP.NET MVC\IParse\Views\_ViewImports.cshtml"
using IParse.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\C#Projects\ASP.NET MVC\IParse\Views\_ViewImports.cshtml"
using IParse.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"055ba1bbded4edeb024a529e603d8d7bb20081a1", @"/Views/Shared/FeaturesItemSummary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae805954689931405ecc5ec824520d12be038af", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_FeaturesItemSummary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FeaturesItem>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"services text-center\">\n    <div class=\"icon mt-2 d-flex justify-content-center align-items-center\"><span");
            BeginWriteAttribute("class", " class=\"", 137, "\"", 156, 1);
#nullable restore
#line 4 "D:\C#Projects\ASP.NET MVC\IParse\Views\Shared\FeaturesItemSummary.cshtml"
WriteAttributeValue("", 145, Model.Icon, 145, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></span></div>\n    <div class=\"text media-body\">\n        <h3>");
#nullable restore
#line 6 "D:\C#Projects\ASP.NET MVC\IParse\Views\Shared\FeaturesItemSummary.cshtml"
       Write(Model.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\n        <p>");
#nullable restore
#line 7 "D:\C#Projects\ASP.NET MVC\IParse\Views\Shared\FeaturesItemSummary.cshtml"
      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FeaturesItem> Html { get; private set; }
    }
}
#pragma warning restore 1591
