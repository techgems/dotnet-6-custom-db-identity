using CustomIdentity.DataAccess.Entities;
using CustomIdentity.DataAccess.Repositories.Interfaces;
using CustomIdentity.DataAccess.Stores.Interfaces;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.DataAccess.Stores;

public class UserStore : IUserStore
{
    private readonly IUsersRepository _usersRepository;
    private readonly IClaimsRepository _claimsRepository;

    public UserStore(IUsersRepository usersRepository, IClaimsRepository claimsRepository)
    {
        _usersRepository = usersRepository;
        _claimsRepository = claimsRepository;
    }

    public Task AddClaimsAsync(User user, IEnumerable<System.Security.Claims.Claim> claims, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public async Task<IdentityResult> CreateAsync(User user, CancellationToken cancellationToken)
    {
        var userId = await _usersRepository.Create(user);

        user.Id = userId;

        return IdentityResult.Success;
    }

    public async Task<IdentityResult> DeleteAsync(User user, CancellationToken cancellationToken)
    {
        var result = await _usersRepository.Delete(user);

        return IdentityResult.Success;
    }

    public async Task<User> FindByEmailAsync(string normalizedEmail, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.FindByEmail(normalizedEmail);

        return user;
    }

    public async Task<User> FindByIdAsync(string userId, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.Get(Convert.ToInt32(userId));

        return user;
    }

    public async Task<User> FindByNameAsync(string normalizedUserName, CancellationToken cancellationToken)
    {
        var user = await _usersRepository.FindByName(normalizedUserName);

        return user;
    }

    public async Task<IList<System.Security.Claims.Claim>> GetClaimsAsync(User user, CancellationToken cancellationToken)
    {
        var claims = await _claimsRepository.GetClaimsForUser(user.Id);

        var securityClaims = new List<System.Security.Claims.Claim>();
        foreach (var claim in claims)
        {
            securityClaims.Add(new System.Security.Claims.Claim(claim.Key, claim.Value));
        }

        return securityClaims;
    }

    public Task<string> GetEmailAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Email.ToString());
    }

    public Task<bool> GetEmailConfirmedAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.IsConfirmed);
    }

    public Task<string> GetNormalizedEmailAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Email.ToUpperInvariant());
    }

    public Task<string> GetNormalizedUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Email.ToUpperInvariant());
    }

    public Task<string> GetPasswordHashAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Password);
    }

    public Task<string> GetSecurityStampAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.SecurityStamp);
    }

    public Task<string> GetUserIdAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Id.ToString());
    }

    public Task<string> GetUserNameAsync(User user, CancellationToken cancellationToken)
    {
        return Task.FromResult(user.Email.ToString());
    }

    public Task<IList<User>> GetUsersForClaimAsync(System.Security.Claims.Claim claim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<bool> HasPasswordAsync(User user, CancellationToken cancellationToken)
    {
        var hasPassword = !string.IsNullOrWhiteSpace(user.Password);

        return Task.FromResult(hasPassword);
    }

    public Task RemoveClaimsAsync(User user, IEnumerable<System.Security.Claims.Claim> claims, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task ReplaceClaimAsync(User user, System.Security.Claims.Claim claim, System.Security.Claims.Claim newClaim, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetEmailAsync(User user, string email, CancellationToken cancellationToken)
    {
        user.Email = email;

        return Task.FromResult(0);
    }

    public Task SetEmailConfirmedAsync(User user, bool confirmed, CancellationToken cancellationToken)
    {
        user.IsConfirmed = confirmed;

        return Task.FromResult(0);
    }

    public Task SetNormalizedEmailAsync(User user, string normalizedEmail, CancellationToken cancellationToken)
    {
        user.Email = normalizedEmail;

        return Task.FromResult(0);
    }

    public Task SetNormalizedUserNameAsync(User user, string normalizedName, CancellationToken cancellationToken)
    {
        user.Email = normalizedName;

        return Task.FromResult(0);
    }

    public Task SetPasswordHashAsync(User user, string passwordHash, CancellationToken cancellationToken)
    {
        user.Password = passwordHash;

        return Task.FromResult(0);
    }

    public Task SetSecurityStampAsync(User user, string stamp, CancellationToken cancellationToken)
    {
        user.SecurityStamp = stamp;

        return Task.FromResult(0);
    }

    public Task SetUserNameAsync(User user, string userName, CancellationToken cancellationToken)
    {
        user.Email = userName;

        return Task.FromResult(0);
    }

    public async Task<IdentityResult> UpdateAsync(User user, CancellationToken cancellationToken)
    {
        await _usersRepository.Update(user);

        return IdentityResult.Success;
    }

    public void Dispose()
    {
    }
}

