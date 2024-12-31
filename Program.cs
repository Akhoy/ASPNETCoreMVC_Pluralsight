using Microsoft.EntityFrameworkCore;
using MVCAppModels;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();

// Add services to the container.
builder.Services.AddControllersWithViews();

// add db context
builder.Services.AddDbContext<BethanysPieShopDbContext>(options => options.UseSqlite(builder.Configuration["ConnectionStrings:BethanysPieShopDbContextConnection"]));

var app = builder.Build();
app.UseStaticFiles();
if(app.Environment.IsDevelopment()){
    app.UseDeveloperExceptionPage();
}
app.MapDefaultControllerRoute();//"{controller=Home}/{action=Index}/{id?}"
app.MapControllerRoute(name: "default", pattern: "{controller=Home}/{action=Index}/{id?}");

//app.MapGet("/", () => "Hello World!");
DbInitializer.Seed(app);
app.Run();
