using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Sidebar;

[HtmlTargetElement("dashboard-sidebar-section")]
public class DashboardSidebarSectionComponent : RazorComponentTagHelper
{
    public DashboardSidebarSectionComponent() : base("~/Views/Dashboard/Sidebar/SidebarSection.cshtml")
    {
    }

    [HtmlAttributeName("text")]
    public string Text { get; set; } = string.Empty;

}
