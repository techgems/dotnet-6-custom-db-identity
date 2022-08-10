using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Footer;

[HtmlTargetElement("landing-footer-links")]
public class LandingFooterLinksComponent : ServerComponent
{
    public LandingFooterLinksComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Landing/Footer/FooterLinks.cshtml", output);
    }
}