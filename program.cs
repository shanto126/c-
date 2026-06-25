using System;

namespace Shanto
{
    class S
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        public void Calculator()
        {
            Console.WriteLine("Enter an operator (+, -, *, /):");
            char op = Console.ReadKey().KeyChar;

            double result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    Console.WriteLine("\nResult: " + result);
                    break;

                case '-':
                    result = a - b;
                    Console.WriteLine("\nResult: " + result);
                    break;

                case '*':
                    result = a * b;
                    Console.WriteLine("\nResult: " + result);
                    break;

                case '/':
                    if (b == 0)
                    {
                        Console.WriteLine("\nCannot divide by 0");
                    }
                    else
                    {
                        result = a / b;
                        Console.WriteLine("\nResult: " + result);
                    }
                    break;

                default:
                    Console.WriteLine("\nInvalid operator");
                    break;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Enter first number: ");
            S s1 = new S();

            Console.Write("Enter operator after entering two numbers.\n");

            s1.Calculator();
        }
    }
}
