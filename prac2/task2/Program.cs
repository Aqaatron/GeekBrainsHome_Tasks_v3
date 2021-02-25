using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    public class Program
    {
        public int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;

            int max = inputArray.Length - 1;

            while (min <= max)
            {
                int mid = (min + max) / 2;

                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Program program = new Program();

            Random rand = new Random();

            int[] random_array = new int[25];

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < random_array.Length; i++)
            {
                random_array[i] = rand.Next(0, 100);
                Console.Write(random_array[i] + " ");
            }

            random_array = random_array.OrderBy(x => x).ToArray();

            Console.WriteLine();

            for (int i = 0; i < random_array.Length; i++)
            {
                Console.Write(random_array[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Введите значение элемента, индекс которого вы хотите найти: ");



            int searchValue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Индекс искомого элемента:" + program.BinarySearch(random_array, searchValue)); 

            Console.ReadLine();
        }
    }
}
