using MathOperations;
using MathOperations.Enums;

namespace SomeProject
{
    class Program
    {
        static void Main(string[] args)
        {
            var additionRes = MathOperation.Calculate(15, 20, MathOperationTypeEnum.Addition);
            var subtractionRes = MathOperation.Calculate(100, 35, MathOperationTypeEnum.Subtraction);
            var multiplicationRes = MathOperation.Calculate(5, 40, MathOperationTypeEnum.Multiplication);
            var divideRes = MathOperation.Calculate(30, 0, MathOperationTypeEnum.Divide);
        }
    }
}
