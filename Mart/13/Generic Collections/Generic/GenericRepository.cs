using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class GenericRepository<T> where T : class
    {
        public virtual List<T> Get()
        {
            return null;
        }

        public virtual void Add(T data)
        {

        }
    }
}
