#pragma checksum "C:\Users\mathi\Desktop\ComIT\HiredIn\EspacioNube.web\Views\Postulantes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9cd276f6f21aae3225900f1a0fe43fe4d8ec361"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Postulantes_Index), @"mvc.1.0.view", @"/Views/Postulantes/Index.cshtml")]
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
#line 1 "C:\Users\mathi\Desktop\ComIT\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathi\Desktop\ComIT\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9cd276f6f21aae3225900f1a0fe43fe4d8ec361", @"/Views/Postulantes/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4769e5e174bf13923e6238b438b0549b80f7e1ad", @"/Views/_ViewImports.cshtml")]
    public class Views_Postulantes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-4\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9cd276f6f21aae3225900f1a0fe43fe4d8ec3613576", async() => {
                WriteLiteral(@"
        <label for=""formControlInput"" class=""form-label"">Nombre</label>
<input type=""text"" class=""form-control"" id=""formControlInput"" name=""nombre"">
        <label for=""formControlInput"" class=""form-label"">Apellido</label>
<input type=""text"" class=""form-control"" id=""formControlInput"" name=""apellido"">
        <label for=""formControlInput"" class=""form-label"">DNI</label>
<input type=""text"" class=""form-control"" id=""formControlInput"" name=""dni"">
        <label for=""formControlInput"" class=""form-label"">Telefono</label>
<input type=""tel"" class=""form-control"" id=""formControlInput"" name=""telefono"">
        <label for=""formControlInput"" class=""form-label"">Email</label>
<input type=""email"" class=""form-control"" id=""formControlInput"" name=""email"">
        <label for=""formControlInput"" class=""form-label"">Fecha de nacimiento</label>
<input type=""text"" class=""form-control"" id=""formControlInput"" name=""fechaNacimiento"">
        <label for=""formControlInput"" class=""form-label"">Genero</label>
<input type=""text"" cl");
                WriteLiteral("ass=\"form-control\" id=\"formControlInput\" name=\"genero\" ><br>\r\n\r\n\r\n<input type=\"submit\" class=\"form-control btn btn-primary\" id=\"formControlInput\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1257, "\"", 1271, 0);
                EndWriteAttribute();
                WriteLiteral(" value=\"Enviar\">\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 2 "C:\Users\mathi\Desktop\ComIT\HiredIn\EspacioNube.web\Views\Postulantes\Index.cshtml"
AddHtmlAttributeValue("", 42, Url.Action("crearPostulante"), 42, 30, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
