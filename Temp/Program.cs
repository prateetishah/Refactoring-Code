using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public string Foobar(int a, int b)
        {
            int countA = 0;
            int countB = 0;
            string result = "";
            for (int i = 0; i <= Math.Max(a,b); i++)
            {
                if (i <= a)
                {
                    countA += i;
                }
                if (i <= b)
                {
                    countB += i;
                }
                
            }
            result += string.Format("Sum of A: {0}; Sum of B: {1}", countA, countB);
            return result;
        }
    }
}
