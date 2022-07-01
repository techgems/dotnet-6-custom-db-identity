using CustomIdentity.DataAccess.DI;
using CustomIdentity.Web.Authentication;
using CustomIdentity.Web.Services;
using CustomIdentity.Web.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddMvc();
builder.Services.AddDataAccess();
builder.Services.AddCustomIdentityAuthentication();
builder.Services.AddAuthorization();

builder.Services.AddTransient<IEmailService, EmailService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
    endpoints.MapControllerRoute(
        name: "AreasRoute",
        pattern: "{area:exists}/{controller}/{action}");
    endpoints.MapControllerRoute(
        name: "ControllersRoute",
        pattern: "{controller}/{action}");
});

app.Run();
