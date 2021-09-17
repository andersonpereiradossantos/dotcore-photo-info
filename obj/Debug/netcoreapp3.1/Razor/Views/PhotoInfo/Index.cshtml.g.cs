#pragma checksum "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "712198f4eb254a8c7e176e1948419c051bac1b0b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PhotoInfo_Index), @"mvc.1.0.view", @"/Views/PhotoInfo/Index.cshtml")]
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
#line 1 "D:\Projetos\Portfolio\PhotoInfo\Views\_ViewImports.cshtml"
using PhotoInfo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projetos\Portfolio\PhotoInfo\Views\_ViewImports.cshtml"
using PhotoInfo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"712198f4eb254a8c7e176e1948419c051bac1b0b", @"/Views/PhotoInfo/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"87d070b8bd3897812c3d71d4ef10eff311ba042f", @"/Views/_ViewImports.cshtml")]
    public class Views_PhotoInfo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExifPhotoReader.ExifImageProperties>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UploadImage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-row align-items-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
  
    ViewData["Title"] = "Photo Info";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">EXIF Photo Reader</h1>
    <p>
        Example in .NET Core MVC to get EXIF ​​data from images with <a target=""_blank"" href=""https://www.nuget.org/packages/ExifPhotoReader/""><b>EXIF ​​Photo Reader</b></a> library.
    </p>
</div>

<div class=""card"">
    <div class=""card-header"">
        Upload File
    </div>
    <div class=""card-body"">
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "712198f4eb254a8c7e176e1948419c051bac1b0b5168", async() => {
                WriteLiteral(@"
            <div class=""col-sm-10 my-1"">
                <label class=""sr-only"" for=""file"">Image</label>
                <input type=""file"" name=""file"" class=""form-control"" />
            </div>
            <div class=""col-sm-2 my-1"">
                <button type=""submit"" class=""btn btn-primary"">Upload</button>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 28 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"row mt-3\">\r\n                <div class=\"col d-flex justify-content-center\">\r\n                    <img style=\"width: 100px;\" class=\"img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 1179, "\"", 1205, 1);
#nullable restore
#line 32 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
WriteAttributeValue("", 1185, ViewBag.imageBase64, 1185, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 35 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </div>
</div>
<hr />
<div class=""card"">
    <div class=""card-header"">
        EXIF
    </div>
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th>Property</th>
                    <th>Value</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 52 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                  
                    if (Model != null)
                    {
                        foreach (System.Reflection.PropertyInfo prop in typeof(ExifPhotoReader.ExifImageProperties).GetProperties())
                        {
                            if (@prop.GetValue(Model, null) != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                 if (!prop.PropertyType.Name.Contains("GPS"))
                                {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n                                        <td>");
#nullable restore
#line 63 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                       Write(prop.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        <td>");
#nullable restore
#line 64 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                       Write(prop.GetValue(Model, null).ToString().Trim('\0'));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
#nullable restore
#line 66 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                }
                                else
                                {
                                    foreach (System.Reflection.PropertyInfo gps in typeof(ExifPhotoReader.Types.GPSInfo).GetProperties())
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>");
#nullable restore
#line 72 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                           Write(gps.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                            <td>");
#nullable restore
#line 73 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                           Write(gps.GetValue(Model.GPSInfo, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                        </tr>\r\n");
#nullable restore
#line 75 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                    }
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                                 
                            }
                        }
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td colspan=\"2\">Upload file image</td>\r\n                        </tr>\r\n");
#nullable restore
#line 85 "D:\Projetos\Portfolio\PhotoInfo\Views\PhotoInfo\Index.cshtml"
                    }
                

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExifPhotoReader.ExifImageProperties> Html { get; private set; }
    }
}
#pragma warning restore 1591