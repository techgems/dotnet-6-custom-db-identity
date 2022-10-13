using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Agency;

[HtmlTargetElement("landing-agency")]
public class LandingCompanyComponent : RazorComponentTagHelper
{
    public LandingCompanyComponent() : base("~/Views/Landing/Agency/Agency.cshtml")
    {
    }
}
