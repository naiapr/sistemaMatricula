#pragma checksum "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5bc69ffe80f77c64894b3a67a05db708b2decdde"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alunos_Details), @"mvc.1.0.view", @"/Views/Alunos/Details.cshtml")]
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
#line 1 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\_ViewImports.cshtml"
using SistemaMatricula;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\_ViewImports.cshtml"
using SistemaMatricula.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bc69ffe80f77c64894b3a67a05db708b2decdde", @"/Views/Alunos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d079607d6e04d4e02aa39088b59dfaf708145766", @"/Views/_ViewImports.cshtml")]
    public class Views_Alunos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SistemaMatricula.Models.ViewModel.AlunoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
  
    ViewData["Title"] = "Cadastrar";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 6 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<h4>Aluno</h4>\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
#nullable restore
#line 12 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
   Write(Html.HiddenFor(x => x.AlunoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5bc69ffe80f77c64894b3a67a05db708b2decdde4336", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#nullable restore
#line 13 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n\r\n            ");
#nullable restore
#line 16 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.LabelFor(model => model.NomeAluno, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 18 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeAluno, new { htmlAttributes = new { @class = "control-label" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ValidationMessageFor(model => model.NomeAluno, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            ");
#nullable restore
#line 23 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.LabelFor(model => model.Cpf, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 25 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cpf, new { htmlAttributes = new { @class = "control-label" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 26 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ValidationMessageFor(model => model.Cpf, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            ");
#nullable restore
#line 31 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.LabelFor(model => model.Peso, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 33 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Peso, new { htmlAttributes = new { @class = "control-label" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ValidationMessageFor(model => model.Peso, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            ");
#nullable restore
#line 38 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.LabelFor(model => model.Altura, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 40 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Altura, new { htmlAttributes = new { @class = "control-label" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 41 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ValidationMessageFor(model => model.Altura, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n\r\n            ");
#nullable restore
#line 45 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.LabelFor(model => model.NomeModalidade, htmlAttributes: new { @class = "control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 47 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NomeModalidade, new { htmlAttributes = new { @class = "control-label" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 48 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ValidationMessageFor(model => model.NomeModalidade, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n\r\n\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 54 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
       Write(Html.ActionLink("Editar", "Edit", "Alunos", new { @id = Model.AlunoId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        ");
#nullable restore
#line 56 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
   Write(Html.ActionLink("Voltar", "Index", "Alunos", new { htmlAttributes = new { @class = "btn btn-primary" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 62 "C:\Users\naiap\source\repos\SistemaMatricula\SistemaMatricula\Views\Alunos\Details.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SistemaMatricula.Models.ViewModel.AlunoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
