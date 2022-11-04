using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Contact;

[HtmlTargetElement("services-card")]
public class ServicesCardComponent : RazorComponentTagHelper
{
    public ServicesCardComponent() : base("~/Views/Landing/Contact/ServicesCard.cshtml")
    {
    }

    [HtmlAttributeName("name")]
    public string Name { get; set; } = "";

    [HtmlAttributeName("description")]
    public string Description { get; set; } = "";
}
