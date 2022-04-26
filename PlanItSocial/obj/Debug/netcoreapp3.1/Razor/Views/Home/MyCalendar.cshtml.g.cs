#pragma checksum "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\Home\MyCalendar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10719e9f289e0dedee24012a87001b588b25411f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_MyCalendar), @"mvc.1.0.view", @"/Views/Home/MyCalendar.cshtml")]
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
#line 1 "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\_ViewImports.cshtml"
using PlanItSocial;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\_ViewImports.cshtml"
using PlanItSocial.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10719e9f289e0dedee24012a87001b588b25411f", @"/Views/Home/MyCalendar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"543aaf05dee82a0fe93d5178f2346e732e544a56", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_MyCalendar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\Home\MyCalendar.cshtml"
  
    ViewData["Title"] = "My Calendar";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<script>

      document.addEventListener('DOMContentLoaded', function() {
        var calendarEl = document.getElementById('calendar');
        var calendar = new FullCalendar.Calendar(calendarEl, {
            initialView: 'dayGridMonth',
            events: ");
#nullable restore
#line 11 "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\Home\MyCalendar.cshtml"
               Write(Html.Raw(ViewData["Events"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            resources: ");
#nullable restore
#line 12 "C:\Users\glenn\Documents\PlanItSocialCalendar\PlanItSocial\Views\Home\MyCalendar.cshtml"
                  Write(Html.Raw(ViewData["Resources"]));

#line default
#line hidden
#nullable disable
            WriteLiteral(@",
            headerToolbar: {
                left: 'today prev, next',
                center: 'title',
                right: 'resourceTimelineDay,timeGridWeek,dayGridMonth,listMonth'
            },
        });
        calendar.render();
      });

</script>

<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <div id='calendar'></div>
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
