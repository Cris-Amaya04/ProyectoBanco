#pragma checksum "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c6b686912f621994f252798de6fa1850f9f7a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cuentas_PagoServicio), @"mvc.1.0.view", @"/Views/Cuentas/PagoServicio.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c6b686912f621994f252798de6fa1850f9f7a8", @"/Views/Cuentas/PagoServicio.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a29d5e8c19b3036da8c34cac19d58e682403ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Cuentas_PagoServicio : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BANCO.Models.Movimiento>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
  
    ViewData["Title"] = "PagoServicio";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Pago de servicios</h2>\r\n<br />\r\n\r\n");
#nullable restore
#line 9 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
 using (Html.BeginForm("PagoServicio", "Cuentas", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"IdCuenta\">Cuenta:</label>\r\n        ");
#nullable restore
#line 15 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
   Write(Html.DropDownListFor(model => model.IdCuenta, new SelectList(ViewBag.Cuentas, "Id", "Numero"), "Seleccione una cuenta", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        <label for=\"Monto\">Monto:</label>\r\n        <input type=\"number\" id=\"Monto\" name=\"Monto\" class=\"form-control\" required />\r\n    </div>\r\n");
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c6b686912f621994f252798de6fa1850f9f7a84784", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 26 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.TipoServicio);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
   Write(Html.DropDownList(
         "TipoServicio",Html.GetEnumSelectList<Tipo_PagoServicio>(),
         "Servicio",
         new{@class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <hr>\r\n        <button type=\"submit\" class=\"btn btn-primary\">Realizar pago</button>\r\n    </div>\r\n");
#nullable restore
#line 36 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Cuentas\PagoServicio.cshtml"
   
}

#line default
#line hidden
#nullable disable
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
