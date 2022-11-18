using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skiv hvor høyt tallet skal kunne gå");
            int topp = Convert.ToInt32(Console.ReadLine());
            var rett = false;
            Random num = new Random();
            int RettNum = num.Next(topp + 1);
            int forsok = 0;
            while (rett == false)
            {
                Console.WriteLine("gjett tallet");
                int gjett = Convert.ToInt32(Console.ReadLine());
                if (gjett < RettNum)
                {
                    Console.WriteLine("Tallet du skrev inn, er for lavt");
                }
                else if (gjett > RettNum)
                {
                    Console.WriteLine("Tallet du skrev inn, er for høyt");
                }
                else
                {
                    Console.WriteLine("Du svarte rett");
                    rett = true;
                }
                forsok++;
            }
            Console.WriteLine("Du brukte " + forsok + " forsøk på å finne svaret");
            Console.ReadLine();
        }
    }
}
