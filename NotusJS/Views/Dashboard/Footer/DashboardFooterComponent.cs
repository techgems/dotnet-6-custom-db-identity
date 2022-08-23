using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Footer;

public class DashboardFooterModel : ServerComponentModel
{
}

[HtmlTargetElement("dashboard-footer")]
public class DashboardFooterComponent : ServerComponent
{
    public DashboardFooterComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardFooterModel()
        {

        };

        await RenderPartialView("~/Views/Dashboard/Footer/Footer.cshtml", output, model);
    }
}
