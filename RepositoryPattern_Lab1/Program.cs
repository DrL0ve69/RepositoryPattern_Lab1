using RepositoryPattern_Lab1.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DB_CatalogueGateaux>(options => 
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DbGateauxConnection"]);
});

builder.Services.AddScoped<IGateauRepository, DBGateauxRepository>();
// Ajoutpour l'enregistrement des services
//builder.Services.AddSingleton<IGateauRepository, DBGateauxRepository>(); // Permet l'enregistrement sur le serveur

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Gateau}/{action=Index}/{id?}")
    .WithStaticAssets();

Db_Seeders.Seed(app);
app.Run();
