#pragma checksum "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c62cad01fa7c9e5f3a5cc9bca757659174126dca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TblMudurs_Index), @"mvc.1.0.view", @"/Views/TblMudurs/Index.cshtml")]
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
#line 1 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\_ViewImports.cshtml"
using Bittirme;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\_ViewImports.cshtml"
using Bittirme.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c62cad01fa7c9e5f3a5cc9bca757659174126dca", @"/Views/TblMudurs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4abbfb62ad405ee73e08069fc0d2ba5ef4a29f", @"/Views/_ViewImports.cshtml")]
    public class Views_TblMudurs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.TblMudur>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout2.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62cad01fa7c9e5f3a5cc9bca757659174126dca5322", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 209, "\"", 250, 1);
#nullable restore
#line 13 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 216, Url.Action("Index","Ekrankartis"), 216, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Ekrankartis</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 295, "\"", 329, 1);
#nullable restore
#line 14 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 302, Url.Action("Index","mice"), 302, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Mouse</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 368, "\"", 402, 1);
#nullable restore
#line 15 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 375, Url.Action("Index","rams"), 375, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">rams</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 440, "\"", 474, 1);
#nullable restore
#line 16 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 447, Url.Action("Index","ssds"), 447, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">ssds</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 512, "\"", 553, 1);
#nullable restore
#line 17 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 519, Url.Action("Index","TblMusteris"), 519, 34, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">MüşteriLer</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 597, "\"", 639, 1);
#nullable restore
#line 18 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 604, Url.Action("Index","TblPersonels"), 604, 35, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Personel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 681, "\"", 719, 1);
#nullable restore
#line 19 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 688, Url.Action("Index","TblSatis"), 688, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Satıs</a>\r\n\r\n\r\n<a");
            BeginWriteAttribute("href", " href=\"", 762, "\"", 805, 1);
#nullable restore
#line 22 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 769, Url.Action("PersonelExcel","Excel"), 769, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Personel Excel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 853, "\"", 896, 1);
#nullable restore
#line 23 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 860, Url.Action("MusterisExcel","Excel"), 860, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Müsteri Excel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 943, "\"", 981, 1);
#nullable restore
#line 24 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 950, Url.Action("RamExcel","Excel"), 950, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">RamExcel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1023, "\"", 1068, 1);
#nullable restore
#line 25 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 1030, Url.Action("EkranKartıExcel","Excel"), 1030, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">EkranKartıExcel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1117, "\"", 1157, 1);
#nullable restore
#line 26 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 1124, Url.Action("mouseExcel","Excel"), 1124, 33, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">mouseExcel</a>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1201, "\"", 1239, 1);
#nullable restore
#line 27 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
WriteAttributeValue("", 1208, Url.Action("ssdExcel","Excel"), 1208, 31, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">ssdExcel</a>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 33 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.imageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 36 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 39 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 42 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 45 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 48 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 51 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 54 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MüdürMaaş));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 57 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Urunıd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 60 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Adminıd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 66 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c62cad01fa7c9e5f3a5cc9bca757659174126dca15822", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
            WriteLiteral("~/image/Mudur/");
#nullable restore
#line 70 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
                                WriteLiteral(item.imageName);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 70 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 73 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 76 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Soyad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 79 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 82 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 85 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Tel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 88 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 91 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MüdürMaaş));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 94 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Urunıd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 97 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Adminıd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                   \r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62cad01fa7c9e5f3a5cc9bca757659174126dca21511", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 101 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
                                              WriteLiteral(item.Müdürıd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c62cad01fa7c9e5f3a5cc9bca757659174126dca23705", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 102 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
                                             WriteLiteral(item.Müdürıd);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 105 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\TblMudurs\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.TblMudur>> Html { get; private set; }
    }
}
#pragma warning restore 1591
