var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var app = builder.Build();
app.UseRouting();
app.MapControllerRoute("default", "{controller=FisherYates}/{action=Index}");
app.Run();