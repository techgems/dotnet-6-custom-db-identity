using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Contact;

public class LandingContactModel : ServerComponentModel
{
}

[HtmlTargetElement("landing-contact")]
public class LandingContactComponent : ServerComponent
{
    public LandingContactComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new LandingContactModel()
        {

        };

        await RenderPartialView("~/Views/Landing/Contact/Contact.cshtml", output, model);
    }
}
