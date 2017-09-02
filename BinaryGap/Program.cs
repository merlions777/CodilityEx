using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            int val = int.Parse(Console.ReadLine());
            Console.WriteLine("The binary gap of number " + val + " is " + Solution2(val));
            Console.ReadLine();
        }

        public static int Solution(long N)
        {
            int binaryGap = 0;

            char[] a = Convert.ToString(N, 2).ToCharArray();
            Console.WriteLine("The binary representation of the number " + N + " is " + string.Join(" ",a));
            //find if there are any zero`s 
            if (! a.Contains('0'))
            {
                return 0;
            }
            else
            {
                var indexes = Enumerable.Range(0, a.Length).Where(e => a[e] == '1').ToArray();
                // Temp variable to be used in loop
                int gap = 0;

                for (int i = indexes.Length-1; i > 0 ; i--)
                {
                    gap = indexes[i] - indexes[i - 1];
                    if (gap> binaryGap)
                    {
                        binaryGap = gap;
                    }

                }
            }
           
            return binaryGap-1;
        }

        public static int Solution2(long N)
        {
            var a = Convert.ToString(N, 2);
            var b = a.Trim('0');
            Console.WriteLine(b);
            var c = b.Split(new[] {'1'});
            foreach (var item in c)
            {
                Console.WriteLine(item);
            }
            var d = c.Max(x => x.Length);

            return Convert
                .ToString(N, 2)
                .Trim('0')
                .Split(new[] { '1' })
                .Max(x => x.Length);
        }

    }
}
