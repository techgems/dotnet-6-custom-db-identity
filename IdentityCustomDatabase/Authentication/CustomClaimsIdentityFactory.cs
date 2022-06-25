using IdentityCustomDatabaseDataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace IdentityCustomDatabase.Authentication;

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

