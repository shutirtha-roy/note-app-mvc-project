#pragma checksum "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4bfebe2e34bc4711e20bf05e5e465f29775b9c1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Note_Details), @"mvc.1.0.view", @"/Views/Note/Details.cshtml")]
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
#line 1 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\_ViewImports.cshtml"
using NotesApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\_ViewImports.cshtml"
using NotesApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4bfebe2e34bc4711e20bf05e5e465f29775b9c1", @"/Views/Note/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ee6e68c04d81313d4a59fab2f499029767cb0c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Note_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Note>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row text-center\">\r\n    <div class=\"col-12\">\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h1 class=\"h1\">");
#nullable restore
#line 8 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml"
                          Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h1 class=\"h4\">Category: ");
#nullable restore
#line 14 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml"
                                    Write(Model.NoteType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h1 class=\"h4 text-dark\">Created By: ");
#nullable restore
#line 20 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml"
                                                Write(Model.Creator);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row\">\r\n            <div class=\"col-12\">\r\n                <h1 class=\"h6 text-dark\">Times Read: ");
#nullable restore
#line 26 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml"
                                                Write(Model.ReadCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"row text-left\">\r\n            <div class=\"col-12\">\r\n                <p class=\"p-3 m-4 h4\">");
#nullable restore
#line 32 "F:\Development\ASP .NET\Projects\Extra\note-app-mvc-project\NotesApp\NotesApp\Views\Note\Details.cshtml"
                                 Write(Model.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Note> Html { get; private set; }
    }
}
#pragma warning restore 1591
