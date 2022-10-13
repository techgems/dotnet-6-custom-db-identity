using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Navbar;

[HtmlTargetElement("landing-navbar-link")]
public class LandingNavbarLinkComponent : RazorComponentTagHelper
{
    public LandingNavbarLinkComponent() : base("~/Views/Landing/Navbar/NavbarLink.cshtml")
    {
    }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";

}
