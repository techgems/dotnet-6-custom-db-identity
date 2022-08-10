using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Footer;


[HtmlTargetElement("landing-footer-socials")]
public class LandingFooterSocialsComponent : ServerComponent
{
    public LandingFooterSocialsComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Landing/Footer/FooterSocials.cshtml", output);
    }
}
