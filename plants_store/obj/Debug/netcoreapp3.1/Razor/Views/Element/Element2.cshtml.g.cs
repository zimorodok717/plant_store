#pragma checksum "C:\Users\tatia\source\repos\plants_store\plants_store\Views\Element\Element2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc939b615a7602483f6e0cdad618a0fe1a0006e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Element_Element2), @"mvc.1.0.view", @"/Views/Element/Element2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc939b615a7602483f6e0cdad618a0fe1a0006e2", @"/Views/Element/Element2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Element_Element2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\tatia\source\repos\plants_store\plants_store\Views\Element\Element2.cshtml"
  
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <section>\r\n        <header class=\"main\">\r\n            <h1 id=\"name\">Цинк</h1>\r\n        </header>\r\n\r\n        <span class=\"image main\">\r\n            <img src=\"https://localhost:44302/images/imgonline-com-ua-Resize-xZF2hjRjdX.jpg\"");
            BeginWriteAttribute("alt", " alt=\"", 297, "\"", 303, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n        </span>\r\n        <input type=\"button\" class=\"button primary large\" value=\"Заказать\"");
            BeginWriteAttribute("onclick", " onclick=\"", 400, "\"", 457, 3);
            WriteAttributeValue("", 410, "location.href=\'", 410, 15, true);
#nullable restore
#line 13 "C:\Users\tatia\source\repos\plants_store\plants_store\Views\Element\Element2.cshtml"
WriteAttributeValue("", 425, Url.Action("Order2","Element"), 425, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 456, "\'", 456, 1, true);
            EndWriteAttribute();
            WriteLiteral(@">
        <p> Цинк – второй по важности микроэлемент нашего организма. Соединения цинка не синтезируются организмом, поэтому важно, чтобы цинк регулярно и в должном количестве поступал извне.</p>

        <hr class=""major"" />

        <h2>Противопоказания</h2>
        <p>Болезни ЖКТ</p>
        <p>Нарушение функции почек</p>
    </section>
</div>");
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
