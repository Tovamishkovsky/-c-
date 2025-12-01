using lesson9.Api;
using lesson9.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.services
{
    public class CastomerService : ICustomer
    {
        DBManager db = DBManager.GetInstance();
        public bool ChangingPhone(long phone)
        {
            throw new NotImplementedException();
        }

        public bool Create(Customer item)
        {
            db.Customers.Add(item);
            db.SaveChanges();
            return true;
        }

        public bool Delete(Customer item)
        {
            //לא ממש הצלחתי לממש את זה
            // אם אפשר לחזור על מימוש של פונקצית מחיקה
            var customer = db.Customers.Where(x => x.Id == item.Id).ToList();
            
            db.Customers.Remove(customer);
            //db.Customers.Remove(item);
            db.SaveChanges();
            return true;
        }

        public List<Customer> Read()
        {
            return db.Customers.ToList();
        }

        

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
