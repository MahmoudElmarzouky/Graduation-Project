#pragma checksum "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c622eaad9a6cd5af73893f1397dcb520c8e1e488"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/_Layout.cshtml")]
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
#line 1 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Graduation_Project.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Graduation_Project.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_ViewImports.cshtml"
using Graduation_Project.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c622eaad9a6cd5af73893f1397dcb520c8e1e488", @"/Areas/Identity/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9516afcbd088965c4955650e1c513c37247c7fa7", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_Layout.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""user-sign-in-up"">
    <div class=""layout"">
        <div class=""container"">

            <h1 class=""text-center"">
                <span class=""selected"" data-class=""user-signin"">Sign In</span> | <span data-class=""user-signup"">Sign Up</span>
            </h1>
            ");
#nullable restore
#line 12 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 16 "D:\MyWork\GitHub\Graduation-Project\Graduation Project\Areas\Identity\Pages\_Layout.cshtml"
Write(await RenderSectionAsync("Scripts", required: false));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
