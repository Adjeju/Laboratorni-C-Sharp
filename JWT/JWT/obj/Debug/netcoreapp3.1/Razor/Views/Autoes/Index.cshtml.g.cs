#pragma checksum "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faab94ab45098efdee8184328651d8b1159ceff9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autoes_Index), @"mvc.1.0.view", @"/Views/Autoes/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faab94ab45098efdee8184328651d8b1159ceff9", @"/Views/Autoes/Index.cshtml")]
    #nullable restore
    public class Views_Autoes_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<JWT.Models.Auto>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Volume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Mark));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Volume));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1332, "\"", 1357, 1);
#nullable restore
#line 52 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
WriteAttributeValue("", 1347, item.Code, 1347, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1410, "\"", 1435, 1);
#nullable restore
#line 53 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
WriteAttributeValue("", 1425, item.Code, 1425, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1490, "\"", 1515, 1);
#nullable restore
#line 54 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
WriteAttributeValue("", 1505, item.Code, 1505, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<JWT.Models.Auto>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
