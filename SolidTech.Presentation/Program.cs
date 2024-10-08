using SolidTech.Business.Mappings;
using SolidTech.Data;
using SolidTech.Presentation.InFrustracture.Extensions;

var builder = WebApplication.CreateBuilder(args);

//Servislerin tan�mland��� yer buras�


builder.Services.AddBusinessServices();

builder.Services.AddAutoMapper(typeof(SolutionMappingProfile));
builder.Services.AddAutoMapper(typeof(CustomerCommentMappingProfile));
builder.Services.AddAutoMapper(typeof(ProjectMappingProfile));
builder.Services.AddAutoMapper(typeof(ProjectCategoryMappingProfile));
builder.Services.AddAutoMapper(typeof(TeamMemberMappingProfile));

builder.Services.AddControllersWithViews();//Uygulamada Controller ve View yap�sn�n kullanabilmek i�in bu servisi ekliyoruz 

//appsetings.json 'dan Connection bilgilerini al ve Data katman�ndaki Constructor'a aktar
//builder.Services.AddDbContext<SolidTechContext>(options =>
//{
//    options.UseSqlServer("Server=.;Database=SolidTechDb;Trusted_Connection=True;Encrypt=False");
//});

builder.Services.AddDbContext<SolidTechContext>();

var app = builder.Build();

app.UseStaticFiles();//Uygulamada "wwwroot" klas�r� alt�nda static dosyalar� kullanabilmek i�in ekliyoruz(css,js,images)


app.UseRouting();


app.MapControllerRoute(name: "default",
                       pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
