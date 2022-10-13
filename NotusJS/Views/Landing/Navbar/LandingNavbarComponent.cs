using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Navbar;

[HtmlTargetElement("landing-navbar")]
public class LandingNavbarComponent : RazorComponentTagHelper
{
    public LandingNavbarComponent() : base("~/Views/Landing/Navbar/Navbar.cshtml")
    {
    }
}