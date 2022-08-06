using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Components;

public class RazorRenderer : IRazorRenderer
{
    private readonly IHtmlHelper _html;
    private readonly IRazorViewEngine _razorViewEngine;
    private readonly ITempDataProvider _tempDataProvider;
    private readonly IHttpContextAccessor _contextAccessor;

    public RazorRenderer(
        IHtmlHelper html,
        IRazorViewEngine razorViewEngine,
        ITempDataProvider tempDataProvider,
        IHttpContextAccessor contextAccessor)
    {
        _html = html;
        _razorViewEngine = razorViewEngine;
        _tempDataProvider = tempDataProvider;
        _contextAccessor = contextAccessor;
    }

    private IView FindView(string path)
    {
        var result = _razorViewEngine.GetView(null, path, true);

        if (!result.Success)
        {
            var searchedLocations = string.Join("\n", result.SearchedLocations);
            throw new InvalidOperationException($"Could not find this view: {path}. Searched locations:\n{searchedLocations}");
        }

        var view = result.View;

        return view;
    }

    private ViewContext BuildViewContext(IView view, StringWriter writer, object? model)
    {
        var httpContext = _contextAccessor.HttpContext;

        var actionContext = new ActionContext(
            httpContext!,
            httpContext!.GetRouteData(), new ActionDescriptor());

        var viewDataDict = new ViewDataDictionary(
                new EmptyModelMetadataProvider(),
                new ModelStateDictionary());

        viewDataDict.Model = model;

        var viewContext = new ViewContext(
            actionContext,
            view,
            viewDataDict,
            new TempDataDictionary(
                httpContext!,
                _tempDataProvider
            ),
            writer,
            new HtmlHelperOptions { }
        );

        return viewContext;
    }

    public async Task<IHtmlContent> RenderAsContent<T>(string path, T? model)
    {
        var view = FindView(path);

        using var writer = new StringWriter();
        var viewContext = BuildViewContext(view, writer, model);

        //To use partial instead
        (_html as IViewContextAware)!.Contextualize(viewContext);

        var content = await _html.PartialAsync(path, model);

        return content;
    }
}
