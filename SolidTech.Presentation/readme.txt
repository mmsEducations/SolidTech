Mikroservise yada Monolitik
Katmanlı mimari (Monolitik) mimari 
SolidTech.Presentation
-MVC Web projesi -kullanıcı ilet iletişimin olduğu kısım

SolidTech.Data
-Dll projesi 
-databasede bulunan tabloların etity(cs clası) olarak c# tarafında class karşılığı 

SolidTech.Business
-Dll projesi 
-controllerdan gelen isteklerin business üzerinden yönetildiği c# classları

-Database işlemleri için 
-Orm(Object Relational Mapping)
-Bir kütüphane bizim için database'de Crud operasyonlarını yapar
Create,Update,Delete,Select 
ENitity Framework Core
Ef Core yapısında 2 tane Yöntem var
1)Code First Yöntemi 
 c# classları aracılığı ile database'de tabloların otomatik olrak oluşturulması işlemidir 
 c# tarafındaki özel bazı classlara entity denir.Entitiy'nin en önemli özelliği database deki tablonun birebir c# tarafındaki karşılığıdır 
 -Tablo'nun class karşılığı yazılır 
 Note COdeFİrst komutunu çalıştırmak için "Microsoft.EntityFrameworkCore.Tools" ve "Microsoft.EntityFrameworkCore.Design" programı indirilmeli
2)Db First Yöntemi
 database ve tabloların manuel database tarafında oluşturulmasıdır 
 --
 EfCore 2 parçadan oluşur
 1)Entities
 2)Context

 --MsSqlServer Kullanılacaksa 
 --Microsoft.EntityFrameworkCore.SqlServer indirilmeli
-UseSqlServer kullanılmalı 

-Postgre Sql Kullanılacaksa
-UseNpgsql

--
Add-Migration migrationName 
Update-Database

---
DI(Dependecy Injection)
Dependency Injection (DI), bir sınıfın bağımlılıklarını dışarıdan sağlayarak, sınıflar arasındaki bağımlılıkları azaltan bir tasarım desenidir
Bu sayede kod daha modüler, test edilebilir ve bakımı daha kolay hale gelir. 
DI genellikle üç ana biçimde uygulanır: 
-constructor injection
-property injection 
-method injection. En yaygın olanı constructor injection’dır.
--
DI'nin Avantajları
Modülerlik: Sınıflar bağımlılıklarını dışarıdan alır, bu da daha az sıkı bağlanma sağlar.(Solid ilkesi-loosely copling)
Test Edilebilirlik: Mock nesneleri kullanarak sınıfları test etmek kolaylaşır.
Bakım Kolaylığı: Bağımlılıkların değişimini yönetmek daha basit hale gelir.

---
AutoMapper
.Net uygulamalrında kullanılan bir kütüphanedir:Nesneler arası veri aktarımı için kullanılır 
x nesnesini y nesnesine dönüştürme işini arka planda yapar 
 Genellikle bir nesnenin özelliklerini diğer bir nesneye kopyalamak için kullanılır. 
 Örneğin, bir veritabanı modelinden(entityden) bir DTO (Data Transfer Object) modeline dönüşüm yapmak için kullanılır.
 Automapper mantığı 
 1)Kaynak  :UserEntity
 2)Hedef   :UserDto
 3)Dönüşüm işlemi

 "AutoMapper" paketini yüklemek lazım 
 
 AutoMapper Entegrasyonu  
 using AutoMapper;

 //Automapperin iki model arasında dönüşüm işlemlerinin adımları(Implementasyon Adımları)
 //1
// Kaynak ve hedef nesneleri
public class Source
{
    public int Id { get; set; }
    public string Name { get; set; }
}

//2
public class Destination
{
    public int Id { get; set; }
    public string FullName { get; set; }
}
//3
// Profil oluşturma
public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Source, Destination>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.Name));
    }
}

//4
//2Kısım 
public class Startup
{
    public void ConfigureServices(IServiceCollection services)
    {
        // AutoMapper'ı ekle
        services.AddAutoMapper(typeof(MappingProfile));
    }
}

//5
public class ExampleService
{
    private readonly IMapper _mapper;

    public ExampleService(IMapper mapper)
    {
        _mapper = mapper;
    }

    public Destination Convert(Source source)
    {
        // Dönüşüm yap
        Destination destination = _mapper.Map<Destination>(source);
        return destination;
    }
}
//Not: Destination destination = _mapper.Map<DestinationVeriTipi>(sourceData);


Not:
MsSql'e bağlanmak için
<PackageReference Include="Microsoft.EntityFrameworkCore.SqlServer" Version="8.0.8" />

PostgreSQL'e bağlanmak için
<PackageReference Include="Npgsql.EntityFrameworkCore.PostgreSQL" Version="8.0.8" />