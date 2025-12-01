using lesson9.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Api
{
    public interface ICustomer:ICrud<Customer>
    {
        public bool ChangingPhone(long phone);
    }
}
