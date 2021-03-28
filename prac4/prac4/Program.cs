using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;

namespace task1
{
    class Program
    {
        static void Main(string[] args)

        {

            var bench = new BenchmarkClass();

           



            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);






        }
    }
    public class BenchmarkClass
    {
        public  static string[] test_array  = new string[10000];

        public static HashSet<string> hashSet = new HashSet<string>();

        public BenchmarkClass()
        {
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            var random = new Random();

            for(int i = 0; i < test_array.Length; i++)
            {

                test_array[i] = letters[random.Next(0, letters.Length - 1)].ToString() + letters[random.Next(0, letters.Length - 1)].ToString() + letters[random.Next(0, letters.Length - 1)].ToString();

                hashSet.Add(test_array[i]);

            }
        }

        public static bool find_item_by_HashSet(string search_string)
        {
            

            return hashSet.Contains(search_string);
        }


        public static bool find_item_by_Mas(string search_string)
        {
           

            for (int i = 0; i < test_array.Length; i++)
            {
                if (test_array[i] == search_string)
                
                    return true;   
            }

            return false;

        }

        [Benchmark]

        public void Test_find_item_by_HashSet()
        {
            string search_string = test_array[100];

            bool result = find_item_by_HashSet(search_string);

        }


        [Benchmark]
        public void Test_find_item_by_Mas()
        {
            string search_string = test_array[100];

            bool result = find_item_by_Mas(search_string);

        }
    }
}
