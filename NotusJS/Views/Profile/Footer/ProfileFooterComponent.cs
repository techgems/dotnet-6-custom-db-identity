using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Profile.Footer;

public class ProfileFooterModel : ServerComponentModel
{
}

[HtmlTargetElement("profile-footer")]
public class ProfileFooterComponent : ServerComponent
{
    public ProfileFooterComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new ProfileFooterModel()
        {

        };

        await RenderPartialView("~/Views/Profile/Footer/Footer.cshtml", output, model);
    }
}
