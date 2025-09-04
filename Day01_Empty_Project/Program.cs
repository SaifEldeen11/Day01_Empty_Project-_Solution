// This Code was made by Eng Saif :)
namespace Day01_Empty_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // make builder
            var builder = WebApplication.CreateBuilder();

            // add MVC [Multi Ways]
            #region Configration Services
            builder.Services.AddMvc(); // Full MVC stack (controllers + Razor views + API features). Legacy all-in-one
            builder.Services.AddMvcCore(); // Bare-bones MVC kernel only. You add extras yourself.
            builder.Services.AddRazorPages(); // Razor Pages only (no controllers).
            builder.Services.AddControllers(); // API controllers only (no views).
            builder.Services.AddControllersWithViews(); // Controllers + views, no Razor Pages. 
            #endregion

            // build app
            var app = builder.Build();
            //app.Configuration => twsal beha l appsettings.json w l environment variables w kman l command line args
            // dev route
            #region Configure
            if (app.Environment.IsDevelopment())
                app.MapGet("/", () => "Hello World!");

            // enable routing
            app.UseRouting();
            // custom route
            app.MapGet("/Hamada", () => "Hello Abo Hmeed!");

            app.MapGet("/Saif", async context =>
            {
                await context.Response.WriteAsync("Hello Saif!");
            }); 
            #endregion

            // run app
            app.Run();

        }
    }
}
