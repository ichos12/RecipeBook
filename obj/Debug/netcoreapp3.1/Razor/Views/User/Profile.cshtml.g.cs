#pragma checksum "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed1f7805364eedcacabeabe4a4e70e623bd4a99c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\_ViewImports.cshtml"
using RecipeBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed1f7805364eedcacabeabe4a4e70e623bd4a99c", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f55e906a5633bee239e13d6bf3a32417c57e856", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RecipeBook.Models.User>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table>\r\n    <tr valign=\"top\">\r\n        <td>\r\n");
#nullable restore
#line 5 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
             if (Model.Type == 0)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5 style=\"color: blue;\">Пользователь</h5>");
#nullable restore
#line 6 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                                                       }

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
             if (Model.Type == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<h5 style=\"color: red;\">Главный администратор</h5>");
#nullable restore
#line 8 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                                                               }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1>Имя: ");
#nullable restore
#line 9 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h1>\r\n");
#nullable restore
#line 10 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
             if (Model.Email == User.Identity.Name)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1f7805364eedcacabeabe4a4e70e623bd4a99c4720", async() => {
                WriteLiteral("Редактировать профиль");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 411, "~/User/Edit/", 411, 12, true);
#nullable restore
#line 12 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
AddHtmlAttributeValue("", 423, Model.UserId, 423, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n");
#nullable restore
#line 13 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </td>\r\n    </tr>\r\n</table>\r\n<hr>\r\n<table>\r\n    <tr>\r\n        <h4>Отзывы пользователя</h4>\r\n");
#nullable restore
#line 21 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
         foreach (var feedback in Model.Feedbacks)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <table>\r\n                <tr class=\"row\" valign=\"top\">\r\n                    <td>\r\n                        Рецепт: ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed1f7805364eedcacabeabe4a4e70e623bd4a99c6965", async() => {
#nullable restore
#line 26 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                                                                 Write(feedback.Recipe.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 781, "~/Recipe/", 781, 9, true);
#nullable restore
#line 26 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
AddHtmlAttributeValue("", 790, feedback.RecipeId, 790, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <br> Оценка: ");
#nullable restore
#line 27 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                                Write(feedback.Rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n                <tr class=\"row\" valign=\"top\">\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
                   Write(feedback.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n                <br>\r\n            </table>\r\n");
#nullable restore
#line 35 "C:\Users\Magus\source\repos\RecipeBook\RecipeBook\Views\User\Profile.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RecipeBook.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
