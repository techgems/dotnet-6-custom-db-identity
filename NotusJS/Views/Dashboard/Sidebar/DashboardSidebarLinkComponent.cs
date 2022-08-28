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
    public string? FabIconClass { get; set; }

    public string Link { get; set; } = string.Empty;

    public string Text { get; set; } = string.Empty;

    public bool OpenInNewTab { get; set; }
}

[HtmlTargetElement("dashboard-sidebar-link")]
public class DashboardSidebarLinkComponent : ServerComponent
{
    public DashboardSidebarLinkComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    [HtmlAttributeName("fab-icon-class")]
    public string? FabIconClass { get; set; }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = string.Empty;

    [HtmlAttributeName("new-tab")]
    public bool OpenInNewTab { get; set; }

    [HtmlAttributeName("text")]
    public string Text { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardSidebarLinkModel()
        {
            Link = Link,
            Text = Text,
            FabIconClass = FabIconClass,
            OpenInNewTab = OpenInNewTab
        };

        await RenderPartialView("~/Views/Dashboard/Sidebar/SidebarLink.cshtml", output, model);
    }
}
