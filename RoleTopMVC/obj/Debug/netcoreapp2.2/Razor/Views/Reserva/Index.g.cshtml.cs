#pragma checksum "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bc69d29d2bb183e7a4058bf45f3fec50757b7f0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reserva_Index), @"mvc.1.0.view", @"/Views/Reserva/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reserva/Index.cshtml", typeof(AspNetCore.Views_Reserva_Index))]
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
#line 1 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC;

#line default
#line hidden
#line 2 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\_ViewImports.cshtml"
using RoleTopMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bc69d29d2bb183e7a4058bf45f3fec50757b7f0", @"/Views/Reserva/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1fae5be29b1d0446bbdb7fe81a11990f47b34647", @"/Views/_ViewImports.cshtml")]
    public class Views_Reserva_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleTopMVC.ViewModels.ReservaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(48, 166, true);
            WriteLiteral("        <section id=\"conta\">\r\n    <div class=\"perfil\">\r\n        <img src=\"../img/profile.png\" height=\"80px\" width=\"80px\">\r\n        </div>\r\n\r\n    <main>\r\n             ");
            EndContext();
            BeginContext(214, 2750, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc69d29d2bb183e7a4058bf45f3fec50757b7f04369", async() => {
                BeginContext(278, 966, true);
                WriteLiteral(@"
            

                    <div>
                            <label for=""Nome"">Nome Completo</label>
                            <br />
                            <input id=""nome"" type=""name"" name=""nome"" />
                        </div>
                
                <div>
                    <label for=""email"">E-mail</label>
                    <br />
                    <input id=""email"" type=""email"" name=""email"" placeholder=""Ex.: roletop@email.com"" />
                </div>
    
                <div>
                    <label for=""cpf"">CPF</label>
                    <br />
                    <input id=""cpf"" type=""text"" name=""cpf"" class=""form-control cpf-mask"" placeholder=""Ex.: 000.000.000-00"">
                </div>
                        <div>
                            <label for=""eventos"">Tipo de Evento</label>
                            <select id=""eventos"" name=""evento"" >
                                ");
                EndContext();
                BeginContext(1244, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc69d29d2bb183e7a4058bf45f3fec50757b7f05752", async() => {
                    BeginContext(1279, 9, true);
                    WriteLiteral("Selecione");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1297, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 32 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
                                 foreach (var evento in Model.Eventos)
                                {

#line default
#line hidden
                BeginContext(1406, 36, true);
                WriteLiteral("                                    ");
                EndContext();
                BeginContext(1442, 148, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0bc69d29d2bb183e7a4058bf45f3fec50757b7f08245", async() => {
                    BeginContext(1472, 11, false);
#line 34 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
                                                            Write(evento.Nome);

#line default
#line hidden
                    EndContext();
                    BeginContext(1483, 5, true);
                    WriteLiteral(" por ");
                    EndContext();
                    BeginContext(1489, 12, false);
#line 34 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
                                                                             Write(evento.Preco);

#line default
#line hidden
                    EndContext();
                    BeginContext(1501, 80, true);
                    WriteLiteral("\r\n                                        \r\n                                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 34 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
                                       WriteLiteral(evento.Nome);

#line default
#line hidden
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
                EndContext();
                BeginContext(1590, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
                                }

#line default
#line hidden
                BeginContext(1627, 1330, true);
                WriteLiteral(@"                            </select>

                                
                            <input type=""email"" class=""form-control"" id=""exampleInputEmail1"" placeholder=""Outro? Qual?"">


                        </div>
                        <div>
                            <label for=""data"">Data do Evento</label>
                            <br>
                            <input id=""data"" required type=""date"" autocomplete=""off"">
                        </div>


                        <label>Forma de Pagamento</label>
                        <div class=""radio"">
                            <input name=""radios"" type=""radio"" id=""radio-button-1"">
                            <label for=""radio-button-1"">Crédito</label>
                        </div>
                        <div class=""radio"">
                            <input name=""radios"" type=""radio"" id=""radio-button-2"">
                            <label for=""radio-button-2"">Débito</label>
                        </div>
       ");
                WriteLiteral(@"                 <div class=""radio"">
                            <input name=""radios"" type=""radio"" id=""radio-button-3"">
                            <label for=""radio-button-3"">Boleto</label>
                        </div>


    
                <input type=""submit"" value=""Reservar"" />
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
#line 8 "C:\Users\51663853819\Documents\Exercicios\RoleTopMVC\Views\Reserva\Index.cshtml"
AddHtmlAttributeValue("", 242, Url.Action("Registrar","Reserva"), 242, 34, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2964, 33, true);
            WriteLiteral("\r\n        </main>\r\n    </section>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleTopMVC.ViewModels.ReservaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
