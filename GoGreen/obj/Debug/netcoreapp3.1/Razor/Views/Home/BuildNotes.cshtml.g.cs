#pragma checksum "C:\Users\Luccan\source\repos\luccan\GoGreen\GoGreen\Views\Home\BuildNotes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0c51bc76a70067d4adab2db2eb198245957b8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_BuildNotes), @"mvc.1.0.view", @"/Views/Home/BuildNotes.cshtml")]
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
#line 1 "C:\Users\Luccan\source\repos\luccan\GoGreen\GoGreen\Views\_ViewImports.cshtml"
using GoGreen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Luccan\source\repos\luccan\GoGreen\GoGreen\Views\_ViewImports.cshtml"
using GoGreen.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0c51bc76a70067d4adab2db2eb198245957b8e", @"/Views/Home/BuildNotes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cfd9ce8045106bcd8460e95c2fc6d232c718a422", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_BuildNotes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Luccan\source\repos\luccan\GoGreen\GoGreen\Views\Home\BuildNotes.cshtml"
  
    ViewData["Title"] = "Build Notes";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 4 "C:\Users\Luccan\source\repos\luccan\GoGreen\GoGreen\Views\Home\BuildNotes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<p>
    Required Specs:<br />
    <ol>
        <li>SQL Server 2016 (for localdb) with instance name (localdb)\MSSQLLocalDB</li>
        <li>Windows OS x64</li>
    </ol>

    Deployment:
    <ol>
        <li>Unzip files</li>
        <li>Run deployRelease.ps1 in admin mode.</li>
    </ol>

    GET Methods:
    <ol>
        <li>http://localhost:5000/Vegetable/Index?isApi=True</li>
        <li>http://localhost:5000/Vegetable/Index?id=1&search=isApi=True</li>
        <li>http://localhost:5000/Vegetable/Index?id=&search=carr&isApi=True</li>
        <li>http://localhost:5000/Vegetable/Details?id=1&isApi=True</li>
    </ol>

    POST Methods:
    <ol>
        <li>http://localhost:5000/Vegetable/Create?isApi=True (Expecting Name, Price in request Body)</li>
        <li>http://localhost:5000/Vegetable/Edit?isApi=True (Expecting Id, Name, Price in request Body)</li>
        <li>http://localhost:5000/Vegetable/Delete?isApi=True (Expecting Id in request Body)</li>
    </ol>
</p>");
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