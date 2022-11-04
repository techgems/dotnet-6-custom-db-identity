using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Company;

[HtmlTargetElement("team-member")]
public class TeamMemberComponent : RazorComponentTagHelper
{
    public TeamMemberComponent() : base("~/Views/Landing/Company/TeamMember.cshtml")
    {
    }

    [HtmlAttributeName("name")]
    public string Name { get; set; } = "";

    [HtmlAttributeName("role")]
    public string Role { get; set; } = "";

    [HtmlAttributeName("image")]
    public string ImageSrc { get; set; } = "";

    [HtmlAttributeNotBound]
    public string ImageAlt
    {
        get
        {
            return $"{Name} Image";
        }
    }

}
