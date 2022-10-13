using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Auth.Navbar;

[HtmlTargetElement("notus-auth-navbar-link")]
public class NotusAuthNavbarLinkComponent : RazorComponentTagHelper
{
    public NotusAuthNavbarLinkComponent() : base("~/Views/Auth/Navbar/AuthNavbarLink.cshtml")
    {
    }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";
}
