#pragma checksum "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd1ff19175f7f3c4da9eba1d9a602beb5d606fe5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PartialLogin), @"mvc.1.0.view", @"/Views/Shared/_PartialLogin.cshtml")]
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
#line 1 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
using Diarymous.Models.Interfaces;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd1ff19175f7f3c4da9eba1d9a602beb5d606fe5", @"/Views/Shared/_PartialLogin.cshtml")]
    public class Views_Shared__PartialLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 7 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
     if (checker.checkState(User) == true)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
   Write(Html.ActionLink("Profil","Profile","Profile",null,new {@class="ml-3 mr-3 nav-item" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
                                                                                              
    }
    else {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
Write(Html.ActionLink("Login ", "Login", "Account", null, new { @class = "ml-3 mr-3 nav-item" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
                                                                                               ;
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
Write(Html.ActionLink("Register","Register","Account",null,new {@class="ml-3 mr-3 nav-item" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Shared\_PartialLogin.cshtml"
                                                                                             
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ICheck checker { get; private set; }
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
