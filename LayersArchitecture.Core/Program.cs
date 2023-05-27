using Layers.Repository.DataAccess;
using LayersArchitecture.Core.Extensions;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Container Dependencies

builder.Services.ConfigureProgramDependencies();

// Context Configuration

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("Sql"));
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}
// Error Page Configuration

app.UseStatusCodePages();
app.UseStatusCodePagesWithReExecute("/Main/Error", "?code={0}");


app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Default Controllers
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Main}/{action=Index}/{id?}");

// Area Controllers
app.MapControllerRoute(
   name: "areas",
      pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}");

app.Run();
