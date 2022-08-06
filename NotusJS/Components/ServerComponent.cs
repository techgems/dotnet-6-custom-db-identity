using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Threading.Tasks;

namespace NotusJS.Components;

public abstract class ServerComponent : TagHelper
{
    private readonly IRazorRenderer _razorRenderer;

    public ServerComponent(IRazorRenderer razorRenderer)
    {
        _razorRenderer = razorRenderer;
    }

    protected async Task<string> GetChildHtmlAsString(TagHelperOutput output)
    {
        var childContent = await output.GetChildContentAsync();
        var trimmedContent = childContent.GetContent().Trim();

        return trimmedContent;
    }

    protected async Task RenderPartialView<T>(string viewRoute, TagHelperOutput output, T model)
    {
        var content = await _razorRenderer.RenderAsContent(viewRoute, model);

        output.TagName = null;
        output.Content.SetHtmlContent(content);
    }

    protected async Task RenderPartialView(string viewRoute, TagHelperOutput output)
    {
        var content = await _razorRenderer.RenderAsContent<object>(viewRoute, null);

        output.TagName = null;
        output.Content.SetHtmlContent(content);
    }
}

