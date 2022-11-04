using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Landing.Contact;

[HtmlTargetElement("contact-form")]
public class ContactFormComponent : RazorComponentTagHelper
{
    public ContactFormComponent() : base("~/Views/Landing/Contact/ContactForm.cshtml")
    {
    }
}
