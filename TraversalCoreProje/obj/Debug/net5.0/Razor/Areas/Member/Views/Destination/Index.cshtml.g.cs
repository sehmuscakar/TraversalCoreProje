#pragma checksum "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "deff917f23993b562ded4d7549f0b77ab1a42602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Destination_Index), @"mvc.1.0.view", @"/Areas/Member/Views/Destination/Index.cshtml")]
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
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"deff917f23993b562ded4d7549f0b77ab1a42602", @"/Areas/Member/Views/Destination/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85c2850052001a53cd77d6353facaaa0c664eb15", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Destination_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Destination>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Aktif Tur Rotalarımız</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Şehir</th>\r\n        <th>Süre</th>\r\n        <th>Kapasite</th>\r\n        <th>Fiyat</th>\r\n        <th>Detaylar</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 21 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                   Write(item.DestinationID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 22 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                   Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 23 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                   Write(item.DayNight);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                   Write(item.Capacity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                 <td><a href=\"#\" class=\"btn btn-outline-info\">Detaylar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 28 "C:\Users\Şehmus\Desktop\Dosyalar\.Net (WEB)\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Destination\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Destination>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
