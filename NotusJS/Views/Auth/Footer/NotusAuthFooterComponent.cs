using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechGems.RazorComponentTagHelpers;

namespace NotusJS.Views.Auth.Footer;


[HtmlTargetElement("notus-auth-footer")]
public class NotusAuthFooterComponent : RazorComponentTagHelper
{
    public NotusAuthFooterComponent() : base("~/Views/Auth/Footer/AuthFooter.cshtml")
    {

    }
}
