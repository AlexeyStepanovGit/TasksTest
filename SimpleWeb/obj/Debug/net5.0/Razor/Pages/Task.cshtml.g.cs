#pragma checksum "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Task.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86a7a37e01d442f99a238e152f90070a80ead9af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SimpleWeb.Pages.Pages_Task), @"mvc.1.0.view", @"/Pages/Task.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86a7a37e01d442f99a238e152f90070a80ead9af", @"/Pages/Task.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bc64d8fab2ff9610c31079d28e34ffc630272b4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Task : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TasksWeb.Model.TaskModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Task.cshtml"
  
    ViewBag.Title = "Task";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Task information</h2>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\XPS\Source\Repos\AlexeyStepanovGit\Tasks\SimpleWeb\Pages\Task.cshtml"
Write(Html.DisplayForModel());

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TasksWeb.Model.TaskModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
