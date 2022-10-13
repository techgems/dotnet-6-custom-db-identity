using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Auth.Navbar;

[HtmlTargetElement("notus-auth-navbar")]
public class AuthNavbarComponent : RazorComponentTagHelper
{
    public AuthNavbarComponent() : base("~/Views/Auth/Navbar/AuthNavbar.cshtml")
    {
    }
}
