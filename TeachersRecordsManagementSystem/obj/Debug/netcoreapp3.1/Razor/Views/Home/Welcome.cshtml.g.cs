#pragma checksum "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\Home\Welcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "20e0688b8c1931163663e0bba304675b1ec5538e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Welcome), @"mvc.1.0.view", @"/Views/Home/Welcome.cshtml")]
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
#line 1 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\_ViewImports.cshtml"
using TeachersrRecordsManagementSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\_ViewImports.cshtml"
using TeachersrRecordsManagementSystem.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"20e0688b8c1931163663e0bba304675b1ec5538e", @"/Views/Home/Welcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5622e35746146b7d6f1854db3e674bbe6ac39c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Welcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\Home\Welcome.cshtml"
  
    ViewData["Title"] = "Welcome";
    Layout = "~/Views/Shared/_WelcomeLayout.cshtml";


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-sm-12 mb-4"">
    <div class=""row"">

        <!--Card 1-->
        <div class=""card col-md-6"">
            <div class=""card-body"">
                <div class=""h1 text-muted text-right mb-4"">
                    <i class=""fa fa-users""></i>
                </div>

                <div class=""h4 mb-0"">
                    <span class=""count"">");
#nullable restore
#line 19 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\Home\Welcome.cshtml"
                                   Write(ViewBag.CountTeachers);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>

                <small class=""text-muted text-uppercase font-weight-bold"">Registered Teachers</small>
                <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-1"" style=""width: 40%; height: 5px;""></div>
            </div>
        </div>

        <div class=""card col-md-6  "">
            <div class=""card-body"">
                <div class=""h1 text-muted text-right mb-4"">
                    <i class=""fa fa-th-large""></i>
                </div>
                <div class=""h4 mb-0"">
                    <span class=""count"">");
#nullable restore
#line 33 "C:\Users\Yishmael\Documents\Visual Studio 2019\Projects\TeachersRecordsManagementSystem\TeachersRecordsManagementSystem\Views\Home\Welcome.cshtml"
                                   Write(ViewBag.CountBanks);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
                <small class=""text-muted text-uppercase font-weight-bold"">Registered Banks</small>
                <div class=""progress progress-xs mt-3 mb-0 bg-flat-color-3"" style=""width: 40%; height: 5px;""></div>
            </div>
        </div>



    </div>
</div>


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
