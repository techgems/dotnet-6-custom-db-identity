using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Footer;

public class LandingFooterModel : ServerComponentModel
{
}

[HtmlTargetElement("landing-footer")]
public class NotusLandingFooterComponent : ServerComponent
{
    public NotusLandingFooterComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Landing/Footer/Footer.cshtml", output);
    }
}