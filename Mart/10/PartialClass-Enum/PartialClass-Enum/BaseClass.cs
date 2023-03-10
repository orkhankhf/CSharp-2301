using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass_Enum
{
    public abstract class BaseClass<T>
    {
        public object Id { get; set; }
        public DateTime CreateDate { get; set; }
        public int CreateUser { get; set; }
        public DateTime? EditDate { get; set; }
        public int EditUser { get; set; }
        public DateTime? DeleteDate { get; set; }
        public int DeleteUser { get; set; }
        public bool IsDeleted { get; set; }

        public abstract T Get(int id);
        public abstract T[] GetAll();
        public abstract int Add(T item);
        public abstract T Update(T item);
        public abstract bool Delete(int id);
    }
}
