using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Profile.Navbar;

public class ProfileNavbarModel : ServerComponentModel
{
}

[HtmlTargetElement("profile-navbar")]
public class ProfileNavbarComponent : ServerComponent
{
    public ProfileNavbarComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new ProfileNavbarModel()
        {

        };

        await RenderPartialView("~/Views/Profile/Navbar/Navbar.cshtml", output, model);
    }
}
