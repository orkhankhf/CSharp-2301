using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class Calculate
    {
        public void ShowMenu()
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Cixma");
            Console.WriteLine("3 - Vurma");
            Console.WriteLine("4 - Bolme");
            Console.WriteLine("Emeliyyati secin: ");
        }

        //toplama
        public decimal Addition(decimal num1, decimal num2)
        {
            decimal result = num1 + num2;
            return result;
        }

        //çıxma
        public decimal Subtraction(decimal num1, decimal num2)
        {
            decimal result = num1 - num2;
            return result;
        }

        //bölmə
        public decimal Divide(decimal num1, decimal num2)
        {
            if (num2 == 0)
                return 0;

            decimal result = num1 / num2;
            return result;
        }

        //vurma
        public decimal Multiplication(decimal num1, decimal num2)
        {
            decimal result = num1 * num2;
            return result;
        }

        public void ShowResult(decimal num1, decimal num2, decimal result, string operatorStr)
        {
            Console.WriteLine("{0} {1} {2} = {3}", num1, operatorStr, num2, result);
        }
    }
}
