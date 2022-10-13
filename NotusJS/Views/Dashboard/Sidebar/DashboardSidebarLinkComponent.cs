using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Sidebar;

[HtmlTargetElement("dashboard-sidebar-link")]
public class DashboardSidebarLinkComponent : RazorComponentTagHelper
{
    public DashboardSidebarLinkComponent() : base("~/Views/Dashboard/Sidebar/SidebarLink.cshtml")
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
}
