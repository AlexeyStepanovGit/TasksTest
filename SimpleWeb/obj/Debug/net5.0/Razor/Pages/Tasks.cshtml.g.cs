#pragma checksum "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0752568ed638c0a40c5569b19c885438cbe1b666"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimpleWeb.Pages.Pages_Tasks), @"mvc.1.0.view", @"/Pages/Tasks.cshtml")]
namespace SimpleWeb.Pages
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
#line 1 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\_ViewImports.cshtml"
using SimpleWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml"
using TasksWeb.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0752568ed638c0a40c5569b19c885438cbe1b666", @"/Pages/Tasks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc64d8fab2ff9610c31079d28e34ffc630272b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Tasks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TasksWeb.Model.TaskModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml"
  
    ViewBag.Title = "Tasks";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Tasks</h2>\r\n\r\n<table class=\"table-fill\">\r\n    <thead>\r\n        <tr>\r\n            <th class=\"text-left\">\r\n                ");
#nullable restore
#line 13 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.DisplayName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
#nullable restore
#line 16 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.Priority));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"text-left\">\r\n                ");
#nullable restore
#line 19 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Tasks.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"text-left\">Actions</th>\r\n        </tr>\r\n   \r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TasksWeb.Model.TaskModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
