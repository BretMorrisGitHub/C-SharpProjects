#pragma checksum "C:\Users\legol\Documents\GitHub\C-SharpProjects\Basic_C#_Programs\ChallengeSubAssign\ChallengeSubAssign\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "342faca0806696fa05b527486e8cf088b0af6b1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ChallengeSubAssign.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace ChallengeSubAssign.Pages
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
#line 1 "C:\Users\legol\Documents\GitHub\C-SharpProjects\Basic_C#_Programs\ChallengeSubAssign\ChallengeSubAssign\Pages\_ViewImports.cshtml"
using ChallengeSubAssign;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"342faca0806696fa05b527486e8cf088b0af6b1d", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212051576f41dfbbaa579244c22a7e8c46d78fe3", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\legol\Documents\GitHub\C-SharpProjects\Basic_C#_Programs\ChallengeSubAssign\ChallengeSubAssign\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Current Time</h1>\r\n");
#nullable restore
#line 9 "C:\Users\legol\Documents\GitHub\C-SharpProjects\Basic_C#_Programs\ChallengeSubAssign\ChallengeSubAssign\Pages\Index.cshtml"
      DateTime time = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <p>Current time is: ");
#nullable restore
#line 11 "C:\Users\legol\Documents\GitHub\C-SharpProjects\Basic_C#_Programs\ChallengeSubAssign\ChallengeSubAssign\Pages\Index.cshtml"
                   Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    \r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
