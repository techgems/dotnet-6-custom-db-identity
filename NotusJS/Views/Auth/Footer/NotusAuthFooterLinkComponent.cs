using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Auth.Footer;

[HtmlTargetElement("notus-auth-footer-link")]
public class NotusAuthFooterLinkComponent : RazorComponentTagHelper
{
    public NotusAuthFooterLinkComponent() : base("~/Views/Auth/Footer/AuthFooterLink.cshtml")
    {

    }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";
}
