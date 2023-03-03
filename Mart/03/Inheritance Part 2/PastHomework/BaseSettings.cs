using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PastHomework
{
    public class BaseSettings : Base
    {
        public int RegUser { get; set; }
        public DateTime RegDate { get; set; }
        public int? EditUser { get; set; }
        public DateTime? EditDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
