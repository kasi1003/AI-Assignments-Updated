#pragma checksum "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d7b46dda888888d89eab951af63abda6712d800"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Index), @"mvc.1.0.view", @"/Views/Account/Index.cshtml")]
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
#line 1 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\_ViewImports.cshtml"
using PromotionsWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\_ViewImports.cshtml"
using PromotionsWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Domain.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Models.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Utilities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.ViewComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
using PromotionsWebApp.Domain.Abstract;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d7b46dda888888d89eab951af63abda6712d800", @"/Views/Account/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbe3f0cc88de9c1478aa5821a772eca9dbc2a0a1", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UsersVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("tooltipped"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-position", new global::Microsoft.AspNetCore.Html.HtmlString("top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("submitConfirmBtn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Delete User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn waves-effect waves-light btn-large nustColor lighten-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-floating blue tooltipped"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-position", new global::Microsoft.AspNetCore.Html.HtmlString("left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_14 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-tooltip", new global::Microsoft.AspNetCore.Html.HtmlString("Create User"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 8 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
  
    ViewData["Title"] = "Users";
    string Search = "";
    if (ViewData["CurrentFilter"] != null)
        Search = ViewData["CurrentFilter"].ToString();
    string LinkUrl = "Index";
    string LinkArea = "Account";
    var prevDisabled = "True";
    var nextDisabled = "True";
    var prevPageNr = 1;
    var nextPageNr = 1;
    if (Model.Users.Count > 0)
    {
        prevDisabled = !Model.Users.HasPreviousPage ? "disabled" : "";
        nextDisabled = !Model.Users.HasNextPage ? "disabled" : "";
        prevPageNr = Model.Users.PageIndex - 1;
        nextPageNr = Model.Users.PageIndex + 1;
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n    <h4 class=\"center-align\">Users</h4>\r\n    <div class=\"divider\"></div>\r\n");
#nullable restore
#line 31 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
     if (Model.Users.Any())
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col s12\">\r\n            ");
#nullable restore
#line 34 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
       Write(await Component.InvokeAsync("Search", new { model = new SearchViewComponent.SearchViewModel(Search, LinkUrl, LinkArea) }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <ul class=\"collection\">\r\n");
#nullable restore
#line 36 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                 foreach (UserVM user in Model.Users)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li class=\"collection-item avatar\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 1379, "\"", 1452, 2);
            WriteAttributeValue("", 1385, "data:image;base64,", 1385, 18, true);
#nullable restore
#line 39 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
WriteAttributeValue("", 1403, System.Convert.ToBase64String(user.ProfileImage), 1403, 49, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"80\" height=\"80\" class=\"circle\">\r\n                        <span class=\"Title\">\r\n                            ");
#nullable restore
#line 41 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                       Write(user.ToUserString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </span>\r\n                        <p>\r\n                            Role: ");
#nullable restore
#line 44 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                             Write(user.Role.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 45 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                             if (user.Role == UserRoleEnum.Dean || user.Role == UserRoleEnum.HOD)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <br/><span>Faculty: ");
#nullable restore
#line 47 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                               Write(user.Faculty);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 48 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                             if (user.Role == UserRoleEnum.HOD)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <br/><span>Department: ");
#nullable restore
#line 51 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                                  Write(user.Department);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 52 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </p>\r\n                        <span class=\"secondary-content\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d7b46dda888888d89eab951af63abda6712d80014871", async() => {
                WriteLiteral("<i class=\"material-icons\">edit</i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 55 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                                          WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d7b46dda888888d89eab951af63abda6712d80017391", async() => {
                WriteLiteral("\r\n                                <i class=\"material-icons\">delete</i>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-userId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                                                                                                        WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-userId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["userId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute(";", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </span>\r\n                    </li>\r\n");
#nullable restore
#line 62 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col s12 m12 l12"">
            <div class=""card-panel blue darken-2 center-align"">
                <span class=""white-text"">
                    No Users are currently existing in the system.
                </span>
            </div>
        </div>
");
#nullable restore
#line 75 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"center-align\">\r\n        ");
#nullable restore
#line 77 "C:\Users\CenoredPC\source\repos\TulongaHishiko\PromotionsWebApp\PromotionsWebApp\Views\Account\Index.cshtml"
   Write(await Component.InvokeAsync("Pager", new
        {
            model = new PagerViewComponent.PagerViewModel
                        (prevPageNr, nextPageNr, Search, LinkUrl, LinkArea, nextDisabled, prevDisabled)
        }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <br />\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"input-field col s12 center-align \">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d7b46dda888888d89eab951af63abda6712d80022338", async() => {
                WriteLiteral("\r\n                <span class=\"material-icons white-text md-24 matIcon\">\r\n                    keyboard_return\r\n                </span>\r\n                <span class=\"white-text\">Back</span>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n    <div class=\"fixed-action-btn\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2d7b46dda888888d89eab951af63abda6712d80024078", async() => {
                WriteLiteral("\r\n            <i class=\"large material-icons\">add</i>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_14);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UsersVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
