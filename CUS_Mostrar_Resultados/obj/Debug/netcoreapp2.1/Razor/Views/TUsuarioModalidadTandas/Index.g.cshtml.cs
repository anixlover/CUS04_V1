#pragma checksum "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43d338d195a7813fc9888a4d64a7f025945d073b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuarioModalidadTandas_Index), @"mvc.1.0.view", @"/Views/TUsuarioModalidadTandas/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuarioModalidadTandas/Index.cshtml", typeof(AspNetCore.Views_TUsuarioModalidadTandas_Index))]
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
#line 1 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\_ViewImports.cshtml"
using CUS_Mostrar_Resultados;

#line default
#line hidden
#line 2 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\_ViewImports.cshtml"
using CUS_Mostrar_Resultados.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d338d195a7813fc9888a4d64a7f025945d073b", @"/Views/TUsuarioModalidadTandas/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d79c126a6059bac3314c9beb8e61dc0982dd54d3", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuarioModalidadTandas_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CUS_Mostrar_Resultados.Models.TUsuarioModalidadTanda>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(74, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(117, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(146, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf85f2b9f81747838cfca5770f949a46", async() => {
                BeginContext(169, 10, true);
                WriteLiteral("Create New");
                EndContext();
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
            EndContext();
            BeginContext(183, 328, true);
            WriteLiteral(@"
</p>
<table class=""table"">
    <thead>
        <tr>
            <th class=""text-center"">
                    C&oacute;digo de Participante
            </th>
            <th>
                Modalidad
            </th>
            <th>
                Categoría
            </th>
            <th>
                ");
            EndContext();
            BeginContext(512, 59, false);
#line 25 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIumtCodPartNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(571, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(627, 58, false);
#line 28 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.FkIumtCodTanNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(685, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(803, 68, true);
            WriteLiteral("        <tr>\r\n            <td class=\"text-center\">\r\n                ");
            EndContext();
            BeginContext(872, 69, false);
#line 37 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIumtCodPartNavigation.PkIumCodUm));

#line default
#line hidden
            EndContext();
            BeginContext(941, 39, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
            EndContext();
#line 40 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                 if (item.FkIumtCodPartNavigation.FkImIdModalidad == 2)
                {

#line default
#line hidden
            BeginContext(1072, 34, true);
            WriteLiteral("                    <p>Novel</p>\r\n");
            EndContext();
#line 43 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1125, 16, true);
            WriteLiteral("                ");
            EndContext();
#line 44 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                 if (item.FkIumtCodPartNavigation.FkImIdModalidad == 1)
                {

#line default
#line hidden
            BeginContext(1217, 38, true);
            WriteLiteral("                    <p> Seriado </p>\r\n");
            EndContext();
#line 47 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                }
                

#line default
#line hidden
            BeginContext(1371, 53, true);
            WriteLiteral("            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1425, 93, false);
#line 51 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIumtCodPartNavigation.FkIuDniNavigation.FkIuCodCategoria));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 73, true);
            WriteLiteral("\r\n                \r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1592, 66, false);
#line 55 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIumtCodPartNavigation.FkIuDni));

#line default
#line hidden
            EndContext();
            BeginContext(1658, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1714, 71, false);
#line 58 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.FkIumtCodTanNavigation.VtDescripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1785, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1840, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "568ac3475b7249919df5092b939e1b3b", async() => {
                BeginContext(1892, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 61 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                                       WriteLiteral(item.PkVumtCod);

#line default
#line hidden
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
            EndContext();
            BeginContext(1900, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1920, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "66da2d14eb314e559e6fdf7ff1e70cb8", async() => {
                BeginContext(1975, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                                          WriteLiteral(item.PkVumtCod);

#line default
#line hidden
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
            EndContext();
            BeginContext(1986, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(2006, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5c5acdce7cac4b4692f5554cdb378c3c", async() => {
                BeginContext(2060, 6, true);
                WriteLiteral("Delete");
                EndContext();
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
#line 63 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
                                         WriteLiteral(item.PkVumtCod);

#line default
#line hidden
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
            EndContext();
            BeginContext(2070, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 66 "C:\Users\Anita\Desktop\CUS_Mostrar_Resultados\CUS_Mostrar_Resultados\Views\TUsuarioModalidadTandas\Index.cshtml"
}

#line default
#line hidden
            BeginContext(2109, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CUS_Mostrar_Resultados.Models.TUsuarioModalidadTanda>> Html { get; private set; }
    }
}
#pragma warning restore 1591
