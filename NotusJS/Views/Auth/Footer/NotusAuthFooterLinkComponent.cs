using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Auth.Footer;

public class AuthFooterLinkModel : ServerComponentModel
{
    public string Link { get; set; } = string.Empty;

}

[HtmlTargetElement("notus-auth-footer-link")]
public class NotusAuthFooterLinkComponent : ServerComponent
{
    public NotusAuthFooterLinkComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {

    }


    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new AuthFooterLinkModel()
        {
            Link = Link
        };

        await RenderPartialView("~/Views/Auth/Footer/AuthFooterLink.cshtml", output, model);
    }
}
