using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycilicRotation
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

            Console.WriteLine("Please enter the rotation size");
            int rotation = int.Parse(Console.ReadLine());

            Console.WriteLine(" The new rotated array is " + string.Join(",", Solution(a, rotation)));

            Console.ReadLine();
        }

        static int[] Solution(int[] A, int K)
        {

            if (A.Length == 0 || A.Length == 1)
            {
                return A;
            }

            
            int[] B = new int[A.Length];

            Console.WriteLine(" The elements in array are " + string.Join(",", A));

            var len = A.Length;

            for (int i = 0; i < A.Length; i++)
            {

                if ( i < (K%len))
                {
                    B[i] = A[(len - (K % len)) + i];
                }
                else
                {
                    B[i] = A[Math.Abs((K % len) - i)];
                }
               
            }

            

            return B;
        }
    }
}
