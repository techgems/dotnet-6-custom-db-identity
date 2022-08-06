using Microsoft.Extensions.DependencyInjection;
using NotusJS.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusJS.DI;

public static class NotusDependencyInjection
{
    public static void AddNotusComponents(this IServiceCollection services)
    {
        services.AddTransient<IRazorRenderer, RazorRenderer>();
    }
}
