#pragma checksum "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1315e0b2077920c5440ed5931d99039f3ffc33d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ListaPedido), @"mvc.1.0.view", @"/Views/Home/ListaPedido.cshtml")]
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
#line 1 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\_ViewImports.cshtml"
using ATIVIDADE_3_UN5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\_ViewImports.cshtml"
using ATIVIDADE_3_UN5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1315e0b2077920c5440ed5931d99039f3ffc33d8", @"/Views/Home/ListaPedido.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f929457bf6e9de0cc4c79dd672e74325e0dfe28", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ListaPedido : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Formulario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Agendamento", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
  
    ViewData["Title"] = "Pedido";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Nome</th>\r\n            <th>Telefone</th>\r\n            <th>Data</th>\r\n            <th>Animal</th>\r\n            <th>Necessidade</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
         foreach (Formulario pedido in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
               Write(pedido.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
               Write(pedido.Telefone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
               Write(pedido.Data);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
               Write(pedido.Animal);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 25 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
               Write(pedido.Necessidade);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Mr Coutinho\Desktop\Programação\SENAC\Senac Atividades\M1 UN5\ATIVIDADE 3 UN5\Views\Home\ListaPedido.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n\r\n</table>\r\n    <p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1315e0b2077920c5440ed5931d99039f3ffc33d86381", async() => {
                WriteLiteral("Adicionar outro Pedido");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Formulario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
