using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Dashboard.Footer;

[HtmlTargetElement("dashboard-footer")]
public class DashboardFooterComponent : RazorComponentTagHelper
{
    public DashboardFooterComponent() : base("~/Views/Dashboard/Footer/Footer.cshtml")
    {
    }
}
