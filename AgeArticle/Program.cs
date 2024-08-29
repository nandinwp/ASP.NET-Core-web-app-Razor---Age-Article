using AgeArticle.Models;
using Microsoft.EntityFrameworkCore;
using SQLitePCL; // Add this using directive

var builder = WebApplication.CreateBuilder(args);

// Initialize SQLitePCL
Batteries.Init();

// Get the path to the root of the project
var dbPath = Path.Combine(AppContext.BaseDirectory, "survey.db");

// Add services to the container.
builder.Services.AddRazorPages();

// Configure the DbContext to use SQLite
builder.Services.AddDbContext<SurveyContext>(options =>
    options.UseSqlite($"Data Source={dbPath}"));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<SurveyContext>();
    dbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
