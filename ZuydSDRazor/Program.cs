using Microsoft.EntityFrameworkCore;
using ZuydSDRazor.Data;
using ZuydSDRazor.Models;
using Microsoft.Extensions.DependencyInjection;
using StudentenDatabase.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BontenDbContext>(opt => opt.UseSqlite("Data Source=RazorPagesMovie.Data.db"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    var context = services.GetRequiredService<BontenDbContext>();
    context.Database.EnsureCreated();
    SeedData.Initialize(context);
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();