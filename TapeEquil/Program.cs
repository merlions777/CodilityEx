﻿//A non-empty zero-indexed array A consisting of N integers is given. Array A represents numbers on a tape.
//Any integer P, such that 0 < P < N, splits this tape into two non-empty parts: A[0], A[1], ..., A[P − 1] and A[P], A[P + 1], ..., A[N − 1].
//The difference between the two parts is the value of: |(A[0] + A[1] + ... + A[P − 1]) − (A[P] + A[P + 1] + ... + A[N − 1])|
//In other words, it is the absolute difference between the sum of the first part and the sum of the second part.
//For example, consider array A such that:
//A[0] = 3 A[1] = 1 A[2] = 2 A[3] = 4 A[4] = 3
//We can split this tape in four places:
//    • P = 1, difference = |3 − 10| = 7 
//    • P = 2, difference = |4 − 9| = 5 
//    • P = 3, difference = |6 − 7| = 1 
//    • P = 4, difference = |10 − 3| = 7 
//Write a function:
//    class Solution { public int solution(int[] A); }
//that, given a non-empty zero-indexed array A of N integers, returns the minimal difference that can be achieved.
//For example, given:
//A[0] = 3 A[1] = 1 A[2] = 2 A[3] = 4 A[4] = 3
//the function should return 1, as explained above.
//Assume that:
//    • N is an integer within the range [2..100,000];
//    • each element of array A is an integer within the range [−1,000..1,000].
//Complexity:
//    • expected worst-case time complexity is O(N);
//expected worst-case space complexity is O(N), beyond input storage (not counting the storage required for input arguments).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapeEquil
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

            Solution s = new Solution();

            Console.WriteLine(" The Tape Equilibrium  is " + s.solution(a));

        }
    }

    class Solution
    {
        public int solution(int[] A)
        {

            int equi = -1;
            long lower = 0;
            long upper = 0;
            foreach (int i in A)
                upper += i;
            for (int i = 0; i < A.Length; i++)
            {
                upper -= A[i];
                if (upper == lower)
                {
                    equi = i;
                    break;
                }
                else
                    lower += A[i];
            }
            return equi;
        }

    }
}
    

