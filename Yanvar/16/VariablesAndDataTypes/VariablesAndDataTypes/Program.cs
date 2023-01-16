using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesAndDataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            #region What is Data Type
            string oneString = "1"; //suse qabda duyunu saxladiq
            int oneInteger = 1; //parca torbada duyunu saxladiq

            string aString = "a"; //suse qabda mayeni saxladiq
                                  //int aInteger = "a"; //error (mayeni parca torbada saxlaya bilmeyeceyik)

            /*
              Byte hesablama disturu:
              1 byte = 8 bit
              Int16 tipi 16 bit'dir. - 16 bit / 8 bit = 2 byte
              Int32 tipi 32 bit'dir. - 32 bit / 8 bit = 4 byte
              Int64 tipi 64 bit'dir. - 64 bit / 8 bit = 8 byte
             */

            /*
              Value Type data tipleri:
                bool
                byte
                char
                decimal
                double
                enum
                float
                int
                long
                sbyte
                short
                struct
                ushort
                uint
                ulong

               Referance Type data tipleri:
                String
                Array
                Class
                Delegate

               Qeyd: Referance Type data tiplerinin default deyeri her zaman null olur.
                     Ancaq Value Type data tiplerinin mutleq bir default deyeri olur.
             */
            #endregion


            #region Practise with data types

            #region Boolean Type
            //Hecmi: 1 bit
            //deyer araligi: true --- false
            //tipi: Value Type

            bool booleanVar = true;
            booleanVar = false;

            bool otherBooleanVar; //default olaraq false deyerini goturecek
            otherBooleanVar = true;

            string falseString = bool.FalseString;
            string trueString = bool.TrueString;
            #endregion


            #region String Type
            //Hecmi: her xarakter ucun 1 byte
            //tipi: Referance Type

            string name_ = "Orkhan";
            Console.WriteLine(name_);

            string surname_ = "Farajov";
            Console.WriteLine(surname_);

            string nameSurname = "teymur jafarov";

            string upperNameSurname = nameSurname.ToUpper();

            string lowerNameSurname = nameSurname.ToLower();

            string substring = nameSurname.Substring(1, 5);

            bool startsWith = nameSurname.StartsWith("t");

            bool endsWith = nameSurname.EndsWith("v");

            int length = nameSurname.Length;

            int indexOf = nameSurname.IndexOf("y");

            string substring2 = nameSurname.Substring(indexOf, 5);

            bool equals = nameSurname.Equals("teymur jafarov");
            #endregion


            #region Short, Int, Long Types
            //Hecmi:
                //int16: 2 byte
                //int32: 4 byte
                //int64: 8 byte
            //deyer araligi:
                //int16 bit üçün: −32,768 --- 32,767
                //int32 bit üçün: −2147483648 --- 2147483647
                //int64 bit üçün: −9,223,372,036,854,775,808 --- 9,223,372,036,854,775,807
            //tipi:
                //Value Type

            short shortMinValue = short.MinValue;
            short shortMaxValue = short.MaxValue;
            short shortValue = 18262;
            short shortValueNegative = -1562;

            int intMinValue = int.MinValue;
            int intMaxValue = int.MaxValue;
            int intValue = 25612565;
            int intValueNegative = -222657;

            long longMinValue = long.MinValue;
            long longMaxValue = long.MaxValue;
            long longValue = 894894895415648596;
            long longValueNegative = -854848948481551;

            string intToString = intValue.ToString();
            #endregion

            #region Task in Lesson 1
            int a = 10;
            int b = 20;
            int c = a + b;
            #endregion

            #region Task in Lesson 2
            string aze = "Azerbaycan";
            string tur = "Turkiye";
            string azeTur = aze + " " + tur;
            #endregion


            #region Char Type
            //Hecmi: 2 byte
            //tipi: Value Type

            string a_ = "A";
            string b_ = "b";
            string c_ = "c";
            string d_ = "d";
            string e_ = "e";
            string f_ = "f";
            string g_ = "g";
            string h_ = "h";

            char a_char = 'A';
            char b_char = 'b';
            char c_char = 'c';
            char d_char = 'd';
            char e_char = 'e';
            char f_char = 'f';
            char g_char = 'g';
            char h_char = 'h';

            char symbol = '*';
            char whiteSpace = ' ';
            char question = '?';

            char toLower = char.ToLower(a_char);
            char toUpper = char.ToUpper(a_char);
            bool isLower = char.IsLower(a_char);
            bool isUpper = char.IsUpper(a_char);


            bool isNumber = char.IsNumber(a_char);
            bool isLetter = char.IsLetter(a_char);
            bool isDigit = char.IsDigit(a_char);
            bool isWhiteSpace = char.IsWhiteSpace(whiteSpace);
            #endregion


            #region Byte Type
            //Hecmi: 1 byte
            //deyer araligi: 0 - 255
            //tipi: Value Type

            byte byteMinValue = byte.MinValue;
            byte byteMaxValue = byte.MaxValue;
            byte byteValue = 150;
            #endregion
            #endregion
        }
    }
}
