using System;

namespace TallerRecursividad
{
    class Program
    {
        static void Main(string[] args)
        {

            int countnumber(int number)
            {
                if (number == 1)
                {
                    return 1;
                }
                else
                {
                    return number +countnumber(number -1);
                }
            }

            void printcountnumber()
            {
                Console.WriteLine("Enter a number");
                int number = Int32.Parse(Console.ReadLine());
                if (number>0)
                {
                    Console.WriteLine("The total of the numbers is: " + countnumber(number));
                }                
            }
                printcountnumber();

            int reverseCountNumber(int number)
            {
                if (number == 0)
                {
                    return 0;
                }
                else
                {
                    return ((number % 10) + reverseCountNumber(number /10));
                }
            }

            void PrintReverseCountNumber()
            {
                Console.WriteLine("Enter a number");
                int number = Int32.Parse(Console.ReadLine());
                if (number > 0)
                {
                    Console.WriteLine("The sum of los numbers enters is: " + reverseCountNumber(number));
                }
            }
            PrintReverseCountNumber();

            int numberPrime(int number, int i)
            {
                if (i == 1)
                {
                    return 1;
                }
                else if (number % i == 0)
                {
                    return 0;
                }
                else
                {
                    return numberPrime(number, i - 1);
                }

            }

            void printNumberPrime()
            {
                Console.WriteLine("Enter a number");
                int number = Int32.Parse(Console.ReadLine());
                int valnumber = numberPrime(number, (number / 2));
                if (valnumber == 1)
                {
                    Console.WriteLine("The number enter is prime  ");
                }
                else
                {
                    Console.WriteLine("The number enter is not prime  ");
                }
            }
            printNumberPrime();
        }
    }
}
