using lesson9.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Api
{
    public interface IApartment:ICrud<Apartment>
    {
        public bool Moving(string adress);
    }
}
