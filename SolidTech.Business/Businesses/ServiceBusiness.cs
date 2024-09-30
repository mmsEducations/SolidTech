using SolidTech.Business.Interfaces;
using SolidTech.Data;
using SolidTech.Data.Entities;

namespace SolidTech.Business.Businesses
{
    public class ServiceBusiness : IServiceBusiness
    {
        //radonly değişkenlere sadece constructorda değer atanır buda onun const ile farkını beirler

        #region 1
        private readonly SolidTechContext _context;
        #endregion

        #region 2
        public ServiceBusiness(SolidTechContext context)//Dışardan bir SolidTechContext gönderilecek 
        {
            _context = context;
        }

        public void Athisrsizi()
        {
            throw new NotImplementedException();
        }

        #endregion
        //Constructor injection'ın kuralları 
        //1)Global bir değişken tanımlanır(Clasın direk içerisinde)
        //2)Constructor içerisinde parametre olarak dışarıdan enjecte edilen değişkeni temsilen global değişken ile aynı tipte bir değişken tanımlabır 
        //3)Constructor'da gönderilen dışarıdan enjekte edilen değişken global değişkene atanır
        //4)Program.cs içerisinde kullanılan servisi WebApplication builder'a haber vermemiz gerkir 


        public List<Service> GetServices()
        {

            return _context.Services.ToList();
        }


        #region Old
        /*
     
        public List<Service> GetServices()
        {
            SolidTechContext context = new SolidTechContext();
            context.Services.ToList();
        }


        public Service GetService(int serviceId)
        {
            SolidTechContext context = new SolidTechContext();
            context.Services.Where(x => x.ServiceId).ToList();
        } 
    
        */
        #endregion

        //Solid
    }
}
