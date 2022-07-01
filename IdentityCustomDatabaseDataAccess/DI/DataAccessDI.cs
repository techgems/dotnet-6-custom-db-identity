using CustomIdentity.DataAccess.Repositories;
using CustomIdentity.DataAccess.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomIdentity.DataAccess.DI;

public static class DataAccessDI
{
    public static void AddDataAccess(this IServiceCollection services)
    {
        services.AddTransient(typeof(IGenericRepository<,>), typeof(GenericRepository<,>));

        services.AddTransient<IUsersRepository, UsersRepository>();
        services.AddTransient<IClaimsRepository, ClaimsRepository>();

        RepoDb.SqlServerBootstrap.Initialize();
        IdentityCustomMappers.SetTableMappers();
    }
}

