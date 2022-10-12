using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using TechGems.RazorComponentTagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Navbar;

[HtmlTargetElement("dashboard-navbar")]
public class DashboardNavbarComponent : RazorComponentTagHelper
{
    public DashboardNavbarComponent() : base("~/Views/Dashboard/Navbar/Navbar.cshtml")
    {
    }
}
