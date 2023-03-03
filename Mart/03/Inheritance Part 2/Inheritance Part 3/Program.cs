using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Part_3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             object => Person =>
                                 Employee
                                 Student X
                                 Teacher X
             */

            #region Protected access modifier
            /*
             public : istər proyektin daxilindən və ya kənarından obyekti əlçatan edir
             private : bir property'ni və ya method'u private etdiyimiz zaman ancaq olduğu class daxilində onu istifadə edə bilərik.
             protected : protected normalda private kimi davranır. Yəni bir method və ya property'ni protected etsəm, onu
                         ancaq class daxilində istifadə edə bilərəm. Ancaq həmin class'dan başqa bir class miras alarsa,
                         o zaman miras alan class üçün public kimi davranır.
             NOT: Bir class, private və ya protected ola bilməz.
             */
            Person person = new Person();
            person.Test();

            //Student student = new Student();
            //student.
            #endregion
        }
    }
}
