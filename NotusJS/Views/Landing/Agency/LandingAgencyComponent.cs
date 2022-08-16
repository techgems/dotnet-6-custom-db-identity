using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Landing.Agency;

public class LandingAgencyModel : ServerComponentModel
{
}

[HtmlTargetElement("landing-agency")]
public class LandingCompanyComponent : ServerComponent
{
    public LandingCompanyComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new LandingAgencyModel()
        {

        };

        await RenderPartialView("~/Views/Landing/Agency/Agency.cshtml", output, model);
    }
}
