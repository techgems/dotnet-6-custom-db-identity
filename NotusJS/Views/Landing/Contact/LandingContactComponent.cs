using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Contact;

[HtmlTargetElement("landing-contact")]
public class LandingContactComponent : RazorComponentTagHelper
{
    public LandingContactComponent() : base("~/Views/Landing/Contact/Contact.cshtml")
    {
    }
}
