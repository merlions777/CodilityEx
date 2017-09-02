using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermMissingElem
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

            Console.WriteLine("The missing element is " + solution(a));

            Console.ReadLine();
        }

        public static int solution(int[] A)
        {

            SortedSet<int> aSet = new SortedSet<int>(A);
            ISet<int> sSet = new SortedSet<int>(Enumerable.Range(1, A.Length+1));
            
            sSet.ExceptWith(aSet);

            return sSet.ToList()[0];
        }
    }
}
