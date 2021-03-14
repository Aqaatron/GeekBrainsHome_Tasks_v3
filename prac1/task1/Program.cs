using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Program
    {
        public bool test_simle_num (int n)
        {
            int d = 0;
            int i = 2;
            bool result = false;
            while (i < n)
            {
                if (n % i == 0)
                {
                    d++;
                    result = false;
                    break;
                }  
                else
                    i++;
            }

            if (d == 0)
            {
                result = true;
            }

            return result;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Program program = new Program();

            bool result  = program.test_simle_num(n);

            if (result)
                Console.WriteLine("Введённое число простое!");
            else
                Console.WriteLine("Введённое число не простое!");

            Console.ReadLine();
        }
    }
}
