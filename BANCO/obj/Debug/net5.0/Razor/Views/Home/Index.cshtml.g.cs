#pragma checksum "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c51afc2f416a8127c77dbc62925d08f541271287"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c51afc2f416a8127c77dbc62925d08f541271287", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87a29d5e8c19b3036da8c34cac19d58e682403ea", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "InicioSesion", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Cristopher Amaya\Documents\Proyecto banco final\BANCO\BANCO\Views\Home\Index.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51afc2f416a8127c77dbc62925d08f5412712875265", async() => {
                WriteLiteral("\r\n\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    <meta name=\"description\"");
                BeginWriteAttribute("content", " content=\"", 260, "\"", 270, 0);
                EndWriteAttribute();
                WriteLiteral(@">
    <meta name=""author"" content=""BANCO AUML"">
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Roboto:wght@100;300;400;500;700;900&display=swap"" rel=""stylesheet"">

    <title>Prueba Index</title>

    <!-- Bootstrap core CSS -->
    <link href=""vendor/bootstrap/css/bootstrap.min.css"" rel=""stylesheet"">

    <!-- Additional CSS Files -->
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.8.1/css/all.css"" integrity=""sha384-50oBUHEmvpQ+1lW4y57PTFmhCaXp0ML5d60M1M7uH2+nqUivzIebhndOJK28anvf"" crossorigin=""anonymous"">
    <link rel=""stylesheet"" href=""assets/css/templatemo-chain-app-dev.css"">
    <link rel=""stylesheet"" href=""assets/css/animated.css"">
    <link rel=""stylesheet"" href=""assets/css/owl.css"">

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51afc2f416a8127c77dbc62925d08f5412712877486", async() => {
                WriteLiteral(@"

    <!-- ***** Header Area Start ***** -->
    <header class=""header-area header-sticky wow slideInDown"" data-wow-duration=""0.75s"" data-wow-delay=""0s"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-12"">
                    <nav class=""main-nav"">
                        <!-- ***** Logo Start ***** -->
                        <a class=""logo"">
                            <img src=""assets/images/logo.png"" width=""96"" height=""45"" alt=""Banco AUML"">
                        </a>
                        <!-- ***** Logo End ***** -->
                        <ul class=""nav"">
                            <li class=""scroll-to-section""><a href=""#top"" class=""active"">Inicio</a></li>
                            <li class=""scroll-to-section""><a href=""#services"">E-Banca</a></li>
                            <li class=""scroll-to-section""><a href=""#about"">Sobre Nosotros</a></li>
                            <li><div class=""gradient-button"">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51afc2f416a8127c77dbc62925d08f5412712878779", async() => {
                    WriteLiteral("<i class=\"fa fa-sign-in-alt\"></i>Iniciar Sesion");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"</div></li>
                        </ul>
                        <a class='menu-trigger'>
                            <span>Menu</span>
                        </a>
                    </nav>
                </div>
            </div>
        </div>
    </header>
    <!-- ***** Header Area End ***** -->

    <div class=""main-banner wow fadeIn"" id=""top"" data-wow-duration=""1s"" data-wow-delay=""0.5s"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-12"">
                    <div class=""row"">
                        <div class=""col-lg-6 align-self-center"">
                            <div class=""left-content show-up header-text wow fadeInLeft"" data-wow-duration=""1s"" data-wow-delay=""1s"">
                                <div class=""row"">
                                    <div class=""col-lg-12"">
                                        <h2>E-BANCA AUML</h2>
                                        <p>
                                            Re");
                WriteLiteral(@"aliza todas tus transacciones y pagos, desde cualquier lugar y en el momento que lo necesites de forma fácil y segura desde tu e-banca AUML..
                                        </p>
                                    </div>
                                    <div class=""col-lg-12"">
                                        <div class=""white-button scroll-to-section"">
                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c51afc2f416a8127c77dbc62925d08f54127128712063", async() => {
                    WriteLiteral("Registrarse <i class=\"fa fa-sign-in-alt\"></i>");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""right-image wow fadeInRight"" data-wow-duration=""1s"" data-wow-delay=""0.5s"">
                                <img src=""assets/images/slider-dec.png""");
                BeginWriteAttribute("alt", " alt=\"", 4341, "\"", 4347, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div id=""services"" class=""services section"">
        <div class=""container d-flex justify-content-center"">
            <div class=""row"">
                <div class=""col-lg-8 offset-lg-2"">
                    <div class=""section-heading  wow fadeInDown"" data-wow-duration=""1s"" data-wow-delay=""0.5s"">
                        <h4>e-banca AUML llena de <em>beneficios</em> para ti</h4>
                        <img src=""assets/images/heading-line-dec.png""");
                BeginWriteAttribute("alt", " alt=\"", 4982, "\"", 4988, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <p>Todo lo que tardarias en el banco al alcance de un clic sin necesidad de salir de tu casa!</p>
                    </div>
                </div>
            </div>
        </div>
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""service-item first-service"">
                        <div class=""icon""></div>
                        <h4>Interfaz simplificada</h4>
                        <p>La e-banca cuenta con una interfaz simplificada que hace más fácil realizar operaciones con tus cuentas.</p>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""service-item second-service"">
                        <div class=""icon""></div>
                        <h4>Ambiente comodo</h4>
                        <p>Dedicamos cada detalle para que no tengas problemas en encontrar todo lo que necesitas</p>
                    </div>");
                WriteLiteral(@"
                </div>
                <div class=""col-lg-3"">
                    <div class=""service-item third-service"">
                        <div class=""icon""></div>
                        <h4>Ayuda y asistencia</h4>
                        <p>Puedes contactarte con nosotros por nuestro numero de asistencia o en cualquiera de nuestras redes sociales</p>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div id=""about"" class=""about-us section"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 align-self-center"">
                    <div class=""section-heading"">
                        <h4>Sobre <em>Nosotros</em></h4>
                        <img src=""assets/images/heading-line-dec.png""");
                BeginWriteAttribute("alt", " alt=\"", 6834, "\"", 6840, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        <p>Somos el principal aliado de nuestros clientes en la satisfacción de sus necesidades financieras, con productos innovadores y un elevado nivel de eficiencia y servicio, a través de un equipo comprometido, motivado y de alto desempeño. Generamos valor para nuestros clientes, colaboradores, accionistas y la comunidad.</p>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""box-item"">
                                <h4><a href=""#"">Compromiso</a></h4>
                                <p>Comprometidos a brindar servicios confiables y éticos, cumpliendo con las expectativas de los clientes y manteniendo altos estándares de calidad.</p>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""box-item"">
                                <h4><a href=""#"">Excelencia del servicio</a></h4>");
                WriteLiteral(@"
                                <p>Nos esforzamos por ofrecer una experiencia excepcional a nuestros clientes, brindando atención personalizada y resolviendo problemas eficientemente.</p>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""box-item"">
                                <h4><a href=""#"">Innovacion</a></h4>
                                <p>Nos adaptamos contigo desarrollando productos y servicios financieros innovadores y ofreciendo soluciones tecnológicas avanzadas.</p>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""box-item"">
                                <h4><a href=""#"">Seguridad</a></h4>
                                <p>La protección de los activos financieros y datos de los clientes por medio de una seguridad robusta y cumpliendo con normativas de seguridad financiera.</p>");
                WriteLiteral(@"
                            </div>
                        </div>
                        <div class=""col-lg-12"">
                            <p>“Ser un banco moderno, sostenible y accesible a todos los salvadoreños, que ofrece una experiencia de servicio cercana y de calidad a sus clientes y usuarios”.</p>
                        </div>
                    </div>
                </div>
                <div class=""col-lg-6"">
                    <div class=""right-image"">
                        <img src=""assets/images/about-right-dec.png""");
                BeginWriteAttribute("alt", " alt=\"", 9443, "\"", 9449, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    </div>
                </div>
            </div>
        </div>
    </div>

    <footer id=""newsletter"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3"">
                    <div class=""footer-widget"">
                        <h4>Contáctanos</h4>
                        <p>El Salvador - ESV, 22795-008, El Salvador</p>
                        <p><a href=""#"">010-020-0340</a></p>
                        <p><a href=""#"">info@bancoauml.co.sv</a></p>
                    </div>
                </div>
                <div class=""col-lg-3"">
                    <div class=""footer-widget"">
                        <h4>Sobre Nosotros</h4>
                        <ul>
                            <li><a href=""#"">Home</a></li>
                            <li><a href=""#"">Sobre Nosotros</a></li>
                        </ul>
                    </div>
                </div>
                <div class=""col-lg-3"">
               ");
                WriteLiteral("     <div class=\"footer-widget\">\r\n                        <h4>Banco AUML </h4>\r\n                        <div class=\"logo\">\r\n                            <img src=\"assets/images/white-logo.png\"");
                BeginWriteAttribute("alt", " alt=\"", 10665, "\"", 10671, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                        </div>
                        <p>Nuestro compromiso es brindar servicios financieros confiables y seguros</p>
                    </div>
                </div>
                <div class=""col-lg-12"">
                    <div class=""copyright-text"">
                        <p>
                            Copyright © 2023 Banco AUML.Todos los derechos reservados.
                            <br>Design: <a href=""https://templatemo.com/"" target=""_blank"" title=""css templates"">TemplateMo</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>


    <!-- Scripts -->
    <script src=""vendor/jquery/jquery.min.js""></script>
    <script src=""vendor/bootstrap/js/bootstrap.bundle.min.js""></script>
    <script src=""assets/js/owl-carousel.js""></script>
    <script src=""assets/js/animation.js""></script>
    <script src=""assets/js/imagesloaded.js""></script>
    <script src=""assets/js/popup.js""></script");
                WriteLiteral(">\r\n    <script src=\"assets/js/custom.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
