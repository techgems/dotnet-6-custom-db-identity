using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomIdentity.Web.Components.TagHelpers.Dashboard;

public record UserDropdownProps();

[HtmlTargetElement("user-dropdown")]
public class UserDropdownTagHelper : ServerComponent
{
    public UserDropdownTagHelper(IHtmlHelper htmlHelper) : base(htmlHelper)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/TagHelpers/UsersDropdown.cshtml", output);
    }
}
