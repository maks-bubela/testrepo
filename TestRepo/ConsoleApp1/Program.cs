using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static int EuclidAlgorithm(int r1, int r2, int r)
        {
            if (r > 0)
            {
                return EuclidAlgorithm(r2, r1 % r2, r1 % r2);
            }
            return r1;
        }

        private static Dictionary<char, int> LinearDiophantineEquation(int r1, int r2)
        {
            Dictionary<char, int> result = new Dictionary<char, int>();

            int r = 1, d = EuclidAlgorithm(r1, r2, r1 - r2);
            int s1 = 1, s2 = 0, s;
            int t1 = 0, t2 = 1, t;
            int q;

            while (r != 0)
            {
                q = (int)Math.Truncate(Convert.ToDecimal(r1 / r2));
                r = r1 - (r2 * q);
                r1 = r2;
                r2 = r;

                s = s1 - s2 * q;
                s1 = s2;
                s2 = s;

                t = t1 - t2 * q;
                t1 = t2;
                t2 = t;
            }

            result.Add('x', s1);
            result.Add('y', t1);
            result.Add('d', d);

            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1. Знайти НСД чисел по алгоритму Евклiда.\n");
            Console.WriteLine($"({589}, {343}) = {EuclidAlgorithm(589, 343, 589 - 343)}");
            Console.WriteLine($"({987}, {610}) = {EuclidAlgorithm(987, 610, 987 - 610)}");


            Console.WriteLine("\n2. Нехай d = (a,b). Знайти всi цiлi числа x такi, що ax + by = d.\n");

            var result = LinearDiophantineEquation(70, 33);
            Console.WriteLine($"1) ({70},{33}): x = {result['x']}, y = {result['y']}, НСД({70},{33}) = {result['d']}." +
                $"\n   Множини усiх x: x = {result['x']}{(33 / result['d']).ToString("+0;-#")}k;\n" +
                $"   Множини усiх y: y = {result['y']}{((70 / result['d']) * (-1)).ToString("+0;-#")}k.\n");
            // gwfwkuhgvuwehiheuivdusdvioduich oioigosdigghk  jhuhsdiughisdghoisduh
            result = LinearDiophantineEquation(60, 91);
            Console.WriteLine($"2) ({60},{91}): x = {result['x']}, y = {result['y']}, НСД({60},{91}) = {result['d']}." +
                $"\n   Множини усiх x: x = {result['x']}{(91 / result['d']).ToString("+0;-#")}k;\n" +
                $"   Множини усiх y: y = {result['y']}{((60 / result['d']) * (-1)).ToString("+0;-#")}k.\n");

            result = LinearDiophantineEquation(571, 359);
            Console.WriteLine($"3) ({571},{359}): x = {result['x']}, y = {result['y']}, НСД({571},{359}) = {result['d']}." +
                $"\n   Множини усiх x: x = {result['x']}{(359 / result['d']).ToString("+0;-#")}k;\n" +
                $"   Множини усiх y: y = {result['y']}{((571 / result['d']) * (-1)).ToString("+0;-#")}k.\n");

            result = LinearDiophantineEquation(13, 17);
            Console.WriteLine($"4) ({13},{17}): x = {result['x']}, y = {result['y']}, НСД({13},{17}) = {result['d']}." +
                $"\n   Множини усiх x: x = {result['x']}{(17 / result['d']).ToString("+0;-#")}k;\n" +
                $"   Множини усiх y: y = {result['y']}{((13 / result['d']) * (-1)).ToString("+0;-#")}k.\n");


            result = LinearDiophantineEquation(504, 726);
            Console.WriteLine($"7) ({504},{726}): x = {result['x']}, y = {result['y']}, НСД({504},{726}) = {result['d']}." +
                $"\n   Множини усiх x: x = {result['x']}{(726 / result['d']).ToString("+0;-#")}k;\n" +
                $"   Множини усiх y: y = {result['y']}{((404 / result['d']) * (-1)).ToString("+0;-#")}k.\n");

            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
