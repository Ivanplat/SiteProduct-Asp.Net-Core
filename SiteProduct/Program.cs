using SiteProduct.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSingleton<IProductData, MockProductData>();
builder.Services.AddSingleton<ITypeProductData, MockTypeProductData>();
builder.Services.AddMvc();
var app = builder.Build();
app.MapControllerRoute(name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.Run();
