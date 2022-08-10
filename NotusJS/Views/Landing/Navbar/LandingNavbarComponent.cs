using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Navbar;

public class LandingNavbarModel : ServerComponentModel
{
}

[HtmlTargetElement("landing-navbar")]
public class LandingNavbarComponent : ServerComponent
{
    public LandingNavbarComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Landing/Navbar/Navbar.cshtml", output, new LandingNavbarModel());
    }
}