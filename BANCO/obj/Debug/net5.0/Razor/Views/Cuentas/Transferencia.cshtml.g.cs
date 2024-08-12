#pragma checksum "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c9934e82223c12f3b72a3a0d54e6139bb88dd86f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuentas_Transferencia), @"mvc.1.0.view", @"/Views/Cuentas/Transferencia.cshtml")]
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
#line 1 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\_ViewImports.cshtml"
using BANCO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\_ViewImports.cshtml"
using BANCO.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c9934e82223c12f3b72a3a0d54e6139bb88dd86f", @"/Views/Cuentas/Transferencia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a29d5e8c19b3036da8c34cac19d58e682403ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cuentas_Transferencia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BANCO.Models.Movimiento>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
  
    ViewData["Title"] = "Transferencia";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Transferencia</h1>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
 if (!string.IsNullOrEmpty(ViewBag.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">");
#nullable restore
#line 11 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
                               Write(ViewBag.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 12 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 14 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"IdCuentaOrigen\">Cuenta de Origen:</label>\r\n        ");
#nullable restore
#line 20 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
   Write(Html.DropDownListFor(model => model.IdCuentaOrigen, 
            new SelectList(ViewBag.Cuentas, "Id", "Numero"),
            "Seleccione una cuenta", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Tipo\">Tipo de Movimiento:</label>\r\n        <select name=\"TipoMov\" id=\"TipoMov\" class=\"form-control\" required>\r\n");
#nullable restore
#line 27 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
             foreach (var tipoMovimiento in ViewBag.TiposMovimiento)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9934e82223c12f3b72a3a0d54e6139bb88dd86f5816", async() => {
#nullable restore
#line 29 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
                                           Write(EnumHelper.GetDisplayName(tipoMovimiento));

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
                   WriteLiteral(tipoMovimiento);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </select>\r\n    </div>\r\n    <div class=\"form-group\">\r\n        \r\n        <label for=\"IdCuentaDestino\"> Cuenta de Destino:</label>\r\n        ");
#nullable restore
#line 36 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
   Write(Html.TextBox("IdCuentaDestino", null, 
        new { @class = "form-control",
        placeholder = "Ingrese la cuenta destino" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 39 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
   Write(Html.ValidationMessage("IdCuentaDestino", "",
        new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"Concepto\">Concepto:</label>\r\n        ");
#nullable restore
#line 44 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
   Write(Html.TextBoxFor(model => model.Concepto, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"form-group\">\r\n        <label for=\"monto\">Monto:</label>\r\n        ");
#nullable restore
#line 48 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
   Write(Html.TextBoxFor(model => model.Monto, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <hr />\r\n    <div class=\"form-group\">\r\n        <input type=\"submit\" value=\"Realizar Transferencia\" class=\"btn btn-primary\" />\r\n    </div>\r\n");
#nullable restore
#line 55 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\Transferencia.cshtml"
    
    
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BANCO.Models.Movimiento> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
