using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collections
{
    public class VirtualDatabase
    {
        private ArrayList _db = new ArrayList();

        public VirtualDatabase()
        {
            
        }

        public void Add(int data)
        {
            _db.Add(data);
        }
    }
}
