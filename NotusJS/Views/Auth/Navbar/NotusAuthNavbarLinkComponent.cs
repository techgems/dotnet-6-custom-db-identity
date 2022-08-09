using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Auth.Navbar;

public class AuthNavbarLinkModel : ServerComponentModel
{
    public string Link { get; set; } = "";
}

[HtmlTargetElement("notus-auth-navbar-link")]
public class NotusAuthNavbarLinkComponent : ServerComponent
{
    public NotusAuthNavbarLinkComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    [HtmlAttributeName("link")]
    public string Link { get; set; } = "";

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new AuthNavbarLinkModel() { Link = Link };

        await RenderPartialView("~/Views/Auth/Navbar/AuthNavbarLink.cshtml", output, model);
    }

}
