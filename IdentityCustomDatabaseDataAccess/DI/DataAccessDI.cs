using IdentityCustomDatabase.DataAccess.Repositories;
using IdentityCustomDatabase.DataAccess.Repositories.Interfaces;
using IdentityCustomDatabase.Repositories;
using IdentityCustomDatabase.Repositories.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdentityCustomDatabaseDataAccess.DI;

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

