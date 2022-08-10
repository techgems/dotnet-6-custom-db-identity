using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Navbar;

public class LandingNavbarLinkModel : ServerComponentModel
{
    public string Link { get; set; } = "";

}

[HtmlTargetElement("landing-navbar-link")]
public class LandingNavbarLinkComponent : ServerComponent
{
    public LandingNavbarLinkComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new LandingNavbarLinkModel()
        {
            Link = Link
        };

        await RenderPartialView("~/Views/Landing/Navbar/NavbarLink.cshtml", output, model);
    }
}
