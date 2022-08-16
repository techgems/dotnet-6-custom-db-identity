using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Hero;

public class LandingHeroModel : ServerComponentModel
{
    public string BackgroundImageLink { get; set; } = string.Empty;

    public string MainText { get; set; } = string.Empty;

    public string SubText { get; set; } = string.Empty;
}

[HtmlTargetElement("landing-hero")]
public class LandingHeroComponent : ServerComponent
{
    public LandingHeroComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    [HtmlAttributeName("background")]
    public string BackgroundImageLink { get; set; } = string.Empty;

    [HtmlAttributeName("main-text")]
    public string MainText { get; set; } = string.Empty;

    [HtmlAttributeName("sub-text")]
    public string SubText { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new LandingHeroModel()
        {
            BackgroundImageLink = BackgroundImageLink,
            MainText = MainText,
            SubText = SubText
        };

        await RenderPartialView("~/Views/Landing/Hero/Hero.cshtml", output, model);
    }
}
