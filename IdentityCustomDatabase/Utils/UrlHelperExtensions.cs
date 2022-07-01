using CustomIdentity.Web.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CustomIdentity.Web.Utils;

public static class UrlHelperExtensions
{
    public static string EmailConfirmationLink(this IUrlHelper urlHelper, int userId, string code, string scheme)
    {
        return urlHelper.Action(
            action: nameof(AuthController.ConfirmEmail),
            controller: "Auth",
            values: new { userId, code },
            protocol: scheme);
    }

    public static string ResetPasswordCallbackLink(this IUrlHelper urlHelper, int userId, string code, string scheme)
    {
        return urlHelper.Action(
            action: nameof(AuthController.ResetPassword),
            controller: "Auth",
            values: new { userId, code },
            protocol: scheme);
    }
}

