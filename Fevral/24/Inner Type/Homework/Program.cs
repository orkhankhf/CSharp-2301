using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                Customer içində inner type olaraq yazacağınız array'lardakı dataları göstərən bir neçə methodunuz olacaq. Həmin method'lar
                Customer'in öz məlumatlarını, Order'lərini, Contact'larını, Address'lərini və s. göstərəcək. Main method'unda yaradacağınız
                customer instance'ının vasitəsilə həm ayrı-ayrılıqda Contact, Address və s., həm də bütün məlumatları da görmək olsun.
                Bütün məlumatlar dedikdə yəni, customer.ShowAllInfo() method'u bütün məlumatları çıxardacaq və ya customer.ShowAddresses()
                isə sadəcə ünvan məlumatlarını göstərəcək. Ünvan məlumatlarında nəzərə alın ki, inner type olan'ların da property'ləri 
                ekrana yazdırılsın. Əgər EditDate null olarsa, o zaman "Data is not edited" olmazsa da editlənmə tarixi 12.12.2022 formatla
                göstərilsin.

                Məsələn Contact üzərindən bir nümunə verim.
                customer.ShowContacts() method'u ekrana bu şəkildə çıxmalıdır:
                Id: 1
                Email: orkhankhf@gmail.com
                PhoneNumber: +994555810872
                CreateDate: 12.12.2014
                EditDate: Data is not edited

                (əgər 2-ci Contact varsa aşağıdakı da çıxsın)
                Id: 2
                Email: test@gmail.com
                PhoneNumber: +994551231212
                CreateDate: 12.12.2015
                EditDate: 12.12.2018
             */
        }
    }
}
