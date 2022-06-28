using IdentityCustomDatabase.Repositories.Interfaces;
using IdentityCustomDatabaseDataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabase.DataAccess.Repositories.Interfaces
{
    public interface IUsersRepository : IGenericRepository<User, int>
    {
        Task<User> FindByEmail(string email);

        Task<User> FindByName(string name);
    }
}
