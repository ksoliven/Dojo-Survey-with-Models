#pragma checksum "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "139853416b8a51486ec42e915108d13904ccc689"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
#line 1 "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml"
using DojoSurvey.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"139853416b8a51486ec42e915108d13904ccc689", @"/Views/Home/Result.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Survey>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(41, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(76, 762, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "58a47e6298264d9a974630519d1f1b2c", async() => {
                BeginContext(82, 749, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <meta http-equiv=""X-UA-Compatible"" content=""ie=edge"">
    <title>Result</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
<style>
    *{
        margin: 0px;
        padding: 0px;
    }
    .wrapper{
        margin-left: 500px;
        text-align: center;
        align-content: center;
        height: 500px;
        width: 500px;
    }
    .middle_wrapper{
            text-align: center;
            align-content: center;
        }
</style>
");
                EndContext();
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
            EndContext();
            BeginContext(838, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(840, 634, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04898809ab554903b483be6d3121151c", async() => {
                BeginContext(846, 182, true);
                WriteLiteral("\r\n    <div class = wrapper>\r\n    <div class = \"middle_wrapper\">\r\n        <h3>Your submitted info:</h3>\r\n        <br>\r\n        <br>\r\n        <h3>Name:</h3>\r\n        <br>\r\n        <h4>");
                EndContext();
                BeginContext(1029, 10, false);
#line 37 "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml"
       Write(Model.name);

#line default
#line hidden
                EndContext();
                BeginContext(1039, 89, true);
                WriteLiteral("</h4>\r\n        <br>\r\n        <br>\r\n        <h3>Location:</h3>\r\n        <br>\r\n        <h4>");
                EndContext();
                BeginContext(1129, 10, false);
#line 42 "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml"
       Write(Model.dojo);

#line default
#line hidden
                EndContext();
                BeginContext(1139, 98, true);
                WriteLiteral("</h4>\r\n        <br>\r\n        <br>\r\n        <h3>Favorite Language:</h3>\r\n        <br>\r\n        <h4>");
                EndContext();
                BeginContext(1238, 10, false);
#line 47 "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml"
       Write(Model.lang);

#line default
#line hidden
                EndContext();
                BeginContext(1248, 89, true);
                WriteLiteral("</h4>\r\n        <br>\r\n        <br>\r\n        <h3>Comments:</h3>\r\n        <br>\r\n        <h4>");
                EndContext();
                BeginContext(1338, 13, false);
#line 52 "C:\Users\chloe\OneDrive\Desktop\C#\DojoSurvey\Views\Home\Result.cshtml"
       Write(Model.comment);

#line default
#line hidden
                EndContext();
                BeginContext(1351, 116, true);
                WriteLiteral("</h4>\r\n        <br>\r\n        <button class=\"btn btn-dark\"><a href=\"/\">Go Back</button></a>\r\n    </div>\r\n    </div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(1474, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591