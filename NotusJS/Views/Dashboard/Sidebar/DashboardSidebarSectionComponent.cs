using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Sidebar;

public class DashboardSidebarSectionModel : ServerComponentModel
{
    public string Text { get; set; } = string.Empty;
}

[HtmlTargetElement("dashboard-sidebar-section")]
public class DashboardSidebarSectionComponent : ServerComponent
{
    public DashboardSidebarSectionComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    [HtmlAttributeName("text")]
    public string Text { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardSidebarSectionModel()
        {
            Text = Text,
        };

        await RenderPartialView("~/Views/Dashboard/Sidebar/SidebarSection.cshtml", output, model);
    }
}
