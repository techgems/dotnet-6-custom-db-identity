using CustomIdentity.DataAccess.Entities;
using CustomIdentity.DataAccess.Stores;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace CustomIdentity.Web.Authentication;

public static class IdentitySetup
{
    public static void AddCustomIdentityAuthentication(this IServiceCollection services)
    {
        services.AddTransient<IUserStore<User>, UserStore>();
        services.AddTransient<IRoleStore<Role>, RoleStore>();

        //https://www.youtube.com/watch?v=Fhfvbl_KbWo&list=PLOeFnOV9YBa7dnrjpOG6lMpcyd7Wn7E8V&ab_channel=RawCoding
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = IdentityConstants.ApplicationScheme;
            options.DefaultChallengeScheme = IdentityConstants.ApplicationScheme;
            options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        })
        .AddCookie(IdentityConstants.ApplicationScheme, o =>
        {
            o.LoginPath = new PathString("/Auth/Login");
            o.AccessDeniedPath = new PathString("/Auth/AccessDenied");
            o.Events = new CookieAuthenticationEvents
            {
                OnValidatePrincipal = SecurityStampValidator.ValidatePrincipalAsync
            };
        })
        .AddCookie(IdentityConstants.ExternalScheme, o =>
        {
            o.Cookie.Name = IdentityConstants.ExternalScheme;
            o.ExpireTimeSpan = TimeSpan.FromMinutes(5);
        })
        .AddCookie(IdentityConstants.TwoFactorUserIdScheme, o =>
        {
            o.Cookie.Name = IdentityConstants.TwoFactorUserIdScheme;
            o.ExpireTimeSpan = TimeSpan.FromMinutes(5);
        });

        services.AddIdentityCore<User>().AddDefaultTokenProviders().AddClaimsPrincipalFactory<CustomClaimsIdentityFactory>();
        services.AddHttpContextAccessor();
        services.TryAddScoped<ISecurityStampValidator, SecurityStampValidator<User>>();
        services.TryAddScoped<SignInManager<User>>();
        services.TryAddScoped<UserManager<User>>();
        services.Configure<IdentityOptions>(options =>
        {
            // Default Password settings.
            options.Password.RequireDigit = false;
            options.Password.RequireLowercase = false;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequiredLength = 6;
            options.Password.RequiredUniqueChars = 0;

            options.SignIn.RequireConfirmedAccount = false;
            options.SignIn.RequireConfirmedEmail = false;
            options.SignIn.RequireConfirmedPhoneNumber = false;
        });
    }
}

