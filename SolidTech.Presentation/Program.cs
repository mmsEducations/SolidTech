var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//Uygulamada Controller ve View yapýsnýn kullanabilmek için bu servisi ekliyoruz 

var app = builder.Build();

app.UseStaticFiles();//Uygulamada "wwwroot" klasörü altýnda static dosyalarý kullanabilmek için ekliyoruz(css,js,images)


app.UseRouting();


app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
