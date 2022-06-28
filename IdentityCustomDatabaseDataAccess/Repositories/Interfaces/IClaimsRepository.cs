using IdentityCustomDatabase.Repositories.Interfaces;
using IdentityCustomDatabaseDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.DataAccess.Repositories.Interfaces;

public interface IClaimsRepository : IGenericRepository<Claim, int>
{

    Task<List<Claim>> GetClaimsForUser(int userId);
}

