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
-UseSqlServer

-Postgre Sql
-UseNpgsql

--
Add-Migration migrationName 
Update-Database