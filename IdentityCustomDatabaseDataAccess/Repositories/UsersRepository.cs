using CustomIdentity.DataAccess.Entities;
using CustomIdentity.DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.DataAccess.Repositories;

public class UsersRepository : GenericRepository<User, int>, IUsersRepository
{
    public UsersRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public async Task<User> FindByEmail(string email)
    {
        var user = (await QueryAsync(x => x.Email == email)).FirstOrDefault();

        return user;
    }

    public async Task<User> FindByName(string name)
    {
        var user = (await QueryAsync(x => x.PreferredName.Contains(name))).FirstOrDefault();

        return user;
    }
}

