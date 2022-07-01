using CustomIdentity.Migrations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

//Build configuration.
var configurationBuilder = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
    .AddEnvironmentVariables()
    .AddCommandLine(args);

var devEnvironmentVariable = Environment.GetEnvironmentVariable("NETCORE_ENVIRONMENT");
var isDevelopment = string.IsNullOrEmpty(devEnvironmentVariable) || devEnvironmentVariable.ToLower() == "development";

if (isDevelopment) //only add secrets in development
{
    configurationBuilder.AddUserSecrets<Program>();
}

IConfiguration Configuration = configurationBuilder.Build();

var connectionString = Configuration["IdentityDbConnectionString"];

var serviceProvider = MigrationsHelper.CreateServices(connectionString);

using var scope = serviceProvider.CreateScope();

try
{
    MigrationsHelper.UpdateDatabase(scope.ServiceProvider);
}
catch (Exception ex) {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(ex.Message);
    Console.ResetColor();
#if DEBUG
    Console.ReadLine();
#endif
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Success!");
Console.ResetColor();

Console.WriteLine("All migrations run!");
