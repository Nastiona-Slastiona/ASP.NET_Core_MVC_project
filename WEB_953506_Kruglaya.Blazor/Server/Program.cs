using Microsoft.EntityFrameworkCore;
using WEB_953506_Kruglaya.Data;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ApplicationDbContext>(opt =>
    opt.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=WEB_953506_Kruglaya;Trusted_Connection=True;MultipleActiveResultSets=true")
);
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
     


var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseBlazorFrameworkFiles();
app.UseStaticFiles();

app.UseRouting();


app.MapRazorPages();
app.MapControllers();
app.MapFallbackToFile("index.html");

app.Run();
