using SolidTech.Business.Businesses;
using SolidTech.Data;

var builder = WebApplication.CreateBuilder(args);

//Servislerin tanýmlandýðý yer burasý
builder.Services.AddScoped<ServiceBusiness>();
builder.Services.AddScoped<ProjectCategoryBusiness>();


builder.Services.AddControllersWithViews();//Uygulamada Controller ve View yapýsnýn kullanabilmek için bu servisi ekliyoruz 

//appsetings.json 'dan Connection bilgilerini al ve Data katmanýndaki Constructor'a aktar
//builder.Services.AddDbContext<SolidTechContext>(options =>
//{
//    options.UseSqlServer("Server=.;Database=SolidTechDb;Trusted_Connection=True;Encrypt=False");
//});

builder.Services.AddDbContext<SolidTechContext>();

var app = builder.Build();

app.UseStaticFiles();//Uygulamada "wwwroot" klasörü altýnda static dosyalarý kullanabilmek için ekliyoruz(css,js,images)


app.UseRouting();


app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
