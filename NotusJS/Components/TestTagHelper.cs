using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Components;

[HtmlTargetElement("test")]
public class TestTagHelper : ServerComponent
{
    public TestTagHelper(IRazorRenderer renderer) : base(renderer)
    {
    }

    public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
    {
        await RenderPartialView("~/Views/TagHelpers/Test.cshtml", output);
    }
}
