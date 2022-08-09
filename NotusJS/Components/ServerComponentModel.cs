using Microsoft.AspNetCore.Razor.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Components;

public abstract class ServerComponentModel
{
    public TagHelperContent? ChildContent { get; set; }
}
