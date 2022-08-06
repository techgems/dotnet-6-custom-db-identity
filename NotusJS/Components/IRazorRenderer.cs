﻿using Microsoft.AspNetCore.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.Components;

public interface IRazorRenderer
{
    Task<IHtmlContent> RenderAsContent<T>(string path, T? model);
}