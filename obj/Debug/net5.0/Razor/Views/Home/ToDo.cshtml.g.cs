#pragma checksum "D:\ActivityTracker\ActivityTracker\Views\Home\ToDo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "823e2e7605de769883afaf0c2bea272c5e7bf9cb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ToDo), @"mvc.1.0.view", @"/Views/Home/ToDo.cshtml")]
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
#line 1 "D:\ActivityTracker\ActivityTracker\Views\_ViewImports.cshtml"
using ActivityTracker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ActivityTracker\ActivityTracker\Views\_ViewImports.cshtml"
using ActivityTracker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"823e2e7605de769883afaf0c2bea272c5e7bf9cb", @"/Views/Home/ToDo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a84a6204eebeb5e15234e4a0656dd923bb4a667d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ToDo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "AddPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\ActivityTracker\ActivityTracker\Views\Home\ToDo.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card-deck\">\r\n<div class=\"ToDo\">\r\n    <div class=\"card\" style=\"width: 18rem;\">\r\n        <div class=\"card-header\">\r\n            <h3>To Do ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "823e2e7605de769883afaf0c2bea272c5e7bf9cb3665", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"</h3>
        </div>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">Cras justo odio</li>
            <li class=""list-group-item"">Dapibus ac facilisis in</li>
            <li class=""list-group-item"">Vestibulum at eros</li>
        </ul>
    </div>
</div>
<div class=""Doing"">
    <div class=""card"" style=""width: 18rem;"">
        <div class=""card-header"">
            <h3>Doing</h3>
        </div>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">Cras justo odio</li>
            <li class=""list-group-item"">Dapibus ac facilisis in</li>
            <li class=""list-group-item"">Vestibulum at eros</li>
        </ul>
    </div>
</div>
<div class=""Done"">
    <div class=""card"" style=""width: 18rem;"">
        <div class=""card-header"">
            <h3>Done</h3>
        </div>
        <ul class=""list-group list-group-flush"">
            <li class=""list-group-item"">Cras justo odio</li>
            <li class=""list-group-i");
            WriteLiteral("tem\">Dapibus ac facilisis in</li>\r\n            <li class=\"list-group-item\">Vestibulum at eros</li>\r\n        </ul>\r\n    </div>\r\n</div>\r\n</div>\r\n\r\n<script type=\"text/javascript\">\r\n$(\"#loadPartialView\").click(function () {\r\n    $.get(\'");
#nullable restore
#line 46 "D:\ActivityTracker\ActivityTracker\Views\Home\ToDo.cshtml"
      Write(Url.Action("LoadPartialView","Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\', {}, function (response) {\r\n        $(\"#Display\").html(response);\r\n    });\r\n});\r\n</script>\r\n");
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