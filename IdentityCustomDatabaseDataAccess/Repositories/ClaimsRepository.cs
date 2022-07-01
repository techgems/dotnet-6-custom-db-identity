using CustomIdentity.DataAccess.Entities;
using CustomIdentity.DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.DataAccess.Repositories;

public class ClaimsRepository : GenericRepository<Claim, int>, IClaimsRepository
{
    public ClaimsRepository(IConfiguration configuration) : base(configuration)
    {

    }

    public async Task<List<Claim>> GetClaimsForUser(int userId)
    {
        var claims = await QueryAsync(x => x.UserId == userId);

        return claims.ToList();
    }

}

