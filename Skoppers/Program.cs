
//1.Proyektimize EntityFramework.Tools;  EntityFramework.SqlServer;
// EntityFramework.Design i Nuget Package Managerden yukleyiriki
// (MVC proyektimizin versiyasina uygun shekilde);
//2.Proyektinizde Data folderinde DbContext ifadesi ile biten .cs filesi
//yaratdiq, classimiz DbContextden miras alib, ctorunu istifade edirik;
//3.Proyektimize bildirmek ucun ki sen hansi db ile ve hansi server ile
//ishleyirsen builder.services.adddbcontext<dbfilemizinadi>
//connectionsringde de sql serverimizin melumatlarini daxil etdik
//4.Modelimizi yaradib Dbcontextde DbSet<modelinadi>
//5.migration commandlarimizi verib sqlde verdiyim adda database ve
//tablelarin yarandigini gorurem
//6.SQLde uygun tablemin datalarini daxil edirem;
//7.Controllerde ctor yaradib private verdiyimiz contenxti tanidiriq;
//8.Viewa gondermek ucun melumatlari contextden alib Liste ceviririk ve
//View(liste cevirdiyimiz obyekti)
//9.View-da Listimizi tanidiriq; tekrarlanan itemleri secib yalniz birin saxlayiriq;
//10.Foreache salib uygun melumatlari DBdan getirik;
using Microsoft.EntityFrameworkCore;
using Skoppers.Data;

namespace Skoppers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<ShoppersDBcontext>(options =>
            {
                options.UseSqlServer("Server=LAPTOP-KL0IS704\\SQLEXPRESS;Database=Shoppers;Trusted_Connection=True;TrustServerCertificate=True;");
            });
            var app = builder.Build();
            app.UseStaticFiles();
            app.MapControllerRoute(

                name: "default",
                pattern:"{controller=Home}/{action=Index}"
                );


            app.Run();
        }
    }
}
