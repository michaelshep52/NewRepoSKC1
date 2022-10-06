using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        public static bool NumberPlacement(string calFunt, out int num1, out int num2)
        {
            Console.WriteLine("Enter 2 integers to " + calFunt);
            var number1 = Console.ReadLine();
            var number2 = Console.ReadLine();

            if (int.TryParse(number1, out int num1cal) && int.TryParse(number2, out int num2cal))
            {
                num1 = num1cal;
                num2 = num2cal;
                return true;
            }
            else
            {
                Console.WriteLine("One or more of the numbers is not an int");
                num1 = 0;
                num2 = 0;
                return false;
            }
        }
        public static void Main(string[] args)
        {

            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    var success = NumberPlacement("add", out int num1, out int num2);
                    if (success ==true)
                    {
                        Console.WriteLine($"{num1} + {num2} = ");
                        Console.WriteLine(calculator.Add(num1, num2));
                    }
                    break;

                case "2":
                    success = NumberPlacement("sub", out int subnum1, out int subnum2);
                    if (success == true)
                    {
                        Console.WriteLine($"{subnum1} - {subnum2} = ");
                        Console.WriteLine(calculator.Subtract(subnum1, subnum2));
                    }
                    break;

                case "3":
                    success = NumberPlacement("mult", out int multnum1, out int multnum2);
                    if (success == true)
                    {
                        Console.WriteLine($"{multnum1} + {multnum2} = ");
                        Console.WriteLine(calculator.Multiply(multnum1, multnum2));
                    }
                    break;

                case "4":
                    success = NumberPlacement("div", out double divnum1, out double divnum2);
                    if (success == true)
                    {
                        Console.WriteLine($"{divnum1} / {divnum2} = ");
                        Console.WriteLine(calculator.Divide(divnum1, divnum2));
                    }
                    break;

                default:
                    Console.WriteLine("Unknown input");
                    break;
            }
        }

        private static bool NumberPlacement(string v, out double divnum1, out double divnum2)
        {
            throw new NotImplementedException();
        }
    }
}