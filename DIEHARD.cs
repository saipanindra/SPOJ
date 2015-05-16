using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIEHARD
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                string haline = Console.ReadLine();
                string[] ha = haline.Split(' ');
                int H = int.Parse(ha[0]);
                int A = int.Parse(ha[1]);
                int sol = 1;
                H += 3; A += 2;
                while (H > 0 && A > 0)
                {
                    int sw = 0;
                    int sf = 0;
                    int hw = -5, aw = -10, hf = -20, af = 5;
                    if ((H + hw) > 0 && (A + aw) > 0) sw = (A + aw) + (H + hw);
                    if ((H + hf) > 0 && (A + af) > 0) sf = (A + af) + (H + hf);
                    if (sf == 0 && sw == 0) break;
                    if (sf > sw)
                    {
                        H += hf;
                        A += af;
                    }
                    else
                    {
                        H += hw;
                        A += aw;
                    }

                    A += 2;
                    H += 3;
                    sol += 2;
                }
                Console.WriteLine(sol);
                t--;
            }
            
        }
    }
}
