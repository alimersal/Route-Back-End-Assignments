using MVC01.CustomMiddlewares;

namespace MVC01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // mvc
            // builder.Services.AddControllers(); // api
            // builder.Services.AddRazorPages(); // razor pages


            var app = builder.Build();

            #region custom middleware
            //app.Use(async (context, next) =>
            //{
            //    Console.WriteLine("hello");
            //    await next(context);
            //    Console.WriteLine("bye");

            //});
            app.UseMiddleware<RequestTimmingMiddleware>();
            #endregion


            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}