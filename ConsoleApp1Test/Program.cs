using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1Test
{
    public class Program
    {
        static int a = 100;
        static int b = 0;
        static int c = 0;
        static int d = 350;
        static DateTime aa;
        static DateTime bb;

        static void Main(string[] args)
        {
            while (true)
            {
                aa = DateTime.Now;

                Random random = new Random();
                var r = random.Next() % 4;
                Thread.Sleep(r + 1000);

                bb = DateTime.Now;

                var ts = (bb - aa).TotalSeconds;
                if (ts >= 3)
                {
                    ++a;
                    ++b;
                    if (a == 500)
                    {
                        a = 100;
                        aa = bb;
                    }
                }
                c = d / a * 100;

                Console.WriteLine(string.Format("a={0},b={1},c={2}", a, b, c));
            }
        }

    }
}
