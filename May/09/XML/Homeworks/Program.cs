using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homeworks
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
              Homework 1:
              XDocument'dən istifadə edərək aşağıdakı xml faylını yaradacaqsınız. Döngülərdən istifadə etmək olmaz. Commentləri də yaratmalısız.
              Yaratdığınız xml'i C:/XML/Students.xml faylına save edin (ilk öncə folder və faylı yaradın sonra kodu işə salın). Sətir arasındakı
              boşluqlara və tab'lara fikir verməyin. Sizin faylda fərqli olsa da olar. Burda strukturu aydın görə biləsiniz deyə aralı yazmışam.

              <?xml version="1.0" encoding="utf-8" standalone="true"?>

                <!-- Tələbə məlumatları -->
                <Students>
                  <!-- Tələbə 1 -->
                  <Student Id="1">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>
  
                  <!-- Tələbə 2 -->
                  <Student Id="2">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 3 -->
                  <Student Id="3">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 4 -->
                  <Student Id="4">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 5 -->
                  <Student Id="5">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 6 -->
                  <Student Id="6">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 7 -->
                  <Student Id="7">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 8 -->
                  <Student Id="8">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 9 -->
                  <Student Id="9">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>

                  <!-- Tələbə 10 -->
                  <Student Id="10">
                    <Name>Hər hansısa ad</Name>
                    <Surname>Hər hansısa soyad</Surname>
                    <Gender>Male/Female</Gender>
                    <Birthdate>Hər hansısa tarix</Birthdate>
                    <Degree>Hər hansısa dərəcə: Associate, Bachelor's, Master's, Doctoral</Degree>
                    <Contact>
                      <Address>Azerbaijan, Baku, Yasamal</Address>
                      <Phone>000-000-00-00</Phone>
                    </Contact>
                  </Student>
                </Students>
             */
        }
    }
}
