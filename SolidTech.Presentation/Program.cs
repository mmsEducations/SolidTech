var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();//Uygulamada Controller ve View yap�sn�n kullanabilmek i�in bu servisi ekliyoruz 

var app = builder.Build();

app.UseStaticFiles();//Uygulamada "wwwroot" klas�r� alt�nda static dosyalar� kullanabilmek i�in ekliyoruz(css,js,images)


app.UseRouting();


app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
