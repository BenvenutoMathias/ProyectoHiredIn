#pragma checksum "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0cd77d4a34ceb15a0c19784a91980b174ce1da6"
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
#line 1 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\_ViewImports.cshtml"
using EspacioNube.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml"
using EspacioNube.web.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0cd77d4a34ceb15a0c19784a91980b174ce1da6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebf15dec159ef010893d2bc3a7c4151922caea3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    User loggedUser = await UserManager.GetUserAsync(User);
    if (await UserManager.IsInRoleAsync(loggedUser, "SuperAdmin"))
    {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <tr>
                <th><a class=""nav-link"">Crear Post</a></th>
                <th><a class=""nav-link"">Crear Empresa</a></th>
                <th><a class=""nav-link"">Consultar Empresas</a></th>
                <th><a class=""nav-link"">Consultar Postulantes</a></th>
            </tr>
        </table>
");
#nullable restore
#line 22 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml"

    }

    if (await UserManager.IsInRoleAsync(loggedUser, "UserDefault"))
    {

    }

    if (await UserManager.IsInRoleAsync(loggedUser, "Empresa"))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table"">
            <tr>
                <th><a class=""nav-link"">Crear Post</a></th>
                <th><a class=""nav-link"">Crear Empresa</a></th>
                <th><a class=""nav-link"">Consultar Empresas</a></th>
                <th><a class=""nav-link"">Consultar Postulantes</a></th>
            </tr>
        </table>
");
#nullable restore
#line 40 "C:\Users\Matias\Desktop\Proyectos\HiredIn\EspacioNube.web\Views\Home\Index.cshtml"
    }

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<User> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<User> SignInManager { get; private set; }
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
