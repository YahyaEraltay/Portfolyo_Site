#pragma checksum "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b5ddcb2e0a7f60a953f25ee9718350ff62463bbd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Project), @"mvc.1.0.view", @"/Views/Admin/Project.cshtml")]
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
#line 1 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\_ViewImports.cshtml"
using Portfolyo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\_ViewImports.cshtml"
using Portfolyo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5ddcb2e0a7f60a953f25ee9718350ff62463bbd", @"/Views/Admin/Project.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1e2253ed32937fe6265401d4433b69f3e6ed3c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Project : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<Portfolyo.Models.Project>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px; width:300px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Proje Fotoğrafı"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
  
    ViewData["Title"] = "Project";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Projeler</h2>
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Proje ID</th>
            <th>Proje Kısa Açıklama</th>
            <th>Proje Link</th>
            <th>Proje Fotoğrafı</th>
            <th>İşlemler</th>
        </tr>
    </thead>
");
#nullable restore
#line 19 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
     foreach (var x in Model.Where(x => x.Status == true))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tbody>\r\n            <tr>\r\n                <td>");
#nullable restore
#line 23 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
               Write(x.ProjectID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
               Write(x.ProjectAnnotation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
               Write(x.ProjectLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b5ddcb2e0a7f60a953f25ee9718350ff62463bbd5391", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 726, "~/images/", 726, 9, true);
#nullable restore
#line 26 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
AddHtmlAttributeValue("", 735, x.ProjectPhoto, 735, 15, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
#nullable restore
#line 28 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
               Write(Html.ActionLink("Sil", "DeleteProject", new { id = x.ProjectID }, new { @class = "btn btn-danger", onclick = "onconfirm('Silmek istediğinize emin misiniz?')" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1050, 2);
            WriteAttributeValue("", 1017, "/Admin/UpdateProject/", 1017, 21, true);
#nullable restore
#line 29 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
WriteAttributeValue("", 1038, x.ProjectID, 1038, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Güncelle</a>\r\n                </td>\r\n            </tr>\r\n        </tbody>\r\n");
#nullable restore
#line 33 "D:\Downloads\ASP.NET\Portfolyo\Portfolyo\Views\Admin\Project.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Admin/AddProject/\" class=\"btn btn-success\">Proje Ekle</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<Portfolyo.Models.Project>> Html { get; private set; }
    }
}
#pragma warning restore 1591
