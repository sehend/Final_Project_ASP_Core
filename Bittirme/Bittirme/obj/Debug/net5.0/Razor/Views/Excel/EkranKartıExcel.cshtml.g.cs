#pragma checksum "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3b99788bfcc849614cdbc0ef2414f761451327cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Excel_EkranKartıExcel), @"mvc.1.0.view", @"/Views/Excel/EkranKartıExcel.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3b99788bfcc849614cdbc0ef2414f761451327cc", @"/Views/Excel/EkranKartıExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4abbfb62ad405ee73e08069fc0d2ba5ef4a29f", @"/Views/_ViewImports.cshtml")]
    public class Views_Excel_EkranKartıExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Core.Models.Ekrankarti>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b99788bfcc849614cdbc0ef2414f761451327cc4515", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <title>Bootstrap 4 Responsive Datatable and Export to PDF, CSV</title>
    <link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.1.1/css/bootstrap.css"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.19/css/dataTables.bootstrap4.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/buttons/1.5.2/css/buttons.bootstrap4.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/responsive/2.2.3/css/responsive.bootstrap4.min.css"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b99788bfcc849614cdbc0ef2414f761451327cc6046", async() => {
                WriteLiteral(@"
    <table id=""example"" class=""table table-striped table-bordered dt-responsive nowrap"" style=""width:100%"">
        <thead>
            <tr>
                <th>
                    imageName
                </th>
                <th>
                    Aciklama
                </th>
                <th>
                    Fiyat
                </th>


                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 35 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3b99788bfcc849614cdbc0ef2414f761451327cc7104", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
                BeginWriteTagHelperAttribute();
                WriteLiteral("~/image/EkranKartı/");
#nullable restore
#line 39 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
                                         WriteLiteral(item.imageName);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 39 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 42 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Aciklama));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 45 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Fiyat));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n\r\n                </tr>\r\n");
#nullable restore
#line 50 "C:\Users\sehen\OneDrive\Masaüstü\Bittirme - Kopya\Bittirme\Views\Excel\EkranKartıExcel.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        </tbody>
    </table>
    <script src=""https://code.jquery.com/jquery-3.3.1.js""></script>
    <script src=""https://cdn.datatables.net/1.10.19/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.19/js/dataTables.bootstrap4.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/dataTables.buttons.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.bootstrap4.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jszip/3.1.3/jszip.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/pdfmake.min.js""></script>
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/pdfmake/0.1.36/vfs_fonts.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.html5.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/buttons.print.min.js""></script>
    <script src=""https://cdn.datatables.net/buttons/1.5.2/js/b");
                WriteLiteral(@"uttons.colVis.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.3/js/dataTables.responsive.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.3/js/responsive.bootstrap4.min.js""></script>
    <script>
        $(document).ready(function () {
            var table = $('#example').DataTable({
                lengthChange: false,
                buttons: ['copy', 'excel', 'csv', 'pdf', 'colvis']
            });

            table.buttons().container()
                .appendTo('#example_wrapper .col-md-6:eq(0)');
        });
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Core.Models.Ekrankarti>> Html { get; private set; }
    }
}
#pragma warning restore 1591
