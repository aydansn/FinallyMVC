#pragma checksum "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\Shared\Components\Background\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ab5bd68945207603764b795985f4ca038af17ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Background_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Background/Default.cshtml")]
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
#line 1 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.PersonModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ab5bd68945207603764b795985f4ca038af17ab", @"/Views/Shared/Components/Background/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e166ace9a7168ec3e047d0c72fea073e2d773791", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Background_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Background>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\Shared\Components\Background\Default.cshtml"
  
    ViewData["Title"] = "View";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\Shared\Components\Background\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""exp"">
        <div class=""media-left""> <span class=""sun"">2002 - 2008</span> </div>
        <div class=""media-body"">
            <!-- COmpany Logo -->
            <div class=""company-logo""> <span class=""diploma""><i class=""fa fa-graduation-cap""></i> Download Diploma</span> </div>
            <h6>Multimedia Arts</h6>
            <p>Market Network</p>
            <p>San Francisco, California, USA</p>
            <p class=""margin-top-10""> Lorem ipsum dolor sit amet, consectetur adipiscing elit. Proin nibh augue, suscipit a, scelerisque sed, lacinia in, mi. Cras vel lorem. Etiam pellentesque aliquet tellus. Phasellus pharetra nulla ac diam (...) <a href=""#."">Read More</a> </p>
        </div>
    </div>
");
#nullable restore
#line 19 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Views\Shared\Components\Background\Default.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Background>> Html { get; private set; }
    }
}
#pragma warning restore 1591