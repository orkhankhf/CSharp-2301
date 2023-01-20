using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        public static string Country { get; set; } = "Azerbaijan";

        static void Main(string[] args)
        {
            //#region What is Data Type
            //string oneString = "1"; //suse qabda duyunu saxladiq
            //int oneInteger = 1; //parca torbada duyunu saxladiq

            //string aString = "a"; //suse qabda mayeni saxladiq
            //                      //int aInteger = "a"; //error (mayeni parca torbada saxlaya bilmeyeceyik)

            ///*
            //  Byte hesablama disturu:
            //  1 byte = 8 bit
            //  Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
            //  Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
            //  Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte
            // */

            ///*
            //  Value Type data tipleri:
            //    bool
            //    byte
            //    char
            //    decimal
            //    double
            //    enum
            //    float
            //    int
            //    long
            //    sbyte
            //    short
            //    struct
            //    ushort
            //    uint
            //    ulong

            //   Referance Type data tipleri:
            //    String
            //    Array
            //    Class
            //    Delegate

            //   Qeyd: Referance Type data tiplerinin default deyeri her zaman null olur.
            //         Ancaq Value Type data tiplerinin mutleq bir default deyeri olur.
            // */
            //#endregion


            //#region Practise with data types

            //#region Boolean Type
            ////Hecmi: 1 bit
            ////deyer araligi: true --- false
            ////tipi: Value Type

            //bool booleanVar = true;
            //booleanVar = false;

            //bool otherBooleanVar; //default olaraq false deyerini goturecek
            //otherBooleanVar = true;

            //string falseString = bool.FalseString;
            //string trueString = bool.TrueString;
            //#endregion


            //#region String Type
            ////Hecmi: her xarakter ucun 1 byte
            ////tipi: Referance Type

            //string name_ = "Orkhan";
            //Console.WriteLine(name_);

            //string surname_ = "Farajov";
            //Console.WriteLine(surname_);

            //string nameSurname = "teymur jafarov";

            //string upperNameSurname = nameSurname.ToUpper();

            //string lowerNameSurname = nameSurname.ToLower();

            //string substring = nameSurname.Substring(1, 5);

            //bool startsWith = nameSurname.StartsWith("t");

            //bool endsWith = nameSurname.EndsWith("v");

            //int length = nameSurname.Length;

            //int indexOf = nameSurname.IndexOf("y");

            //string substring2 = nameSurname.Substring(indexOf, 5);

            //bool equals = nameSurname.Equals("teymur jafarov");
            //#endregion


            //#region Short, Int, Long Types
            ////Hecmi:
            //    //int16: 2 byte
            //    //int32: 4 byte
            //    //int64: 8 byte
            ////deyer araligi:
            //    //int16 bit üçün: −32,768 --- 32,767
            //    //int32 bit üçün: −2147483648 --- 2147483647
            //    //int64 bit üçün: −9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807
            ////tipi:
            //    //Value Type

            //short shortMinValue = short.MinValue;
            //short shortMaxValue = short.MaxValue;
            //short shortValue = 18262;
            //short shortValueNegative = -1562;

            //int intMinValue = int.MinValue;
            //int intMaxValue = int.MaxValue;
            //int intValue = 25612565;
            //int intValueNegative = -222657;

            //long longMinValue = long.MinValue;
            //long longMaxValue = long.MaxValue;
            //long longValue = 894894895415648596;
            //long longValueNegative = -854848948481551;

            //string intToString = intValue.ToString();
            //#endregion

            //#region Task in Lesson 1
            //int a = 10;
            //int b = 20;
            //int c = a + b;
            //#endregion

            //#region Task in Lesson 2
            //string aze = "Azerbaycan";
            //string tur = "Turkiye";
            //string azeTur = aze + " " + tur;
            //#endregion


            //#region Char Type
            ////Hecmi: 2 byte
            ////tipi: Value Type

            //string a_ = "A";
            //string b_ = "b";
            //string c_ = "c";
            //string d_ = "d";
            //string e_ = "e";
            //string f_ = "f";
            //string g_ = "g";
            //string h_ = "h";

            //char a_char = 'A';
            //char b_char = 'b';
            //char c_char = 'c';
            //char d_char = 'd';
            //char e_char = 'e';
            //char f_char = 'f';
            //char g_char = 'g';
            //char h_char = 'h';

            //char symbol = '*';
            //char whiteSpace = ' ';
            //char question = '?';

            //char toLower = char.ToLower(a_char);
            //char toUpper = char.ToUpper(a_char);
            //bool isLower = char.IsLower(a_char);
            //bool isUpper = char.IsUpper(a_char);


            //bool isNumber = char.IsNumber(a_char);
            //bool isLetter = char.IsLetter(a_char);
            //bool isDigit = char.IsDigit(a_char);
            //bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            //#endregion


            //#region Byte Type
            ////Hecmi: 1 byte
            ////deyer araligi: 0 - 255
            ////tipi: Value Type

            //byte byteMinValue = byte.MinValue;
            //byte byteMaxValue = byte.MaxValue;
            //byte byteValue = 150;
            //#endregion

            //#region Double Type
            ////həcmi: 8 byte
            ////precision: 15-16 rəqəm
            ////dəyər aralığı: -1.7976931348623157E+308 --- 1.7976931348623157E+308
            ////tipi: Value-Type

            //double doubleVar = 10.2;
            //double doubleVar2 = 25;
            //double doubleVar3 = 45.8d;

            //double doubleMinValue = double.MinValue;
            //double doubleMaxValue = double.MaxValue;

            //double nan = 0.0 / 0.0;
            //double notNan = 5 / 2.5;
            //bool resultOfNan = double.IsNaN(nan);
            //bool resultOfNotNan = double.IsNaN(notNan);

            //double infinity = 0.1 / 0.0;
            //double notInfinity = 0.0 / 0.0;
            //bool resultOfInfinity = double.IsInfinity(infinity);
            //bool resultOfNotInfinity = double.IsInfinity(notInfinity);

            //double epl = double.Epsilon;
            //double epsilonValue = 4.94065645841247E-324;
            //double one = 0.1;

            //bool whichIsGreater = (one > epsilonValue);
            //#endregion



            //#region Task in Lesson 3
            ///*
            //  1. true
            //  2. 'A'
            //  3. 5
            //  4. "Salam"
            //  5. 999999999999999999
            // */

            //bool _1 = true;
            //char _2 = 'A';
            //byte _3 = 5;
            //string _4 = "Salam";
            //double _5 = 999999999999999999;
            //#endregion


            //#region Decimal Type
            ////həcmi: 16 byte
            ////precision: 28-29 rəqəm
            ////dəyər aralığı: -79228162514264337593543950335 --- 79228162514264337593543950335
            ////tipi: Value-Type

            //decimal decimalVar = 10.2m;

            //decimal decimalMinValue = decimal.MinValue;
            //decimal decimalMaxValue = decimal.MaxValue;

            //decimal minusOneValue = decimal.MinusOne;

            ////byte decimalToByte = decimal.ToByte(10000000);
            ////sbyte decimalToSByte = decimal.ToSByte(10000000);

            ////basqa numuneler
            //short decimalToShort = decimal.ToInt16(500);
            //int decimalToInt = decimal.ToInt32(222156);
            //long decimalToLong = decimal.ToInt64(1256151561561);
            //#endregion


            //#region Float Type
            ////həcmi: 4 byte / 32 bit
            ////precision: 7 rəqəm
            ////dəyər aralığı: -3.40282347E+38 --- 3.40282347E+38
            ////tipi: Value-Type

            //float floatVar = 10.2f;

            //float floatMinValue = float.MinValue;
            //float floatMaxValue = float.MaxValue;
            //#endregion



            //#region DateTime Type
            ////həcmi: 8 byte
            ////dəyər aralığı: 1/1/0001 12:00:00 AM --- 12/31/9999 11:59:59 PM
            ////tipi: Value-Type

            //DateTime now = DateTime.Now; //(Local saati goturur)
            //DateTime utcNow = DateTime.UtcNow; //(UTC = Coordinated Universal Time'i goturur)

            //long ticks = now.Ticks;
            //int milliSecond = now.Millisecond;
            //int second = now.Second;
            //int minute = now.Minute;
            //int hour = now.Hour;
            //int day = now.Day;
            //DayOfWeek dayOfWeek = now.DayOfWeek;
            //int month = now.Month;
            //int year = now.Year;
            //TimeSpan timeOfDay = now.TimeOfDay;
            //string shortDateString = now.ToShortDateString();
            //string longDateString = now.ToLongDateString();
            //string shortTimeString = now.ToShortTimeString();
            //string longTimeString = now.ToLongTimeString();
            //string timeFormat = now.ToString("MM/dd/yyyy HH:mm:ss");
            //string timeFormat2 = now.ToString("MMMM dd");
            //string timeFormat3 = now.ToString("dddd, dd MMMM yyyy");
            //string timeFormat4 = now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            //string timeFormat5 = now.ToString("HH:mm");
            //string timeFormat6 = now.ToString("h:mm");
            //string timeFormat7 = now.ToString("ddd, dd MMM yyy HH:mm:ss");

            //DateTime monthChanged = now.AddMonths(2);
            //DateTime dayChanged = now.AddDays(2);
            //DateTime hourChanged = now.AddHours(4);
            //DateTime minuteChanged = now.AddMinutes(15);
            //DateTime secondChanged = now.AddSeconds(5);
            //string changedTime = hourChanged.ToString("HH:mm");

            //DateTime specificDate = new DateTime(1990, 12, 25);
            //DateTime specificDateAndTime = new DateTime(1995, 12, 24, 10, 05, 59, 100);
            //#endregion


            //#region Object Type
            ////həcmi: 4 byte
            ////dəyər aralığı: bütün C# obyektləri
            ////tipi: Referance-Type

            //object stringVar = "My String";

            //object integerVar = 6251;

            //object boolVar = true;

            //object charVar = 'U';

            //object dateTimeVar = new DateTime();

            //Console.WriteLine(stringVar);
            //Console.WriteLine(integerVar);
            //Console.WriteLine(boolVar);
            //Console.WriteLine(charVar);
            //Console.WriteLine(dateTimeVar);
            //#endregion

            //#region Task in Lesson 3
            ////10.5 - 20.5 - 30.5

            //double _1dou = 10.5;
            //decimal _2dec = 20.5m;
            //float _3flo = 30.5f;
            //#endregion

            ////Ətraflı: https://condor.depaul.edu/sjost/nwdp/notes/cs1/CSDatatypes.htm
            //#endregion



            #region Assign one to another
            string orkhan = "Orkhan Farajov";
            string john = "John Farajov";

            orkhan = john;
            john = orkhan;

            orkhan = "hello";
            john = "hi";

            int fiveHundred = 500;
            int fiveHundredCopied = fiveHundred;

            bool isWinterCold = true;
            bool isSummerWarm = isWinterCold;
            isWinterCold = false; //eger isti iqlimi olan olkedirse

            int five = 5;
            int fiveCopied = five;

            char p = 'P';
            char pCopied = p;
            #endregion

            #region Task in Lesson 5
            //indiki zamani alsin
            //20 dek 2020

            DateTime _1date = DateTime.Now;
            DateTime _2date = new DateTime(2020, 12, 20);
            #endregion


            #region Default values of data types
            //referance types
            string defaultString;
            object defaultObject;
            Student defaultStudentClass;

            //value-types
            char defaultChar;
            byte defaultByte;
            short defaultShort;
            int defaultInt;
            long defaultLongr;
            double defaultDouble;
            decimal defaultDecimal;
            float defaultFloat;
            bool defaultBool;
            DateTime defaultDateTime; //ilk gunu goturur: 01.01.0001
            #endregion


            #region Local vs Global Variables
            Console.WriteLine(Country);

            int myLocalVariable = 5;
            myLocalVariable = 10;

            int globalVar = 0;

            {
                int localVar1 = 555;
                globalVar += localVar1;
            }

            {
                int localVar2 = 45;
                globalVar += localVar2;
            }

            {
                int localVar3 = 50;
                globalVar += localVar3;
            }


            //Level 5 - Bütün skoplara görə əl çatan (Main skopu içində)
            int level5 = 500;

            //level4 -= 100; //level 4 does not exists
            //level3 -= 100; //level 3 does not exists
            //level2 -= 100; //level 2 does not exists
            //level1 -= 100; //level 1 does not exists

            {
                //Level 4 - Alt skoplara görə global, üst skoplara görə Local
                int level4 = 400;

                level5 -= 100;
                //level3 -= 100; //level 3 does not exists
                //level2 -= 100; //level 2 does not exists
                //level1 -= 100; //level 1 does not exists

                {
                    //Level 3 - Alt skoplara görə global, üst skoplara görə Local
                    int level3 = 300;

                    level5 -= 100;
                    level4 -= 100;

                    //level2 -= 100; //level 2 does not exists
                    //level1 -= 100; //level 1 does not exists

                    {
                        //Level 2 - Alt skoplara görə global, üst skoplara görə Local
                        int level2 = 200;

                        level5 -= 100;
                        level4 -= 100;
                        level3 -= 100;
                        //level1 -= 100; //level 1 does not exists

                        {
                            //Level 1 - tamamilə local dəyişən
                            int level1 = 100;

                            level5 -= 100;
                            level4 -= 100;
                            level3 -= 100;
                            level2 -= 100;
                            level1 -= 100;
                        }
                    }
                }
            }

            //int globalAge;

            //{
            //    int localAge = 28;
            //}

            //{
            //    int otherLocalAge = localAge;
            //}
            #endregion
        }

        public static void ShowCountry()
        {
            Console.WriteLine(Country);
        }
    }
}
