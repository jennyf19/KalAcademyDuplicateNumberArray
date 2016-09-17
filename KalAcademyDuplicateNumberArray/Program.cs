using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KalAcademyDuplicateNumberArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 4, 5, 7, 6, 4, 12 };
            int sum1 = myArray1.Sum();
            int[] myArray2 = new int[5];

            Array.Copy(myArray1, 0, myArray2, 0, 5);

            int sum2 = myArray2.Sum();
            int duplicate = sum1 - sum2;

            Console.WriteLine("The duplicate is " + duplicate);
            Console.ReadLine();

        }


    }

}
