using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace CustomIdentity.Web.Components.TagHelpers;

public abstract class ServerComponent : TagHelper
{
    private readonly IHtmlHelper _html;

    [HtmlAttributeNotBound]
    [ViewContext]
    public ViewContext? ViewContext { get; set; }

    public ServerComponent(IHtmlHelper htmlHelper)
    {
        _html = htmlHelper;
    }

    protected async Task<string> GetChildHtmlAsString(TagHelperOutput output)
    {
        var childContent = await output.GetChildContentAsync();
        var trimmedContent = childContent.GetContent().Trim();

        return trimmedContent;
    }

    protected async Task RenderPartialView<T>(string viewRoute, TagHelperOutput output, T model)
    {
        (_html as IViewContextAware).Contextualize(ViewContext);

        var content = await _html.PartialAsync(viewRoute, model);

        output.TagName = null;
        output.Content.SetHtmlContent(content);
    }

    protected async Task RenderPartialView(string viewRoute, TagHelperOutput output)
    {
        (_html as IViewContextAware).Contextualize(ViewContext);

        var content = await _html.PartialAsync(viewRoute);

        output.TagName = null;
        output.Content.SetHtmlContent(content);
    }
}