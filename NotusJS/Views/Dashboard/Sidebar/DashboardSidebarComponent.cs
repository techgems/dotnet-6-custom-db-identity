using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Sidebar;

public class DashboardSidebarModel : ServerComponentModel
{
}

[HtmlTargetElement("dashboard-sidebar")]
public class DashboardSidebarComponent : ServerComponent
{
    public DashboardSidebarComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardSidebarModel()
        {

        };

        await RenderPartialView("~/Views/Dashboard/Sidebar/Sidebar.cshtml", output, model);
    }
}
