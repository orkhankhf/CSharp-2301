using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppPart5
{
    public class VirtualDatabase
    {
        public static List<Book> BooksTable = new List<Book>()
        {
            new Book()
            {
                Id=1,
                Name = "Sərbəst insanlar ölkəsində",
                Author = "Əhməd Ağaoğlu",
                Category = "Hüquq",
                Count = 350,
                Description = "“Sərbəst insanlar ölkəsində” əsərində Əhməd bəy Ağaoğlu görmək istədiyi ideal cəmiyyəti təsvir edib. Ağaoğlu əsarət zəncirlərini qıraraq qaçan bir türkün demokratik ölkəyə gəlməsi və bu ölkənin vətəndaşı olması üçün nələr etməli olduğunu göstərir. Sərbəst İnsanlar Ölkəsi kimi adlandırdığı bu xəyali ölkənin başqalarının hüquqlarına hörmət edən, qanunlarla idarə olunan bir yer olduğunu təsvir edir...",
                ImagePath = @"C:\Users\Education\Desktop\1.jpg"
            },
            new Book()
            {
                Id=2,
                Name = "59 saniyə",
                Author = "Riçard Vayzman",
                Category = "Psixologiya",
                Count = 500,
                Description = "Psixoloq-professo Riçard Vayzman öz kitabında insanların məqsədlərinə çatmağın yeni üsul və prinsiplərini izah edir. Riçard Vayzman izah edir ki, insanlar öz məqsəd və ambisiyalarına cəmi 59 saniyə ərzində nail ola bilərlər...",
                ImagePath = @"C:\Users\Education\Desktop\2.jpg"
            },
            new Book()
            {
                Id=3,
                Name = "Analitik Psikoloji Üzerine İki Deneme",
                Author = "Carl Gustav Jung",
                Category = "Psixologiya",
                Count = 150,
                Description = "Bu kitap, belki de Jung’un çalışmalarına en iyi giriş niteliği taşımaktadır. “Bilinçdışı Psikolojisi” ve “Ben ve Bilinçdışı” adlı iki deneme Jung’un sisteminin ana hatlarını sunar. Tarihsel açıdan da Jung’un Freud’la olan yakın işbirliğinin nasıl son bulduğunu gösterir...",
                ImagePath = @"C:\Users\Education\Desktop\3.jpg"
            },
            new Book()
            {
                Id=4,
                Name = "Söhbət kofedən getmir",
                Author = "Hovard Behar",
                Category = "Biznes",
                Count = 550,
                Description = "'Söhbət kofedən getmir' kitabı ən kiçik biznes sahiblərindən tutmuş ən böyük şirkətlərədək hər bir biznes adamına ünvanlanıb. Kitab böyük xəyallar qurmağı bacaran iş adamlarına, eyni zamanda yenicə başlayan biznes həvəskarlarına uğur qazanmağın sirlərini açır...",
                ImagePath = @"C:\Users\Education\Desktop\4.jpg"
            }
        };
    }
}
