#pragma checksum "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd93f7602cb04298386176129768e805dabf66f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_admin_Views_Product_CreateSizeToColorToProduct), @"mvc.1.0.view", @"/Areas/admin/Views/Product/CreateSizeToColorToProduct.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\_ViewImports.cshtml"
using Azen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\_ViewImports.cshtml"
using Azen.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\_ViewImports.cshtml"
using Azen.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd93f7602cb04298386176129768e805dabf66f", @"/Areas/admin/Views/Product/CreateSizeToColorToProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e7c8078635a158de1e8c6acceb3079c7a5bd2dc", @"/Areas/admin/Views/_ViewImports.cshtml")]
    public class Areas_admin_Views_Product_CreateSizeToColorToProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateSizeToColorToProduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
  
    ViewData["Title"] = "CreateSizeToColorToProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd93f7602cb04298386176129768e805dabf66f6206", async() => {
                WriteLiteral("\r\n        <div class=\"itemContainer\">\r\n");
#nullable restore
#line 10 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
               int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
             foreach (var item in ViewBag.Colors)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"row ColorImageItem mb-5\" data-index=\"");
#nullable restore
#line 13 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
                                                             Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\r\n                    <div class=\"col-lg-12\">\r\n                        <div class=\"mb-3\">\r\n                            <label class=\"form-label\">Color: <b class=\"text-danger\">");
#nullable restore
#line 16 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
                                                                               Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</b></label>
                        </div>
                    </div>
                    <div class=""col-lg-12 SizeToColorContainer"">
                        <div class=""row SizeToColorItem"">
                            <div class=""col-lg-4"">
                                <div class=""mb-3"">
                                    <label");
                BeginWriteAttribute("for", " for=\"", 935, "\"", 952, 3);
                WriteAttributeValue("", 941, "[", 941, 1, true);
#nullable restore
#line 23 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 942, i, 942, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 944, "].SizeId", 944, 8, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-label\">Size</label>\r\n                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd93f7602cb04298386176129768e805dabf66f9064", async() => {
                    WriteLiteral("\r\n                                        ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd93f7602cb04298386176129768e805dabf66f9372", async() => {
                        WriteLiteral("Select size");
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
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
                    WriteLiteral("\r\n                                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginWriteTagHelperAttribute();
                WriteLiteral("[");
#nullable restore
#line 24 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
                                                            WriteLiteral(i);

#line default
#line hidden
#nullable disable
                WriteLiteral("].SizeId");
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 24 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = (new SelectList(ViewBag.Sizes, "Id", "Name"));

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-4\">\r\n                                <div class=\"mb-3\">\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 1480, "\"", 1496, 3);
                WriteAttributeValue("", 1486, "[", 1486, 1, true);
#nullable restore
#line 31 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 1487, i, 1487, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1489, "].Price", 1489, 7, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-label\">Price</label>\r\n                                    <input type=\"number\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1609, "\"", 1626, 3);
                WriteAttributeValue("", 1616, "[", 1616, 1, true);
#nullable restore
#line 32 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 1617, i, 1617, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1619, "].Price", 1619, 7, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-lg-4\">\r\n                                <div class=\"mb-3\">\r\n                                    <label");
                BeginWriteAttribute("for", " for=\"", 1852, "\"", 1871, 3);
                WriteAttributeValue("", 1858, "[", 1858, 1, true);
#nullable restore
#line 37 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 1859, i, 1859, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1861, "].Quantity", 1861, 10, true);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-label\">Quantity</label>\r\n                                    <input type=\"number\" class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 1987, "\"", 2007, 3);
                WriteAttributeValue("", 1994, "[", 1994, 1, true);
#nullable restore
#line 38 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 1995, i, 1995, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1997, "].Quantity", 1997, 10, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                </div>\r\n                            </div>\r\n                            <input hidden class=\"form-control\"");
                BeginWriteAttribute("name", " name=\"", 2149, "\"", 2168, 3);
                WriteAttributeValue("", 2156, "[", 2156, 1, true);
#nullable restore
#line 41 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 2157, i, 2157, 2, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2159, "].ColorId", 2159, 9, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 2169, "\"", 2185, 1);
#nullable restore
#line 41 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
WriteAttributeValue("", 2177, item.Id, 2177, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col-lg-12\">\r\n                        <button type=\"button\" class=\"btn btn-success addNewItem\" data-index=\"");
#nullable restore
#line 45 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"
                                                                                         Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\">+</button>\r\n                    </div>\r\n\r\n                    <hr />\r\n                </div>\r\n");
#nullable restore
#line 50 "D:\Code Academy\Teaching\AzTU-Code\AzTU-P101\Lessons\66.11.01.2022-Shopping\Codes\Azen\Azen\Areas\admin\Views\Product\CreateSizeToColorToProduct.cshtml"

                i++;
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-12\">\r\n                <button type=\"submit\" class=\"btn btn-primary\">Next</button>\r\n            </div>\r\n        </div>\r\n\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
