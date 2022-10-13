using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Profile.Footer;

[HtmlTargetElement("profile-footer")]
public class ProfileFooterComponent : RazorComponentTagHelper
{
    public ProfileFooterComponent() : base("~/Views/Profile/Footer/Footer.cshtml")
    {
    }
}
