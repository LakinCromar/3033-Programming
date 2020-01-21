//Lakin Cromar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3, num4;
            num1 = 51;
            num2 = 45;
            num3 = 83;
            num4 = 1022;
            double result = Add(num3, num1);
            Console.WriteLine($"{num3} + {num1} = {result}");
         

            double result2 = Subtract(num4, num2);
            Console.WriteLine($"{num4} - {num2} = {result2}");

            double[] allnums = new double[5];
            allnums[0] = 1;
            allnums[1] = 68;
            allnums[2] = 41;
            allnums[3] = 23;
            allnums[4] = 5;
            double result3 = Add(allnums);
            Console.WriteLine(result3);
            Console.ReadKey();
        }
        /// <summary>
        /// Adds up two values 
        /// </summary>
        /// <param name="val1">left operand</param>
        /// <param name="val2">right operand</param>
        /// <returns></returns>
        static double Add(double val1,double val2)
        {
            double sum = val1 + val2;
            return sum;
        }
        static double Subtract(double val1, double val2)
        {
            return val1 - val2;
          
        }
        static double Add(double[] values)
        {
            //While Loop
            //double sum = 0;
            //int counter = 0;
            //while (counter< values.Length)
            //{
            //    sum += values[counter];
            //    counter++;
            //}

            //For Loop
            //double sum = 0;
            //for (int i = 0; i < values.Length; i++)
            //{
            //    sum += values[i];
            //}

            //ForEach Loop
            double sum = 0;
            foreach (var item in values)
            {
                sum += item;
            }
            return sum;
        }
        static void DatabaseStuff()
        {
            //In slides and he'll post code on canvas
        }
    }
}
