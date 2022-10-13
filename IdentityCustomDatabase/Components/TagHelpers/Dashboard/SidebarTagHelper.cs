using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;

namespace CustomIdentity.Web.Components.TagHelpers.Dashboard;

[HtmlTargetElement("sidebar")]
public class SidebarTagHelper : RazorComponentTagHelper
{
    public SidebarTagHelper() : base("~/Views/TagHelpers/Dashboard/Sidebar.cshtml")
    {
    }
}
