//Author : Jean Bryant Figueroa
//Course : COMP003B
//Fauculty : Johnathan Cruz
//Purpose : 4.2 Coding Assignment: Mini-Project

namespace COMP003B.Assignment4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.MapControllerRoute(
                name: "store",
                pattern: "store/{action=Order}/{id?}",
                defaults: new { controller = "Store" });

            app.MapControllers();


            app.Run();
        }
    }
}
