#pragma checksum "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "698d4b206da507bef0bdd57079211e2005fac5bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nota__Index), @"mvc.1.0.view", @"/Views/Nota/_Index.cshtml")]
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
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\_ViewImports.cshtml"
using EXAMENFINALN00038802;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\_ViewImports.cshtml"
using EXAMENFINALN00038802.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698d4b206da507bef0bdd57079211e2005fac5bf", @"/Views/Nota/_Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80114a3186e347a7bde7658a8aa2a5e36e050000", @"/Views/_ViewImports.cshtml")]
    public class Views_Nota__Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
  
    Layout = null;
    var nota = (List<Nota>)Model;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
 foreach (var item in nota)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\r\n        <ul class=\"list-group\" style=\"list-style-type:circle\">\r\n            <li class=\"list-group-item\">\r\n                <a class=\"text-info\"");
            BeginWriteAttribute("href", " href=\"", 273, "\"", 301, 2);
            WriteAttributeValue("", 280, "/Nota/Det?Id=", 280, 13, true);
#nullable restore
#line 11 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 293, item.Id, 293, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 11 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                                                                     Write(item.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a>\r\n                <br />\r\n                <span>\r\n                    <strong>Cuerpo: </strong>\r\n");
#nullable restore
#line 15 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                     if (item.Contenido.Length > 50)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 17 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                            Write(item.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial> ");
#nullable restore
#line 17 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                                                                                }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 20 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                            Write(item.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>");
#nullable restore
#line 20 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
                                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\r\n\r\n                <br />\r\n                <div align=\"right\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 813, "\"", 846, 2);
            WriteAttributeValue("", 820, "/Nota/Eliminar?id=", 820, 18, true);
#nullable restore
#line 25 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 838, item.Id, 838, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" style=""margin:0px 5px;"" class=""btn btn-danger float-lg-right"">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-trash"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path d=""M5.5 5.5A.5.5 0 0 1 6 6v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm2.5 0a.5.5 0 0 1 .5.5v6a.5.5 0 0 1-1 0V6a.5.5 0 0 1 .5-.5zm3 .5a.5.5 0 0 0-1 0v6a.5.5 0 0 0 1 0V6z"" />
                            <path fill-rule=""evenodd"" d=""M14.5 3a1 1 0 0 1-1 1H13v9a2 2 0 0 1-2 2H5a2 2 0 0 1-2-2V4h-.5a1 1 0 0 1-1-1V2a1 1 0 0 1 1-1H6a1 1 0 0 1 1-1h2a1 1 0 0 1 1 1h3.5a1 1 0 0 1 1 1v1zM4.118 4L4 4.059V13a1 1 0 0 0 1 1h6a1 1 0 0 0 1-1V4.059L11.882 4H4.118zM2.5 3V2h11v1h-11z"" />
                        </svg>
                    </a>
                    <button id=""editModal"" style=""margin:0px 5px;"" class=""btn btn-warning float-lg-right"" href=""#"" data-toggle=""modal"" data-target=""#edit""");
            BeginWriteAttribute("onclick", " onclick=\"", 1774, "\"", 1838, 7);
            WriteAttributeValue("", 1784, "selCuenta(\'", 1784, 11, true);
#nullable restore
#line 31 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1795, item.Id, 1795, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1803, "\',\'", 1803, 3, true);
#nullable restore
#line 31 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1806, item.Titulo, 1806, 12, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1818, "\',\'", 1818, 3, true);
#nullable restore
#line 31 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
WriteAttributeValue("", 1821, item.Contenido, 1821, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1836, "\')", 1836, 2, true);
            EndWriteAttribute();
            WriteLiteral(@">
                        <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-pen"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                            <path fill-rule=""evenodd"" d=""M13.498.795l.149-.149a1.207 1.207 0 1 1 1.707 1.708l-.149.148a1.5 1.5 0 0 1-.059 2.059L4.854 14.854a.5.5 0 0 1-.233.131l-4 1a.5.5 0 0 1-.606-.606l1-4a.5.5 0 0 1 .131-.232l9.642-9.642a.5.5 0 0 0-.642.056L6.854 4.854a.5.5 0 1 1-.708-.708L9.44.854A1.5 1.5 0 0 1 11.5.796a1.5 1.5 0 0 1 1.998-.001zm-.644.766a.5.5 0 0 0-.707 0L1.95 11.756l-.764 3.057 3.057-.764L14.44 3.854a.5.5 0 0 0 0-.708l-1.585-1.585z"" />
                        </svg>
                    </button>
                </div>
            </li>
        </ul>
        <br />
    </div>
");
#nullable restore
#line 41 "E:\ESTUDIOS\UPN\CICLO VII\DISEÑO Y ARQUITECTURA DE SOTFWARE\SEMANA 16\EXAMENFINALN00038802\EXAMENFINALN00038802\Views\Nota\_Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>


<script>
    function confirmDel(e) {
        var agree = confirm(""¿Realmente desea eliminarlo? "");

        if (agree == false)
            e.preventDefault");
            WriteLiteral(@"();
    }
</script>

<script>
    function selCuenta(id, titulo, contenido) {
        console.log(id + titulo + contenido);
        $('#mtxtId').val(id);
        $('#mtxtTitulo').val(titulo);
        $('#mtxtContenido').val(contenido);
    };

    $.ajax({
        url: '/Nota/Edit',
        type: 'get'
    }).done(function (html) {
        $('#editNotita').html(html);
    })

    function submitForm() {
        $('#editNota').submit();
    }

    function editar(event) {
        event.preventDefault();
        var dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/Nota/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#editNotita').html(html.responseText);
        });
    }
</script>

");
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
