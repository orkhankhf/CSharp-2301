using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PastHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Homework1();
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



        public static void Homework1()
        {
            XDocument Xdocument = new XDocument(
                new XDeclaration("1.0", "UTF-8", "yes"),
                    new XComment("Tələbə məlumatları"),
                    new XElement("Students",
                        new XComment("Tələbə 1"),
                        new XElement("Student",
                            new XAttribute("Id", "1"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 2"),
                        new XElement("Student",
                            new XAttribute("Id", "2"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 3"),
                        new XElement("Student",
                            new XAttribute("Id", "3"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 4"),
                        new XElement("Student",
                            new XAttribute("Id", "4"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 5"),
                        new XElement("Student",
                            new XAttribute("Id", "5"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 6"),
                        new XElement("Student",
                            new XAttribute("Id", "6"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 7"),
                        new XElement("Student",
                            new XAttribute("Id", "7"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 8"),
                        new XElement("Student",
                            new XAttribute("Id", "8"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 9"),
                        new XElement("Student",
                            new XAttribute("Id", "9"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        ),
                        new XComment("Tələbə 10"),
                        new XElement("Student",
                            new XAttribute("Id", "10"),
                            new XElement("Name", "Orkhan"),
                            new XElement("Surname", "Farajov"),
                            new XElement("Gender", "Male"),
                            new XElement("Birthdate", "24.12.1995"),
                            new XElement("Degree", "Doctoral"),
                            new XElement("Contact",
                                new XElement("Address", "Azerbaijan, Baku, Yasamal"),
                                new XElement("Phone", "000-000-00-00")
                            )
                        )
                    )
            );
            Xdocument.Save(@"C:\\XML\\Students.xml");
        }
    }
}
