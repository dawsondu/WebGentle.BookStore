#pragma checksum "D:\projects\CSharp\P1\WebGentle.BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "536f3a0d8f116fc45f7b598ca4018013356ae165"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"536f3a0d8f116fc45f7b598ca4018013356ae165", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\projects\CSharp\P1\WebGentle.BookStore\Views\Home\Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""jumbotron text-center"">
    <div class=""container"" >
        <h1>Welcome to BookStore</h1>
        <p class=""lead text-muted"">
            Lorem ipsum...
        </p>
        <p>
            <a href=""#"" class=""btn btn-primary my-2"">Search books</a>
        </p>
    </div>
</section>
<div class=""py-5 bg-light"">
    <div class=""container"">
        <h2 class=""h2"">Top Books</h2>
        <div class=""row"">
            <div class=""col-md-4"">
                <svg class=""bd-placeholder-img card-img-top"" width=""225"" height=""140"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: 140x140"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#777"" /><text x=""50%"" y=""50%"" fill=""#777"" dy="".3em"">Thumbnail</text></svg>

                <h3>Heading</h3>
                <p>Some representative placeholder content for the three columns of text below the carousel. This is the first column.</p>
               ");
            WriteLiteral(@" <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                <small class=""text-muted"">Author name</small>
            </div>
            <div class=""col-md-4"">
                <svg class=""bd-placeholder-img card-img-top"" width=""225"" height=""140"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: 140x140"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#777"" /><text x=""50%"" y=""50%"" fill=""#777"" dy="".3em"">Thumbnail</text></svg>

                <h3>Heading</h3>
                <p>Some representative placeholder content for the three columns of text below the carousel. This is the first column.</p>
                <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                <small class=""text-muted"">Author name</small>
            </div>
            <div class=""col-md-4"">
                <svg class=""bd-placeholder-img card-img-top"" width=""225"" height=""140"" xml");
            WriteLiteral(@"ns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: 140x140"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#777"" /><text x=""50%"" y=""50%"" fill=""#777"" dy="".3em"">Thumbnail</text></svg>

                <h3>Heading</h3>
                <p>Some representative placeholder content for the three columns of text below the carousel. This is the first column.</p>
                <p><a class=""btn btn-secondary"" href=""#"">View details &raquo;</a></p>
                <small class=""text-muted"">Author name</small>
            </div>
        </div>
    </div>
</div>
");
            DefineSection("breadcrumb", async() => {
                WriteLiteral(@" 
    <nav aria-label=""breadcrumb"">
        <ol class=""breadcrumb"">
            <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
            <li class=""breadcrumb-item""><a href=""#"">Page 1</a></li>
            <li class=""breadcrumb-item active"" aria-current=""page"">Index</li>
        </ol>
    </nav>
");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n    <script>\r\n        $(document).ready(function () {\r\n            //alert(\"document is ready!\");\r\n        });\r\n    </script>\r\n");
            }
            );
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
