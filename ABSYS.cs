using System;
using System.Text;


namespace ABSYS
{
 

    public class Program 
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());
            while (t > 0)
            {
                Console.ReadLine();
                string l = Console.ReadLine();
                processLine(l);
                t--;
            }

        }
        private static void processLine(string input)
        {
            string[] tokens = input.Split(' ');
            int first = int.MinValue, second = int.MinValue, result = int.MinValue;
            bool machulaInFirst, machulaInSecond, machulaInResult;
            machulaInFirst = !int.TryParse(tokens[0].Trim(), out first);
            machulaInSecond = !int.TryParse(tokens[2].Trim(), out second);
            machulaInResult = !int.TryParse(tokens[4].Trim(), out result);
            int temp = machulaInFirst ? (result - second) : (machulaInSecond ? (result - first) : (first + second));
            StringBuilder final = new StringBuilder();
            final.Append((machulaInFirst ? temp.ToString() : tokens[0].Trim())).Append(" + ")
                .Append((machulaInSecond ? temp.ToString() : tokens[2].Trim())).Append(" = ")
                .Append((machulaInResult ? temp.ToString() : tokens[4].Trim()));
            Console.WriteLine(final);
        }
    }
}
