using lesson9.models;
using lesson9.services;

namespace lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DBManager db = new();
            db.Apartments.ToList().ForEach(a => Console.WriteLine("adress: " + a.Adress + " size: " + a.Size + " price: " + a.Price));
            db.InterestTables.Where(a=>a.IdCustomerNavigation.FullName=="tovamishkovsky").ToList().ForEach(a => Console.WriteLine(a.IdApartmentNavigation.Adress));//הדירות שtovamishkovsky התעניינה בהם 
            Apartment a=new Apartment();
            a.Size = 300;
            a.Price = 6000000;
            a.Adress = "rova hayeudi";
            a.Id = 456;
            db.Apartments.Add(a);
            Customer c=new Customer();
            c.FullName = "sason";
            c.Phone = 123456789;
            c.Id = 456789;
            db.Customers.Add(c);
            db.SaveChanges();

            db.Apartments.ToList().ForEach(a => Console.WriteLine("adress: " + a.Adress + " size: " + a.Size + " price: " + a.Price));

            CastomerService cus = new CastomerService();
            cus.Create(new Customer());
            
            ApartmentService apa=new ApartmentService();
            apa.Create(new Apartment());
            
        }
    }
}
