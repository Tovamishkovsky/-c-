using lesson9.Api;
using lesson9.models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.services
{
    public class ApartmentService : IApartment
    {
        DBManager db=DBManager.GetInstance();
        public bool Create(Apartment item)
        {
            db.Apartments.Add(item);
            db.SaveChanges();
            return true;
        }

        public bool Delete(Apartment item)
        {
            throw new NotImplementedException();
        }

        public bool Moving(string adress)
        {
            //איך מעדכנים כתובת
            //this.SetAdress(adress);
            throw new NotImplementedException();
        }

        public List<Apartment> Read()
        {
            return db.Apartments.ToList();
        }

        public void Update(Apartment item)
        {
            throw new NotImplementedException();
        }
    }
}
