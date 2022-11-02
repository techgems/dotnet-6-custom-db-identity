using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Agency;

[HtmlTargetElement("landing-skills-card")]
public class SkillsCardComponent : RazorComponentTagHelper
{
    public static readonly string DescriptionSlot = "descriptionSlot";
    public static readonly string HeaderSlot = "headerSlot";

    public SkillsCardComponent() : base("~/Views/Landing/Agency/SkillsCard.cshtml")
    {

    }

    [HtmlAttributeName("top-align-class")]
    public string TopAlignmentClass { get; set; } = "";

    [HtmlAttributeName("icon-bg-color")]
    public string IconBgColor { get; set; } = "";

    [HtmlAttributeName("fab-icon-class")]
    public string FabIconClass { get; set; } = "";
}
