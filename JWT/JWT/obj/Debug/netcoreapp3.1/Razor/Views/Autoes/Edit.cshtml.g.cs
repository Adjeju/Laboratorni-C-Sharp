#pragma checksum "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00abb91458514a418b0597decbb239c2daf1377b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Autoes_Edit), @"mvc.1.0.view", @"/Views/Autoes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00abb91458514a418b0597decbb239c2daf1377b", @"/Views/Autoes/Edit.cshtml")]
    #nullable restore
    public class Views_Autoes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JWT.Models.Auto>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Auto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Code"" />
            <div class=""form-group"">
                <label asp-for=""Mark"" class=""control-label""></label>
                <input asp-for=""Mark"" class=""form-control"" />
                <span asp-validation-for=""Mark"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Color"" class=""control-label""></label>
                <input asp-for=""Color"" class=""form-control"" />
                <span asp-validation-for=""Color"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""t");
            WriteLiteral(@"ext-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Year"" class=""control-label""></label>
                <input asp-for=""Year"" class=""form-control"" />
                <span asp-validation-for=""Year"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Volume"" class=""control-label""></label>
                <input asp-for=""Volume"" class=""form-control"" />
                <span asp-validation-for=""Volume"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 53 "D:\Laboratorni-C-Sharp\JWT\JWT\Views\Autoes\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JWT.Models.Auto> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591