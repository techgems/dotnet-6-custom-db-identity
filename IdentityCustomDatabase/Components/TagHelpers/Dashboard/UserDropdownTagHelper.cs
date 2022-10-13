using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;
using TechGems.RazorComponentTagHelpers;

namespace CustomIdentity.Web.Components.TagHelpers.Dashboard;


[HtmlTargetElement("user-dropdown")]
public class UserDropdownTagHelper : RazorComponentTagHelper
{
    public UserDropdownTagHelper() : base("~/Views/TagHelpers/UsersDropdown.cshtml")
    {
    }
}
