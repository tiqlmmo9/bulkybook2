#pragma checksum "C:\Users\ich\source\repos\BulkyBook\BulkyBook\Views\Shared\Components\UserName\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c752bf883df9334a4fb97d3f22c96cdb3af0ba7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_UserName_Default), @"mvc.1.0.view", @"/Views/Shared/Components/UserName/Default.cshtml")]
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
#line 1 "C:\Users\ich\source\repos\BulkyBook\BulkyBook\Views\_ViewImports.cshtml"
using BulkyBook;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ich\source\repos\BulkyBook\BulkyBook\Views\_ViewImports.cshtml"
using BulkyBook.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c752bf883df9334a4fb97d3f22c96cdb3af0ba7", @"/Views/Shared/Components/UserName/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b283f6c8c7163b5f5d1f909d7b66a1ed4e3ccc1", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_UserName_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BulkyBook.Models.ApplicationUser>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\nHi! ");
#nullable restore
#line 3 "C:\Users\ich\source\repos\BulkyBook\BulkyBook\Views\Shared\Components\UserName\Default.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"far fa-user\"></i>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BulkyBook.Models.ApplicationUser> Html { get; private set; }
    }
}
#pragma warning restore 1591
