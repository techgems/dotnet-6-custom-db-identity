using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomIdentity.DataAccess.Entities;
using CustomIdentity.DataAccess.Repositories.Interfaces;
using CustomIdentity.DataAccess.Stores.Interfaces;

namespace CustomIdentity.DataAccess.Stores;

public class RoleStore : IRoleStore
{
    private readonly IGenericRepository<Role, int> _rolesRepository;

    public RoleStore(IGenericRepository<Role, int> rolesRepository)
    {
        _rolesRepository = rolesRepository;
    }

    public async Task<IdentityResult> CreateAsync(Role role, CancellationToken cancellationToken)
    {
        await _rolesRepository.Create(role);

        return IdentityResult.Success;
    }

    public async Task<IdentityResult> DeleteAsync(Role role, CancellationToken cancellationToken)
    {
        await _rolesRepository.Delete(role);

        return IdentityResult.Success;
    }


    public async Task<Role> FindByIdAsync(string roleId, CancellationToken cancellationToken)
    {
        var role = await _rolesRepository.Get(Convert.ToInt32(roleId));

        return role;
    }

    public Task<Role> FindByNameAsync(string normalizedRoleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetNormalizedRoleNameAsync(Role role, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetRoleIdAsync(Role role, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<string> GetRoleNameAsync(Role role, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetNormalizedRoleNameAsync(Role role, string normalizedName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task SetRoleNameAsync(Role role, string roleName, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task<IdentityResult> UpdateAsync(Role role, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
    }
}

