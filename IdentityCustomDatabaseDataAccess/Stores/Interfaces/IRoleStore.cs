using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomIdentity.DataAccess.Entities;

namespace CustomIdentity.DataAccess.Stores.Interfaces;

public interface IRoleStore : IRoleStore<Role>
{
}

