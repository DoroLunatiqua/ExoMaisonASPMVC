using System.Security.AccessControl;
using Common.Repositories;
using DAL1.Services;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//INJECTION DE DEPENDANCE ICI 

// Lire la ConnectionString
string connectionString = builder.Configuration.GetConnectionString("Main-DB");

// Ajouter les services (Dépendances)
builder.Services.AddScoped<IUserRepository<DAL1.Entities.User>, DAL1.Services.UserService>();
builder.Services.AddScoped<UserService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
