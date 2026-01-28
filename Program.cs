using Microsoft.VisualBasic;
using System;
using System.Diagnostics.Tracing;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Assignment3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Number 1
            ReturnEvenNumbers();

            // Number 2
            CheckYear(2016);
            CheckYear(2100);
            CheckYear(2049);
            CheckYear(2050);
            CheckYear(2070);
            CheckYear(1999);
            CheckYear(99);
            CheckYear(2052);
            CheckYear(2076);
            CheckYear(2080);
            CheckYear(200);


            //Number 3
            Spacechecker();

            //Number4

            ArrayChecker();




        }
        static void ReturnEvenNumbers()
        {
            StringBuilder sb = new StringBuilder();
            int storednums = 0;
            for (int i = 0; i < 49; i++)
            {
                storednums = storednums + 2;
                sb.Append(storednums);
                sb.Append(" ");
            }
            Console.WriteLine(sb);
        }


        static void CheckYear(int year)
        {

            if (year % 4 == 0)
                if (year % 100 == 0 && !(year % 400 == 0))
                {
                    Console.WriteLine($"{year} is not a leap year!");
                }
                else
                {
                    Console.WriteLine($"{year} is a leap year!");
                }
            else
            {
                Console.WriteLine($"{year} is not a leap year!");
            }
        }

        static void Spacechecker()
        {
            Console.WriteLine("Please enter input a string:");
            string input = Console.ReadLine();

            Console.WriteLine($"'{input}' contains {input.Count(' ')} spaces!");


        }

        static void ArrayChecker()
        {
            Console.WriteLine("Input 7 elements stored in the array ranging from 0-9!");

            int count = 0;
            int[] numArray = new int[7];
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.Write($"Enter the value:");
                numArray[i] = int.Parse(Console.ReadLine());
                
            }

            //Reading th string an applying a counter to not have more than two items be converted!!

            for (int i = 0; i < numArray.Length; i++)
            {
                if (numArray[i] == 1 && count < 2)
                {
                    numArray[i] = 0;
                    count++;
                }
                Console.WriteLine(numArray[i]);

            }
        }
    }
}

    


  


 
    
