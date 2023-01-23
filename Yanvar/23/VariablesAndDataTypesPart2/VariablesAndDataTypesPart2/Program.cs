using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypesPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework of last lesson
            int globalAge = 0;

            {
                int localAge = 28;
                globalAge = localAge;
            }

            {
                int otherLocalAge = globalAge;
            }
            #endregion

            #region Simple form app
            {
                //Console.OutputEncoding = Encoding.Unicode;
                //Console.InputEncoding = Encoding.Unicode;

                //Console.WriteLine("Salam, xoş gəlmisiniz!");

                //Console.WriteLine("Adınızı daxil edin: ");
                //string name = Console.ReadLine();

                //Console.WriteLine("Soyadınızı daxil edin: ");
                //string surname = Console.ReadLine();

                //Console.WriteLine("Doğulduğunuz ölkəni daxil edin: ");
                //string country = Console.ReadLine();

                //Console.WriteLine("Boyunuzu daxil edin: ");
                //string height = Console.ReadLine();

                //Console.WriteLine("Çəkinizi daxil edin: ");
                //string weight = Console.ReadLine();

                //Console.Clear();

                //Console.WriteLine("Ad: " + name);
                //Console.WriteLine("Soyad: " + surname);
                //Console.WriteLine("Country: " + country);
                //Console.WriteLine("Height: " + height);
                //Console.WriteLine("Weight: " + weight);
                //Console.ReadLine();
            }
            #endregion
            
            #region Task in Lesson 1
            /*
                Kiçik bir anket app'ı hazırlayacaqsız. İlk öncə istifadəçiyə Xoş Gəldiniz! mesajı göstərin. Növbəti sətirdə adını soruşun. Adını daxil
                etdikdən sonra ona necə müraciət edəcəyini soruşun. Məsələn adını Orxan, müraciət qaydasını bəy olaraq yazdısa növbəti suallar belə
                olacaq:
                1. Orxan bəy neçə yaşınız var?
                2. Orxan bəy hansı sahədə işləyirsiniz?
                3. Orxan bəy ən son nə zaman kitab oxumusunuz?
                4. Orxan bəy sevdiyiniz rəng hansıdır?
                5. Orxan bəy avtomobil idarə edə bilirsiniz?
                6. Orxan bəy gündə neçə saat yatırsınız?
                7. Orxan bəy TV kanallarını izləyirsiniz?
                  
                Əgər istifadəçi müraciət qaydası olaraq bəy/xanım daxil etməsə o zaman birbaşa Orxan neçə yaşınız var? soruşsun.
                Axırıncı sualdan sonra "Anketə qatıldığınız üçün təşəkkür edirik!" yazsın.
             */

            {
                //Console.InputEncoding = Encoding.Unicode;
                //Console.OutputEncoding = Encoding.Unicode;

                //Console.WriteLine("Xoş Gəldiniz!");

                //string name, gender;

                //Console.Write("Adınızı daxil edin: ");
                //name = Console.ReadLine();

                //Console.Write("Sizə necə müraciət etməyimi istəyirsiniz? ");
                //gender = Console.ReadLine();

                //Console.Clear();

                //string age, work, lastBook, color, car, sleepTime, watchingTV;

                //Console.Write(name + " " + gender.ToLower() + " neçə yaşınız var?");
                //age = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " hansı sahədə işləyirsiniz?");
                //work = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " ən son nə zaman kitab oxumusunuz?");
                //lastBook = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " ən sevdiyiniz rəng hansıdır?");
                //color = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " avtomobil idarə edə bilirsiniz?");
                //car = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " gündə neçə saat yatırsınız?");
                //sleepTime = Console.ReadLine();

                //Console.Write(name + " " + gender.ToLower() + " TV kanallarını izləyirsiniz?");
                //watchingTV = Console.ReadLine();


                //Console.WriteLine(age);
                //Console.WriteLine(work);
                //Console.WriteLine(lastBook);
                //Console.WriteLine(color);
                //Console.WriteLine(car);
                //Console.WriteLine(sleepTime);
                //Console.WriteLine(watchingTV);

                //Console.ReadLine();
            }
            #endregion

            #region Type Conversion
            //Implicit
            //Explicit (casting)
            //User-Defined
            //Helper Class

            #region Implicit Type Conversion
            {
                //Numune 1: byte to short
                byte byteVal = byte.MaxValue; //255
                short shortVal = short.MaxValue; //32767
                short takeByteVal = byteVal; //implicit conversion
                //byte takeShortVal = shortVal;

                //Numune 2: short to int
                int takeShortVal = shortVal; //implicit conversion

                //Numune 3: byte to int
                int takeBt = byteVal; //implicit conversion

                //Numune 4:
                int i = 5000;
                long l = i;

                long l2 = 5000000;
                float f = l2;

                float f2 = 25.6F;
                double d = f2;

                //Ardıcıllıq: byte -> short -> int -> long -> float -> double
            }
            #endregion

            #region Signed - Unsigned data types
            {
                //Unsigned data types:
                byte us1 = byte.MinValue;     // 8-bit     0-255
                ushort us2 = ushort.MinValue; // 16-bit    0-65.535
                uint us3 = uint.MinValue;     // 32-bit    0-4.294.967.295
                ulong us4 = ulong.MinValue;   // 64-bit    0-18.446.744.073.709.551.615

                //Signed data types:
                sbyte s1 = sbyte.MinValue;   // 8-bit     -128   -   127
                short s2 = short.MinValue;   // 16-bit    -32768   -   32767
                int s3 = int.MinValue;       // 32-bit    -2.147.483.648   -   2.147.483.648
                long s4 = long.MinValue;     // 64-bit    -9.223.372.036.854.775.808    -    9.223.372.036.854.775.807

                /*
                 unsigned ushort deyer araligi: 0-65.535
                 signed short deyer araligi:    -32768 - 32767
                 32767 - 65535 = -32768
                 */
            }
            #endregion
            
            #region Explicit Type Conversion
            {
                //Numuneler:
                int a = 20000;
                //short b = a;

                double c = 799.25;
                //float d = c;

                short e = 20;
                //ushort f = e;

                float g = 20;
                //long h = g;

                long i = 2000000;
                //int j = i;

                //Numuneler:
                int a1 = 20000;
                short b1 = (short)a1;

                double c1 = 799.25;
                float d1 = (float)c1;

                short e1 = 20;
                ushort f1 = (ushort)e1;

                float g1 = 20;
                long h1 = (long)g1;

                long i1 = 30000;
                int j1 = (int)i1;

                short ch = 5;
                char charVar = (char)ch;
                //Yazılış qaydası: hədəfTip a = (hədəfTip)QaynaqDəyişən

                //Ardıcıllıq: double -> float -> long -> int -> char
            }
            #endregion
            
            #region Checked & Unchecked keywords
            {
                ////Casting without Checked keyword
                //long longVar = Convert.ToInt64(Console.ReadLine()); //99999999999999
                //int takeLongVar = (int)longVar;

                //short shortVar = Convert.ToInt16(Console.ReadLine()); //30000
                //byte takeShortVar = (byte)longVar;

                ////Casting with Checked keyword
                //checked
                //{
                //    long longVariable = Convert.ToInt64(Console.ReadLine()); //99999999999999
                //    int takeLongVariable = (int)longVariable;
                //}
                

                //checked
                //{
                //    int money = Convert.ToInt32(Console.ReadLine()); //100.000 error / 20 success
                //    short takeInt = (short)money;
                    
                //    unchecked
                //    {
                //        byte age = Convert.ToByte(Console.ReadLine()); //200
                //        sbyte takeByte = (sbyte)age;
                //    }
                //}
            }
            #endregion

            #region Helper Class Conversions
            {
                //string numberString = "50";
                //int number;

                ////Implicit Conversion numunesi:
                ////number = numberString;

                ////Explicit Conversion numunesi:
                ////number = (int)numberString;

                ////Helper Class Conversion numunesi:
                //number = Convert.ToInt32(numberString);

                ////Not possible:
                ////bool booleanVariable = 1;
                ////bool booleanVariable = (bool)1;
                ////int integerVariable = (int)"1";
                ////int integerVariable = (int)true;

                ////Possible
                //bool booleanVariable;
                //booleanVariable = Convert.ToBoolean(1);
                //booleanVariable = Convert.ToBoolean("true");
                //booleanVariable = Convert.ToBoolean(null); //false

                //int integerVariable;
                //integerVariable = Convert.ToInt32("10");
                //integerVariable = Convert.ToInt32(null);
                //integerVariable = Convert.ToInt32(true);
                //integerVariable = Convert.ToInt32(false);

                //string numString = "45";

                ////short stringToShort = numString;
                ////short stringToShort = (short)numString;
                //short stringToShort = Convert.ToInt16(numString);

                ////int stringToInt = numString;
                ////int stringToInt = (int)numString;
                //int stringToInt = Convert.ToInt32(numString);

                ////long stringToLong = numString;
                ////long stringToLong = (long)numString;
                //long stringToLong = Convert.ToInt64(numString);


                ////Source data types
                //int intVariable = 10;
                //long longVariable = 99999999;
                //short shortVariable = 1500;
                //byte byteVariable = 200;
                //bool boolVariable = true;

                ////Destination type
                //string getAnyValue;

                //getAnyValue = intVariable.ToString();
                //getAnyValue = longVariable.ToString();
                //getAnyValue = shortVariable.ToString();
                //getAnyValue = byteVariable.ToString();
                //getAnyValue = boolVariable.ToString();


                //bool _boolVariable = Convert.ToBoolean("true");       //false //(0/1 yazsaq error verəcək)
                //byte _byteVariable = Convert.ToByte("10");             //unsigned
                //char _charVariable = Convert.ToChar("A");
                //DateTime _dateTimeVariable = Convert.ToDateTime("2020-12-12");
                //decimal _decimalVariable = Convert.ToDecimal("15.2");
                //double _doubleVariable = Convert.ToDouble("15.2");
                //short _shortVariable = Convert.ToInt16("-25000");      //signed
                //int _intVariable = Convert.ToInt32("1500000");
                //long _longVariable = Convert.ToInt64("200000000000");
                //sbyte _sByteVariable = Convert.ToSByte("12");
                //ushort _ushortVariable = Convert.ToUInt16("20");       //unsigned
                //uint _uintVariable = Convert.ToUInt32("9500");         //unsigned     
                //ulong _ulongVariable = Convert.ToUInt64("8888000000"); //unsigned

                ////uint error = Convert.ToUInt32("-300");
            }
            #endregion

            #region User-Defined Conversions
            //DateTime dateTime = new DateTime(1990, 12, 12);
            Student student = new Student("Orkhan", "Farajov", 28);

            string strStudent = student;
            string strStudentCast = (string)student;

            int stAge = student;
            int stAgeCast = (int)student;

            bool stBool = student;
            bool stBoolCast = (bool)student;

            string strStudentToString = student.ToString();
            #endregion
            #endregion
        }
    }
}
