using System;

namespace Calculator // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calcObj = new Calculator();
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            calcObj.Add();
            calcObj.Addition(num1, num2);
            calcObj.Subtraction(num1, num2);

        }
    }
}

