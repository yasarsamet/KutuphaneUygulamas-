#pragma checksum "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa3ceb295cb83755e312287e74758b74c0262b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KitapAl_RezervasyonEttigimKitaplar), @"mvc.1.0.view", @"/Views/KitapAl/RezervasyonEttigimKitaplar.cshtml")]
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
#line 1 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\_ViewImports.cshtml"
using KütüphaneUygulaması;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\_ViewImports.cshtml"
using KütüphaneUygulaması.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2aa3ceb295cb83755e312287e74758b74c0262b6", @"/Views/KitapAl/RezervasyonEttigimKitaplar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872821a2e2a8dff834ea1df82fe8a5f94b7377a8", @"/Views/_ViewImports.cshtml")]
    public class Views_KitapAl_RezervasyonEttigimKitaplar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KütüphaneUygulaması.ViewModel.RezervasyonEttigimKitaplarViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
  
    ViewData["Title"] = "RezervasyonEttigimKitaplar";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""card shadow mb-4"">
        <div class=""card-header py-3"">
            <h6 class=""m-0 font-weight-bold text-primary"">Rezervasyon Yaptığım Kitap Listesi</h6>
        </div>
        <div class=""card-body"">
            <div class=""table-responsive"">
                <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                    <thead>
                        <tr>
                            <th>Kitap Adı</th>
                            <th>Kitap Sayfası</th>
                            <th>Kitap Basım Tarihi</th>
                            <th>Kitap Yazarı</th>
                            <th>Tarih</th>
                            <th>Rezervasyonu İptal Et</th>
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                         foreach (var kitap in Model.RezervasyonKitapListesi)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 28 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                               Write(kitap.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 29 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                               Write(kitap.KitapSayfasi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 30 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                               Write(kitap.KitapBasimTarihi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 31 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                               Write(kitap.Adi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 32 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                               Write(kitap.Tarih);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a data-toggle=\"modal\" data-target=\"#Assign\" style=\"color:white;\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1614, "\"", 1649, 3);
            WriteAttributeValue("", 1624, "rezervasyonsil(", 1624, 15, true);
#nullable restore
#line 34 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
WriteAttributeValue("", 1639, kitap.Id, 1639, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1648, ")", 1648, 1, true);
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-primary"">
                                        <span class=""svg-icon svg-icon-md"">
                                        </span>İptal Et
                                    </a>
                                </td>
                            </tr>
");
#nullable restore
#line 40 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    function rezervasyonsil(id) {\r\n        debugger;\r\n        $.get(\"");
#nullable restore
#line 50 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\KitapAl\RezervasyonEttigimKitaplar.cshtml"
          Write(Url.Action("RezervasyonSil", "KitapAl"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n            { rezervasyonid:id },\r\n                function(data) {\r\n                    location.reload();\r\n                });\r\n        }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KütüphaneUygulaması.ViewModel.RezervasyonEttigimKitaplarViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
