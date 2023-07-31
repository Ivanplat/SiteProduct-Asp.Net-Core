using SiteProduct.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddScoped<IProductData, MockProductData>();
builder.Services.AddScoped<ITypeProductData, MockTypeProductData>();
builder.Services.AddMvc();
var app = builder.Build();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
