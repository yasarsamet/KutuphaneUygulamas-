#pragma checksum "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1bf0d31c9b9414be39f74881c1306a3bbc32ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ogrenci_ProfilEdit), @"mvc.1.0.view", @"/Views/Ogrenci/ProfilEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e1bf0d31c9b9414be39f74881c1306a3bbc32ed", @"/Views/Ogrenci/ProfilEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872821a2e2a8dff834ea1df82fe8a5f94b7377a8", @"/Views/_ViewImports.cshtml")]
    public class Views_Ogrenci_ProfilEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KütüphaneUygulaması.ViewModel.ProfilEditViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""container"">
    <div class=""card o-hidden border-0 shadow-lg my-5"">
        <div class=""card-body p-0"">
            <!-- Nested Row within Card Body -->
            <div class=""row"">
                <div class=""col-lg-5 d-none d-lg-block bg-register-image""></div>
                <p> 
                    &nbsp;&nbsp;
                </p>
                <div class=""col-lg-6"">
                    <div class=""p-5"">
                        <div class=""text-center"">
                            <h1 class=""h4 text-gray-900 mb-4"">Bilgilerimi Güncelle</h1>
                        </div>

");
#nullable restore
#line 18 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                         using (Html.BeginForm("ProfilEdit", "Ogrenci", FormMethod.Post))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"form-group row\">\r\n                                <div class=\"col-sm-6 mb-3 mb-sm-0\">\r\n                                    <label>İsim</label>\r\n                                    ");
#nullable restore
#line 24 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.Isim, new { @class = "form-control rounded-left rounded-right", @maxlength = "15", @required = "required", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-6\">\r\n                                    <label>Soyisim</label>\r\n                                    ");
#nullable restore
#line 28 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.Soyisim, new { @class = "form-control rounded-left rounded-right", @maxlength = "15", @required = "required", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-sm-6 mb-3 mb-sm-0"">
                                    <label>Şifre</label>
                                    ");
#nullable restore
#line 34 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.PasswordFor(m => m.Sifre, new { @class = "form-control rounded-left rounded-right", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-6\">\r\n                                    <label>Email</label>\r\n                                    ");
#nullable restore
#line 38 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control rounded-left rounded-right", @required = "required", @maxlength = "18", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-sm-6 mb-3 mb-sm-0"">
                                    <label>Doğum Tarihi</label>
                                    ");
#nullable restore
#line 44 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.DogumTarihi, new { @class = "form-control rounded-left rounded-right", placeholder = "Doğum Tarihi", type = "date", @required = "required", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-6\">\r\n                                    <label>Okulu</label>\r\n                                    <input type=\"text\" class=\"form-control\"");
            BeginWriteAttribute("value", " value=\"", 3011, "\"", 3031, 1);
#nullable restore
#line 48 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
WriteAttributeValue("", 3019, Model.Okulu, 3019, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" readonly />
                                </div>
                            </div>
                            <div class=""form-group row"">
                                <div class=""col-sm-6 mb-3 mb-sm-0"">
                                    <label>Sınıfı</label>
                                    ");
#nullable restore
#line 54 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.Sınıfı, new { @class = "form-control form-control-user", placeholder = "Sınıf",@required="required", type = "number", @min = "0", @max = "4" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col-sm-6\">\r\n                                    <label>Adres</label>\r\n                                    ");
#nullable restore
#line 58 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                               Write(Html.TextBoxFor(m => m.Adres, new { @class = "form-control form-control-user", @required = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-sm-6 mb-3 mb-sm-0\">\r\n                                <label>Telefon</label>\r\n                                ");
#nullable restore
#line 63 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                           Write(Html.TextBoxFor(m => m.Telefon, new { @class = "form-control rounded-left rounded-right", @required = "required", @maxlength = "15", }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 65 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                       Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                       Write(Html.HiddenFor(m => m.Durumu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                       Write(Html.HiddenFor(m => m.Okulu));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                       Write(Html.HiddenFor(m => m.OgrenciId));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\r\n                            <button type=\"submit\" class=\"btn btn-block btn-dark rounded-left rounded-right\">Güncelle</button>\r\n");
#nullable restore
#line 71 "C:\Users\samet\source\repos\KütüphaneUygulaması\KütüphaneUygulaması\Views\Ogrenci\ProfilEdit.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KütüphaneUygulaması.ViewModel.ProfilEditViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
