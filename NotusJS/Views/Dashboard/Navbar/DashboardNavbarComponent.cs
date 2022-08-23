using Microsoft.AspNetCore.Razor.TagHelpers;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Views.Dashboard.Navbar;

public class DashboardNavbarModel : ServerComponentModel
{
}

[HtmlTargetElement("dashboard-navbar")]
public class DashboardNavbarComponent : ServerComponent
{
    public DashboardNavbarComponent(IRazorRenderer razorRenderer) : base(razorRenderer)
    {
    }

    //[HtmlAttributeName("background")]
    //public string BackgroundImageLink { get; set; } = string.Empty;

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        var model = new DashboardNavbarModel()
        {

        };

        await RenderPartialView("~/Views/Dashboard/Navbar/Navbar.cshtml", output, model);
    }
}
