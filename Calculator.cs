using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {
        public void Add()
        {
            int num1 = 20;
            int num2 = 40;
            int sum = num1 + num2;
            Console.WriteLine("Addition of two numbers is {0}",sum);
        }

        public void Addition(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine("Addition of two numbers {0}+{1}={2}",num1,num2, sum);
        }
        //Subtraction logic
        public void Subtraction(int num1, int num2)
        {
            int subtraction = num1 - num2;
            Console.WriteLine("Subtraction of two numbers {0}-{1}={2}", num1, num2, subtraction);
        }
        //Multiplication
        public void Multiplication(int num1, int num2)
        {
            int multiplication = num1 * num2;
            Console.WriteLine("multiplication of two numbers {0}*{1}={2}", num1, num2, multiplication);
        }

        public void Division(int num1, int num2)
        {
            int division = num1 / num2;
            Console.WriteLine("Division of two numbers {0}/{1}={2}", num1, num2, division);
        }
    }
}
