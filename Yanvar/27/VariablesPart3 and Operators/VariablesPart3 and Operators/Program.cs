using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesPart3_and_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Boxing and Unboxing
            {
                //Implicit
                int valueType = 100; //Stackda saxlanilir
                object referanceType = valueType;

                //Explicit
                object otherRefType = (object)valueType;


                int a = 100;
                object o = a;
                int unboxing = (int)o;


                //xeta hansi halda cixa biler?
                int b = 100;
                object o1 = b;

                int test = (int)o1;
            }
            #endregion



            #region Convert, Parse and TryParse
            string textNumber = "100";

            //with Convert class
            int convertToInt = Convert.ToInt32(textNumber);

            //with Parse method
            int parseInt = int.Parse(textNumber);

            //with TryParse method
            int integerValue;

            string notNumberString = "5Salam";
            bool badResult = int.TryParse(notNumberString, out integerValue);

            string numberString = "5";
            bool goodResult = int.TryParse(numberString, out integerValue);
            #endregion


            #region Task in Lesson 1
            /*
             Bir boolean tipində dəyişəniniz olsun və dəyəri də true olsun. Bir dənə də int tipində dəyişən yaradıb dəyərini 1 set edəcəksiz. Bu int
             dəyişəninə dəyəri 1 set edəndən sonra, elə edin ki, boolean tipində dəyişəni necəsə konvertasiya edib 0 dəyərini əldə edəsiniz. Convert,
             Parse və ya TryParse'dan istifadə etməlisiz.
             */

            bool booleanVar = true;
            string stringVar = Convert.ToString(booleanVar);

            int resultOfTryParse = 1;

            bool parse = int.TryParse(stringVar, out resultOfTryParse);

            int result = Convert.ToInt32(parse);

            string nullString = null;
            int nullConvertResult = Convert.ToInt32(nullString); //(returns default value)
            //int nullParseResult = int.Parse(nullString); //(error)
            int nullOutVal = 2;
            bool tryToParseNull = int.TryParse(nullString, out nullOutVal); //(returns default value)


            string notIntString = "A";
            //int notIntConvertResult = Convert.ToInt32(notIntString); //(error)
            //int notIntParseResult = int.Parse(notIntString); //(error)
            int notIntOutVal = 2;
            bool tryToParseNotInt = int.TryParse(notIntString, out notIntOutVal); //(returns default value)
            #endregion

            #region Task in Lesson 2
            /*
             Task 1: 
                 İki dənə int tipində dəyişəniniz olacaq. Birinin dəyəri 1, digərinin dəyəri 0 olacaq. Sonra bu iki int 
                 tipindən başqa boolean tipində 2 dəyişəniniz olacaq. Bu iki int tipində olan dəyişəninizi digər iki
                 boolean tipində dəyişənə çevirəcəksiz.
             */

            int falseVal = 0;
            int trueVal = 1;

            bool falseBool1 = Convert.ToBoolean(falseVal);
            bool trueBool1 = Convert.ToBoolean(trueVal);

            /*
             Task 2: 
                 Bir dənə DateTime tipində dəyişəniniz olsun və indiki zamanı götürün. Sonra o dəyişəni bir başqa object
                 tipindəki dəyişənə mənimsədin. Yəni Boxing. Sonra DateTime tipində 3-cü bir dəyişən yaradın və 2-ci
                 yaratdığınız object'in dəyərini 3-cü yaratdığınız DateTime tipində olan dəyişənə verin.
             */

            DateTime now = DateTime.Now;
            object objDate = now;
            DateTime dateFromObject = Convert.ToDateTime(objDate);

            /*
             Task 3: 
                 İki string tipində dəyişəndə True və False sözlərini saxlayın. Sonra bu string'ləri bool tipində 
                 bir dəyişənə çevirin. Convert'dən istifadə etmək olmaz.
             */
            string trueText = "True";
            bool trueFromText = bool.Parse(trueText);

            string falseText = "False";
            bool falseFromText = bool.Parse(falseText);
            #endregion





            #region Constant
            double pi = 3.14;
            //bir ay kecdi
            pi = 5.20;


            const double piConst = 3.14;
            //piConst = 5;


            int no;
            no = 100;

            const int number = 500;
            const int buildingNo = number;
            #endregion





            #region Var keyword
            int number1 = 1;
            string text = "Hello baby";
            decimal dec = 45.3M;
            double dob = 100.20D;
            DateTime dt = DateTime.Now;
            char ch = '2';
            long l = 888555222111;
            short s = 10000;

            var numberVar = 1;
            var text2 = "Hello baby";
            var decVar = 45.3M;
            var dobVar = 100.20D;
            var dtVar = DateTime.Now;
            var chVar = '2';
            var lVar = 888555222111;
            var sVar = 10000;

            var i1 = 100;
            //i = "salam";

            //IL
            //MSIL
            //type inferance

            string name = null;
            int aa;
            var bb = 5;

            object objectVariable = 1;
            objectVariable = "Test";
            objectVariable = true;
            objectVariable = '$';
            objectVariable = DateTime.Now;

            int seeIntMethods = 5;
            string seeStringMethods = "salam";

            object obj = seeIntMethods;
            object obj1 = seeStringMethods;




            int number2, number3, otherNumber;
            string name3, surname, fatherName, birthPlace;
            DateTime startDate, endDate;

            int no1 = 20, no2 = 40, no3 = 100;
            string firstname = "Orkhan", lastname = "Farajov", color = "White";
            #endregion




            #region Operators
            /*
              Qeyd:
              1. Unary: a++, b--, !true;
              2. Binary: a + b, a > b, a = b;
              3. Ternary: a > b ? "" : "" (shorthand if else)
              Operator nədir?: +, -, *, !, !=
              Operand nədir?: a, b, c (dəyişən və s.)

              Qeyd:
              1. Arithmetic (hesablama)     ++, --, +, -, *, /, %
              2. Logical    (məntiqi)       !, ||, && 
              3. Special    (xüsusi)        sizeof, typeof, new, checked, unchecked, as, is
              4. Assignment (mənimsəmə)     =, +=, -=, /=, *=, %=
              5. Comparsion (qarşılaşdırma) >, <, ==, !=, <=, >=
             */

            decimal x = 100;
            decimal y = 5;
            decimal i = 0;

            //Arithmetic (hesablama)
            i = x + y;
            i = x - y;
            i--; //(i = i - 1) ilə eynidir
            i++; //(i = i + 1) ilə eynidir
            i = i - 1;
            i = i + 1;
            i -= 5; //(i bərabərdir i çıx 5)
            i += 5; //(i bərabərdir i üstəgəl 5)
            i = x--; //(x-dən 1 çıx, i-yə mənimsət. Burada x'in də dəyəri azalmış olur)
            i = y * 5;
            i = x / 5; //(cavab 5.1, 5.5 və ya 5.9 olsa belə, əgər bölən-bölünən int tipindədirsə cavab 5 olacaq yəni aşağı round olacaq.)
            i = x * y;
            i = x / y;
            i = x % y; //(modul)
            int m = 10 % 2; //(cavab 0 olacaq)
            m = 11 % 2; //(cavab 1 olacaq)
            string country = "Azerbaijan";
            string city = "Baki";
            string address = country + " " + city;



            //Logical (məntiqi)
            bool trueBool = true, falseBool = false, res;
            res = !trueBool;
            res = !falseBool;
            res = !falseBool || !trueBool;
            res = !falseBool && !trueBool;
            res = 5 == 5;


            //Assignment (mənimsəmə) - (bir dəyişənə dəyər mənimsətmək üçün istifadə olunur)
            int assign = 100;
            assign += 5; //(assign = assign + 5)
            assign -= 5; //(assign = assign - 5)
            assign /= 5; //(assign = assign / 5)
            assign *= 5; //(assign = assign * 5)
            assign %= 2; //(assign = assign % 2)
            string person = "Orkhan Farajov";
            person += " is developer";


            //Comparsion (qarşılaşdırma)
            int c = 100;
            int d = 5;
            string name1 = "Orkhan";
            string name2 = "John";

            bool compareRes = false;
            compareRes = c > d;
            compareRes = c < d;
            compareRes = c == d;
            compareRes = c != d;
            compareRes = c <= d;
            compareRes = c >= d;
            compareRes = name1 == name2;
            //compareRes = name1 == c; //(string və int tipində operandlar qarşılaşdırıla bilməz)
            res = (10 / 2) == 5;
            res = (10 / 2) != 5;


            //Special (xüsusi) sizeof, typeof, new, checked, unchecked, as, is
            int sizeOfSbyte = sizeof(sbyte); //1 byte
            int sizeOfByte = sizeof(byte); //1 byte (byte özü elə 1 byte yer tutur 8 bitdir)
            int sizeOfInt16 = sizeof(Int16); //2 byte
            int sizeOfShort = sizeof(short); //2 byte
            int sizeOfInt32 = sizeof(Int32); //4 byte
            int sizeOfInt = sizeof(int); //4 byte
            int sizeOfInt64 = sizeof(Int64); //8 byte
            int sizeOfLong = sizeof(long); //8 byte
            int sizeOfULong = sizeof(ulong); //8 byte
            int sizeOfUInt = sizeof(uint); //4 byte
            int sizeOfBool = sizeof(bool); //1 byte
            //int sizeOfString = sizeof(object); //(xəta)


            //typeof
            Type type1 = typeof(int);
            Type type2 = typeof(Int32);
            bool compareIntAndInt32 = type1 == type2;

            Type type3 = typeof(int);
            Type type4 = typeof(bool);
            bool compareIntAndBool = type3 == type4;

            DateTime dt1 = new DateTime();

            //is
            int otherInt = 25;
            bool isOtherInt_String = otherInt is string; //false
            bool isOtherInt_Int = otherInt is int; //true
            bool isOtherInt_Int32 = otherInt is Int32; //true
            bool isOtherInt_Int64 = otherInt is Int64; //false

            //as
            object objectName = "Orkhan";
            object objectNum = 5;
            string sName = objectName as string; 
            string sText = objectNum as string; //(null)
            //int aaa = objectNum as int; //(xəta)

            //10 + 20 * 5
            float u = 10 + 20 * 5; //110
            float u1 = (10 + 20) * 5; //150
            #endregion
        }
    }
}
