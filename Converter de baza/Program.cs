using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static int Fromxto10(int[] n, int x)
        {
            int u = 0, i = 0;
            for (int j = 0; j < n.Length; j++)
            {
                u += n[j] * Convert.ToInt32(Math.Pow(x, i));
                i++;
            }
            return u;
        }
        static void From10tox(int n, int x)
        {
            StringBuilder sb = new StringBuilder();
            while (n != 0)
            {
                if (n % x == 10)
                    sb.Append('A');
                else if (n % x == 11)
                    sb.Append('B');
                else if (n % x == 12)
                    sb.Append('C');
                else if (n % x == 13)
                    sb.Append('D');
                else if (n % x == 14)
                    sb.Append('E');
                else if (n % x == 15)
                    sb.Append('F');
                else
                    sb.Append(n % x);
                n /= x;
            }
            Console.WriteLine(sb.ToString().Reverse().ToArray());

        }
        static void Main(string[] args)
        {
            Console.Write("Numarul pe care il convertiti:");
            string m = "0123456789ABCDEF";
            string s = Console.ReadLine();
            int[] n = new int[s.Length];
            int r = s.Length - 1;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < m.Length; j++)
                {
                    if (s[i] == m[j])
                    {
                        n[r] = j;
                        r--;
                    }
                }
            }
            Console.Write("Baza din care convertiti:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Baza in care convertiti:");
            int y = int.Parse(Console.ReadLine());
            From10tox(Fromxto10(n, x), y);
            Console.ReadKey();
        }
    }
}
