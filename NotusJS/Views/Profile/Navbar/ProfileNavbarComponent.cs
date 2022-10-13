using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace NotusJS.Views.Profile.Navbar;

[HtmlTargetElement("profile-navbar")]
public class ProfileNavbarComponent : RazorComponentTagHelper
{
    public ProfileNavbarComponent() : base("~/Views/Profile/Navbar/Navbar.cshtml")
    {
    }
}
