var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços MVC
builder.Services.AddControllersWithViews();

// Adiciona autenticação de cookie (mesmo sem login real, precisamos disso para [Authorize])
builder.Services.AddAuthentication("CookieAuth")
    .AddCookie("CookieAuth", options =>
    {
        options.LoginPath = "/Account/Login";
    });

var app = builder.Build();

// Middleware
app.UseStaticFiles();
app.UseRouting();

// Autenticação e autorização
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
