#pragma checksum "D:\Laboratorni-C-Sharp\API\Views\CarDbs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df88a4f8f75551f0b86e5942e78e77966caa80c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CarDbs_Create), @"mvc.1.0.view", @"/Views/CarDbs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df88a4f8f75551f0b86e5942e78e77966caa80c3", @"/Views/CarDbs/Create.cshtml")]
    public class Views_CarDbs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<API.Models.CarDb>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Laboratorni-C-Sharp\API\Views\CarDbs\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>CarDb</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Id"" class=""control-label""></label>
                <input asp-for=""Id"" class=""form-control"" />
                <span asp-validation-for=""Id"" class=""text-danger""></span>
            </div>
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
            <di");
            WriteLiteral(@"v class=""form-group"">
                <label asp-for=""Year"" class=""control-label""></label>
                <input asp-for=""Year"" class=""form-control"" />
                <span asp-validation-for=""Year"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Price"" class=""control-label""></label>
                <input asp-for=""Price"" class=""form-control"" />
                <span asp-validation-for=""Price"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Volume"" class=""control-label""></label>
                <input asp-for=""Volume"" class=""form-control"" />
                <span asp-validation-for=""Volume"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>");
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "D:\Laboratorni-C-Sharp\API\Views\CarDbs\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<API.Models.CarDb> Html { get; private set; }
    }
}
#pragma warning restore 1591