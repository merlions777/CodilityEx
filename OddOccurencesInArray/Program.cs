using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurencesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the size of the array");
            int sizeOfArray = int.Parse(Console.ReadLine());

            int[] a = new int[sizeOfArray];
            for (int i = 0; i < sizeOfArray; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(" The Odd index is " + Solution(a));

            Console.ReadLine();
        }

        

        static int Solution(int[] A)
        {
            int unMatchedValue = 0;
            foreach (var item in A)
            {
                if ( A.Count(x => x == item) % 2 != 0 )
                {
                    return item;
                }
            }

            return unMatchedValue;
        }
    }
}
