using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Auth.Navbar;

public class AuthNavbarModel : ServerComponentModel
{
}

[HtmlTargetElement("notus-auth-navbar")]
public class NotusAuthNavbarComponent : ServerComponent
{
    public NotusAuthNavbarComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Auth/Navbar/AuthNavbar.cshtml", output, new AuthNavbarModel());
    }
}
