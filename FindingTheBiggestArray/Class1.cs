using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindingTheBiggestArray
{
    internal static class Numbers
    {
        public static int BiggestNumber(int[] numbers)
        {
            int biggestNumber = numbers[0];

            foreach (int number in numbers)
            {
                if (number > biggestNumber)
                {
                    biggestNumber = number;
                }
            }

            return biggestNumber;

        }

        public static int SecondBiggestNumber(int[] numbers)
        {

            int biggestNumber = BiggestNumber(numbers);

            Console.WriteLine("the biggest number on the array is " + biggestNumber);
        
            //SECOND BIGGEST NUMBER
            int secondBiggestNumber = numbers[0];
            
            foreach (int number in numbers)
            {
                if ((number > secondBiggestNumber) && (number < biggestNumber))
                {

                    secondBiggestNumber = number;
                }
            }

            return secondBiggestNumber;
            Console.WriteLine("the bigest number on the array is " + secondBiggestNumber);

        }

        /*  internal static int BiggestNumber(object mynumbers)
          {
              throw new NotImplementedException();
          }*/
    }
}