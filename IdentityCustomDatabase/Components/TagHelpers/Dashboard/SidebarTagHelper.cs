using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomIdentity.Web.Components.TagHelpers.Dashboard;

[HtmlTargetElement("sidebar")]
public class SidebarTagHelper : ServerComponent
{
    public SidebarTagHelper(IHtmlHelper htmlHelper) : base(htmlHelper)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/TagHelpers/Dashboard/Sidebar.cshtml", output);
    }
}
