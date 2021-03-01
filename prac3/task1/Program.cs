using System;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace task1
{
    public struct PointStruct
    {
        public int X;
        public int Y;
    }

    public class PointClass
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            for (int i = 0; i < BechmarkClass.array_of_x_cord_point1.Length; i++)
            {
                BechmarkClass.array_of_x_cord_point1[i] = random.Next(0, 100);

                BechmarkClass.array_of_x_cord_point1[i] = random.Next(0, 100);

                BechmarkClass.array_of_x_cord_point2[i] = random.Next(0, 100);

                BechmarkClass.array_of_x_cord_point2[i] = random.Next(0, 100);


            }

            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);


        }
    }
    public class BechmarkClass
    {
        public static int[] array_of_x_cord_point1 = new int[1000];

        public static int[] array_of_y_cord_point1 = new int[1000];

        public static int[] array_of_x_cord_point2 = new int[1000];

        public static int[] array_of_y_cord_point2 = new int[1000];


        public static float PointDistanceValueTypeFloat (PointStruct pointOne, PointStruct pointTwo)
        {
            float x = pointOne.X - pointTwo.X;

            float y = pointOne.Y - pointTwo.Y;

            return MathF.Sqrt((x * x) + (y * y));
        }

        public static float PointDistanceRefTypeFloat (PointClass pointOne, PointClass pointTwo)
        {
            float x = pointOne.X - pointTwo.X;

            float y = pointOne.Y - pointTwo.Y;

            return MathF.Sqrt((x * x) + (y * y));
        }

        public static double PointDistanceValueTypeDouble (PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;

            double y = pointOne.Y - pointTwo.Y;

            return Math.Sqrt((x * x) + (y * y));

        }

        public static double PointDistanceValueTypeDoubleSimple (PointStruct pointOne, PointStruct pointTwo)
        {
            double x = pointOne.X - pointTwo.X;

            double y = pointOne.Y - pointTwo.Y;

            return (x * x) + (y * y);

        }



        [Benchmark]
        public void TestPointDistanceRefTypeFloat()
        {
            PointClass point1 = new PointClass();

            PointClass point2 = new PointClass();

            for (int i = 0; i < BechmarkClass.array_of_x_cord_point1.Length; i++)

            {
                point1.X = array_of_x_cord_point1[i];

                point1.Y = array_of_y_cord_point1[i];

                point2.X = array_of_x_cord_point2[i];

                point2.Y = array_of_y_cord_point2[i];


                PointDistanceRefTypeFloat(point1, point2);

            }
        }

        [Benchmark]
        public void TestPointDistanceValueTypeFloat()
        {
            PointStruct point1 = new PointStruct();

            PointStruct point2 = new PointStruct();

            for (int i = 0; i < BechmarkClass.array_of_x_cord_point1.Length; i++)

            {
                point1.X = array_of_x_cord_point1[i];

                point1.Y = array_of_y_cord_point1[i];

                point2.X = array_of_x_cord_point2[i];

                point2.Y = array_of_y_cord_point2[i];


                PointDistanceValueTypeFloat(point1, point2);

            }
        }

        [Benchmark]
        public void TestPointDistanceValueTypeDouble ()
        {
            PointStruct point1 = new PointStruct();

            PointStruct point2 = new PointStruct();

            for (int i = 0; i < BechmarkClass.array_of_x_cord_point1.Length; i++)

            {
                point1.X = array_of_x_cord_point1[i];

                point1.Y = array_of_y_cord_point1[i];

                point2.X = array_of_x_cord_point2[i];

                point2.Y = array_of_y_cord_point2[i];


                PointDistanceValueTypeDouble(point1, point2);

            }
        }


        [Benchmark]
        public void TestPointDistanceValueTypeDoubleSimple()
        {
            PointStruct point1 = new PointStruct();

            PointStruct point2 = new PointStruct();

            for (int i = 0; i < BechmarkClass.array_of_x_cord_point1.Length; i++)

            {
                point1.X = array_of_x_cord_point1[i];

                point1.Y = array_of_y_cord_point1[i];

                point2.X = array_of_x_cord_point2[i];

                point2.Y = array_of_y_cord_point2[i];


                PointDistanceValueTypeDoubleSimple(point1, point2);

            }
        }
    }

}
