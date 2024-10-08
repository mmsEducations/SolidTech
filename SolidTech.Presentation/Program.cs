using SolidTech.Business.Mappings;
using SolidTech.Data;
using SolidTech.Presentation.InFrustracture.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Servislerin tanýmlandýðý yer burasý


builder.Services.AddBusinessServices();

builder.Services.AddAutoMapper(typeof(SolutionMappingProfile));
builder.Services.AddAutoMapper(typeof(CustomerCommentMappingProfile));
builder.Services.AddAutoMapper(typeof(ProjectMappingProfile));
builder.Services.AddAutoMapper(typeof(ProjectCategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(TeamMemberMappingProfile));

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
