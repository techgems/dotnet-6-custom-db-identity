using IdentityCustomDatabase.DataAccess.Repositories.Interfaces;
using IdentityCustomDatabase.Repositories;
using IdentityCustomDatabaseDataAccess.Entities;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.DataAccess.Repositories;

public class ClaimsRepository : GenericRepository<Claim, int>, IClaimsRepository
{
    public ClaimsRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public async Task<List<Claim>> GetClaimsForUser(int userId)
    {
        var claims = await base.QueryAsync(x => x.UserId == userId);

        return claims.ToList();
    }

}

