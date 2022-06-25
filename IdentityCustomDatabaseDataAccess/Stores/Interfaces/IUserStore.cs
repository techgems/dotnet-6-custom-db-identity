using IdentityCustomDatabaseDataAccess.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabaseDataAccess.Stores.Interfaces;

public interface IUserStore : IUserStore<User>, IUserEmailStore<User>, IUserPasswordStore<User>, IUserSecurityStampStore<User>, IUserClaimStore<User>
{
}

