#pragma checksum "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "387492aa0fd85ae97e3f42ce642a0d820ca72f4c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_AddDiary), @"mvc.1.0.view", @"/Views/Home/AddDiary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"387492aa0fd85ae97e3f42ce642a0d820ca72f4c", @"/Views/Home/AddDiary.cshtml")]
    public class Views_Home_AddDiary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Diarymous.Models.DiaryManager>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "387492aa0fd85ae97e3f42ce642a0d820ca72f4c2727", async() => {
                WriteLiteral("\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "387492aa0fd85ae97e3f42ce642a0d820ca72f4c3697", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
     using (Html.BeginForm(FormMethod.Post))
    {

    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div>\r\n            ");
#nullable restore
#line 12 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
       Write(Html.LabelFor(x => x.title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 13 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
       Write(Html.TextBoxFor(x => x.title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div>\r\n            ");
#nullable restore
#line 16 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
       Write(Html.LabelFor(x => x.text));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            ");
#nullable restore
#line 17 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
       Write(Html.TextAreaFor(x => x.text));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <!--Validation-->\r\n        <div>\r\n\r\n            ");
#nullable restore
#line 22 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
       Write(Html.ValidationMessage("Yazı",(string)ViewBag.Message,"text-danger"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
   Write(Html.ValidationMessageFor(x => x.title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
   Write(Html.ValidationMessage("Login", (string)ViewBag.Attention, "text-danger"));

#line default
#line hidden
#nullable disable
                WriteLiteral("        <button type=\"submit\">Add</button>\r\n");
#nullable restore
#line 27 "C:\Users\Emircan\source\repos\com.app.Diarymous\Diarymous\Views\Home\AddDiary.cshtml"
    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Diarymous.Models.DiaryManager> Html { get; private set; }
    }
}
#pragma warning restore 1591
