using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AgeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime myAge;
            //Console.WriteLine("What's your year now");
            myAge = Convert.ToDateTime(Console.ReadLine());
            int year = Convert.ToInt32(DateTime.Now.Subtract(myAge).TotalDays) / 360;
            Console.WriteLine("Your age is " + year + " years old");
            Console.ReadKey();
        }
    }
}
