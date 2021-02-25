using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    public class Program
    {
            public int Fibonachi_rec (int n)
            {
                if (n == 0)

                    return 0;

                if (n == 1)

                    return 1;

                return Fibonachi_rec(n - 1) + Fibonachi_rec(n - 2);
            }
            public int Fibonachi(int n)
            {

                int[] fibonachi = new int[n + 1];

                fibonachi[0] = 0;

                fibonachi[1] = 1;

            for (int i = 2; i < fibonachi.Length; i++)
            {
                fibonachi[i] = fibonachi[i - 1] + fibonachi[i - 2];
            }

            return fibonachi[n];
            }

        static void Main(string[] args)
            {

                Console.Write("Введите число n: ");


                int n = Convert.ToInt16(Console.ReadLine());

                Program program = new Program();

                Console.WriteLine($"Число Фибоначи рекурсией под номером n = {program.Fibonachi_rec(n)}");

                Console.WriteLine($"Число Фибоначи циклами под номером n = {program.Fibonachi(n)}");

                Console.ReadLine();
            }
        }
    }
