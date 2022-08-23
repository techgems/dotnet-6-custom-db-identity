using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Sidebar;

public class DashboardSidebarLinkModel : ServerComponentModel
{
}

[HtmlTargetElement("dashboard-sidebar-link")]
public class DashboardSidebarLinkComponent : ServerComponent
{
    public DashboardSidebarLinkComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardSidebarLinkModel()
        {

        };

        await RenderPartialView("~/Views/Dashboard/Sidebar/Sidebar.cshtml", output, model);
    }
}
