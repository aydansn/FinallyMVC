#pragma checksum "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115616e96b835514cc28b7e695a7777c2d0b3dc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Backgrounds__ListBody), @"mvc.1.0.view", @"/Areas/Admin/Views/Backgrounds/_ListBody.cshtml")]
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
#line 1 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.PersonModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.AppCode.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.BackgroundModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.BlogModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ContactModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ExperienceModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.ServiceModule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\_ViewImports.cshtml"
using FinallyMVC.Domain.Business.SkillModule;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115616e96b835514cc28b7e695a7777c2d0b3dc3", @"/Areas/Admin/Views/Backgrounds/_ListBody.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0501eb553750b685a65143db9faaf12c8bb293", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Backgrounds__ListBody : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Background>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 6 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
       Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("./*Name</td>*/\r\n        <td class=\"operation\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115616e96b835514cc28b7e695a7777c2d0b3dc37019", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-pencil\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 8 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "115616e96b835514cc28b7e695a7777c2d0b3dc39348", async() => {
                WriteLiteral("\r\n                <i class=\"fa fa-eye\"></i>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
                                      WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <a");
            BeginWriteAttribute("onclick", " onclick=\"", 452, "\"", 503, 5);
            WriteAttributeValue("", 462, "removeEntity(event,", 462, 19, true);
#nullable restore
#line 14 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
WriteAttributeValue("", 481, item.Id, 481, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 489, ",\'", 489, 2, true);
#nullable restore
#line 14 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
WriteAttributeValue("", 491, item.Body, 491, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 501, "\')", 501, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">\r\n                <i class=\"fa fa-trash\"></i>\r\n            </a>\r\n        </td>\r\n    </tr>\r\n");
#nullable restore
#line 19 "C:\Users\user\Desktop\P412\FinalyMVC Solution\FinallyMVC.WebUI\Areas\Admin\Views\Backgrounds\_ListBody.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<a href=\"c:\\users\\user\\desktop\\p412\\finalymvc solution\\finallymvc.webui\\areas\\admin\\views\\backgrounds\\details.cshtml\">c:\\users\\user\\desktop\\p412\\finalymvc solution\\finallymvc.webui\\areas\\admin\\views\\backgrounds\\details.cshtml</a>\r\n\r\n\r\n\r\n");
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