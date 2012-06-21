using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tinycodebits
{
    public class MiscHelperMethods
    {
        public static int FibinacciNumber(int position)
        {
            //0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55
            //nth  = nth-1 + nth-2
            switch (position)
            {
                case 1:
                    return 0;
                case 2:
                    return 1;
                default:
                    int nth_2 = 0;
                    int nth_1 = 1;
                    int index = 2;
                    int nth = 1;
                    while (index < position)
                    {
                        index++;
                        nth = nth_1 + nth_2;
                        nth_2 = nth_1;
                        nth_1 = nth;
                    }
                    return nth;
            }
        }


        public static int EquilibriumIndex(int[] A)
        {
            //travers the array twice.  once from the start and once from the end
            //summing up the numbers in the first iteration and storing them in a array
            //sumfromstart(p) = sum of the numbers from index 0 to index p-1
            //in the second iteration, start summing from the end and compare to the
            //numbers we got summing from the start
            int nbItems = A.Length;
            long[] sumfromstart = new long[nbItems];

            sumfromstart[0] = 0;

            int sum = 0;
            for (int i = 1; i < nbItems; i++)
            {
                sum= sum + A[i-1];
                sumfromstart[i] = sum;
            }

            if (sumfromstart[nbItems - 1] == 0)
                return nbItems - 1;

            sum = 0;
            for (int i = nbItems - 2; i > -1; i--)
            {
               sum = sum + A[i + 1];
                if (sum == sumfromstart[i])
                    return i;
            }

            return -1;
        }

        public static void FizzBuzz()
        {
            string toPrint;
            for (int i = 1; i < 101; i++)
            {
                toPrint = i.ToString();
                if (i % 3 == 0 && i % 5 == 0) toPrint = "FizzBuzz";
                if (i % 3 == 0) toPrint = "Fizz";
                if (i % 5 == 0) toPrint = "Buzz";
                Console.WriteLine(toPrint);
            }
        }

        public static void SortArrays(int[] array1, int[] array2)
        {
            //bubble sort


        }
    }
}
