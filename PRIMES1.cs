using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Test
    {
        public static void Main()
        {
            List<int> primes = sieve();
            int t = int.Parse(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                string line = Console.ReadLine();
                string[] startEndTokens = line.Split(' ');
                int start = int.Parse(startEndTokens[0]);
                int end = int.Parse(startEndTokens[1]);
                if (end < 2) Console.WriteLine("");
                if (start < 2) start = 2;
                int[] ss = new int[end - start + 1];
                foreach (int prime in primes)
                {
                    int startinss = getStart(prime, start, end);
                    if (startinss == -1)
                        break;
                    
                    for (int s = startinss - start; s <= end - start; s += prime)
                        ss[s] = -1;
                }
                for (int r = 0; r <= end - start; r++)
                    if (ss[r] != -1)
                        Console.WriteLine(r + start);
            }
        }
        private static int getStart(int prime, int start, int end)
        {
            
            if (prime >= start)
                return (2 * prime <= end) ? 2 * prime : -1;
            if (start % prime == 0) return start;
            return start + mod(-start, prime);
        }

        private static int mod(int a , int b)
        {

            if (b < 0) { a = -a; b = -b; }
            if (a < 0)  return b - (-a % b);
            return a % b;
        }

        
        private static List<int> sieve()
        {
            int max = 32000;
            int[] s = new int[max];
            s[0] = s[1] = -1;
            for (int i = 2; i <= Math.Sqrt(max); i++)
            {
                if (s[i] == -1) continue;
                for (int j = i * i; j <= Math.Sqrt(max); j += i)
                    s[j] = -1;
            }
            List<int> primes = new List<int>();
            for (int k = 0; k < max; k++)
                if (s[k] != -1)
                    primes.Add(k);
            return primes;
        }
    }