using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Dashboard.Sidebar;

[HtmlTargetElement("dashboard-sidebar")]
public class DashboardSidebarComponent : RazorComponentTagHelper
{
    public DashboardSidebarComponent() : base("~/Views/Dashboard/Sidebar/Sidebar.cshtml")
    {
    }

}
