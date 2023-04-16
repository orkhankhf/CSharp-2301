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
             Homework:
             Win form'da bir app yığacaqsız. App açılanda bir dənə DataGridView olacaq (boş) və altında bir button olacaq (Generate Persons). Bu button'a click edəndə Fake Data ilə 1000 nəfər
             adam generate olacaq Ad, Soyad, Email və Ölkə. Bu datalar GridView'da görünəcək və yenidən Generate Persons button'una click edəndə DataGridView'dakı əvvəlki 1000 nəfər gedəcək
             əvəzinə yeni generate olunanların dataları görsənəcək. Bura qədər işin asan qismidir :) Əsas məsələ hər dəfə Generate Persons'a click edəndə yaranan 1000 nəfəri DataGridView'də
             göstərməklə yanaşı C:/Countries/ folder'i altında toplamaqdır. Yəni user 10 dəfə 1000 nəfər generate edərsə 10.000 nəfərin datası C:/Countries/ folder'ində saxlanılacaq.
             Ancaq bütün person'ları Countries folder'ində saxlamayacaqsız. Generate olunan random adamların ölkələrinə görə Countries folder'inin içində də ölkələrə görə kateqoriyaya böləcəksiz.
             Məsələn belə:
             C:/Countries/Azerbaijan/orkhan-farajov-447589.txt (faylın adındakı rəqəm random bir rəqəm olacaq)
             C:/Countries/Azerbaijan/samir-jafarov-151615.txt
             C:/Countries/Turkey/eren-can-156245.txt
             C:/Countries/Turkey/murat-boz-748925.txt
             Yəni hər dəfə generate olunan zaman adamın aid olduğu ölkə folder'ində ona ad-soyad-randomRəqəm.txt faylı yaradacaqsız :)
             
             Bunu edib bitirəndən sonra da əsas səhifədə Generate Persons button'unun yanında "Get Person Statistics" button'u da qoyub ona da basanda Countries folder'inin içindəki
             məlumatlara əsasən yeni bir pəncərə açıb hansı ölkədə neçə nəfər insan var kimi bir statistika göstərin. Statistika pəncərəsində ad soyad göstərməyə ehtiyyac yoxdur sadəcə ölkədəki
             insan sayı kifayət edir.

             Bonus: Taskı edib bitirəndən sonra ölkələrin adları olan folderlərin içində 0-18, 19-35, 36-60, 60+ olaraq insanları 4 yaş qrupuna bölənə və statistikanı da buna görə göstərənə
                    supriz var :) Bonus hissəsini başlamamışdan proyekti kopyalayın başqa yerə ki, aləmi bir birinə qatanda əvvəlki halı əlinizdə olsun))) Qaş düzəldəndə göz çıxartmayaq :D
             */
        }
    }
}
