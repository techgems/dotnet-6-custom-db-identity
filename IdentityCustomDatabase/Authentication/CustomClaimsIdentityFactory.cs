﻿using CustomIdentity.DataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace CustomIdentity.Web.Authentication;

public static class CustomClaims
{
    public static readonly string Name = "custom_name";
}


public class CustomClaimsIdentityFactory : UserClaimsPrincipalFactory<User>
{
    public CustomClaimsIdentityFactory(UserManager<User> userManager, IOptions<IdentityOptions> optionsAccessor) : base(userManager, optionsAccessor)
    {
    }

    protected override async Task<ClaimsIdentity> GenerateClaimsAsync(User user)
    {
        var identity = await base.GenerateClaimsAsync(user);

        identity.AddClaim(new System.Security.Claims.Claim(CustomClaims.Name, user.PreferredName.ToString()));

        return identity;
    }
}

