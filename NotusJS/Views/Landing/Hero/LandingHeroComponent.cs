using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Hero;

[HtmlTargetElement("landing-hero")]
public class LandingHeroComponent : RazorComponentTagHelper
{
    public LandingHeroComponent() : base("~/Views/Landing/Hero/Hero.cshtml")
    {
    }

    [HtmlAttributeName("background")]
    public string BackgroundImageLink { get; set; } = string.Empty;

    [HtmlAttributeName("main-text")]
    public string MainText { get; set; } = string.Empty;

    [HtmlAttributeName("sub-text")]
    public string SubText { get; set; } = string.Empty;

}
