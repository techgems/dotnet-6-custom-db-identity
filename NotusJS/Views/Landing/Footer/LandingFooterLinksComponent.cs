using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Footer;

[HtmlTargetElement("landing-footer-links")]
public class LandingFooterLinksComponent : RazorComponentTagHelper
{
    public LandingFooterLinksComponent() : base("~/Views/Landing/Footer/FooterLinks.cshtml")
    {
    }
}