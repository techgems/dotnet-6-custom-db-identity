using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityCustomDatabaseDataAccess.Entities;

namespace IdentityCustomDatabaseDataAccess.Stores.Interfaces;

public interface IRoleStore : IRoleStore<Role>
{
}

