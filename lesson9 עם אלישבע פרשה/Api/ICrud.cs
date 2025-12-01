using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson9.Api
{
    public interface ICrud<T>
    {
        bool Create(T item);
        List<T> Read();
        void Update(T item);
        bool Delete(T item);
    }
}
