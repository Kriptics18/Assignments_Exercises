using Web;
using MovieWebApp;

var builder = WebApplication.CreateBuilder(args);

// Create an instance of Startup
var startup = new Startup(builder.Configuration);

// Call the ConfigureServices method on Startup
startup.ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline using Startup
if (app.Environment.IsDevelopment()) {
    app.UseDeveloperExceptionPage();
} else {
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

startup.Configure(app, app.Environment);

app.Run();
