#pragma checksum "C:\Users\bearzi\corsomio\miaPaginaWeb\miaPaginaWeb\Views\Home\Docente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4bdb0d8a4452bf3690b6736b2e183fd23e7fddc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Docente), @"mvc.1.0.view", @"/Views/Home/Docente.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Docente.cshtml", typeof(AspNetCore.Views_Home_Docente))]
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
#line 1 "C:\Users\bearzi\corsomio\miaPaginaWeb\miaPaginaWeb\Views\_ViewImports.cshtml"
using miaPaginaWeb;

#line default
#line hidden
#line 2 "C:\Users\bearzi\corsomio\miaPaginaWeb\miaPaginaWeb\Views\_ViewImports.cshtml"
using miaPaginaWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4bdb0d8a4452bf3690b6736b2e183fd23e7fddc", @"/Views/Home/Docente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e62093a8dded01105bf3942c7d98c691b1a673d4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Docente : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\bearzi\corsomio\miaPaginaWeb\miaPaginaWeb\Views\Home\Docente.cshtml"
  
    ViewData["Title"] = "Docente";

#line default
#line hidden
            BeginContext(45, 463, true);
            WriteLiteral(@"
<div class=""container-fluid"">
    <h1>Ing. Mauro Rainis</h1>

    <div>
        Breve presentazione del docente.
    </div>

    <h2>Principali competenze</h2>
    <ul>
        <li>Postgresql</li>
        <li>Php</li>
        <li>Html</li>
        <li>C#</li>
    </ul>

    <h2>Hobby</h2>
    <div>
        <ol>
            <li>Mountain bike</li>
            <li>Fotografia</li>
            <li>Sci</li>
        </ol>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591