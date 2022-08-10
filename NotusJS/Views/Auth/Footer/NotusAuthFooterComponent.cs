using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Auth.Footer;

public class AuthFooterModel : ServerComponentModel
{
}

[HtmlTargetElement("notus-auth-footer")]
public class NotusAuthFooterComponent : ServerComponent
{
    public NotusAuthFooterComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {

    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/Auth/Footer/AuthFooter.cshtml", output, new AuthFooterModel());
    }
}
