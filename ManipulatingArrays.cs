using System;

namespace Arrays
{
    public class ManipulatingArrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Arrays.ManipulatingArrays.Main()");
            Console.WriteLine("\nArrayA: { 0, 2, 4, 6, 8, 10 }");
            Console.WriteLine($"ArrayA has {CountArrayA()} elements.");
            Console.WriteLine($"The sum of numbers in ArrayA is {AddArrayA()}.");
            Console.WriteLine($"The average of ArrayA is {AverageArrayA()}.");
            Console.WriteLine($"The reverse of ArrayA is {ReverseArrayA()}.");
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            LeftRotateArrayA(ArrayA, ArrayA.Length, 2);
            PrintRotatedArrayA(ArrayA, ArrayA.Length);
            Console.WriteLine("\n\nArrayB: { 1, 3, 5, 7, 9 }");
            Console.WriteLine($"nArrayB has {CountArrayB()} elements.");
            Console.WriteLine($"The sum of numbers in ArrayB is {AddArrayB()}.");
            Console.WriteLine($"The average of ArrayB is {AverageArrayB()}.");
            Console.WriteLine($"The reverse of ArrayB is {ReverseArrayB()}.");
            int[] ArrayB = new int[] { 1, 3, 5, 7, 9 };
            LeftRotateArrayB(ArrayB, ArrayB.Length, 2);
            PrintRotatedArrayB(ArrayB, ArrayB.Length);
            Console.WriteLine("\n\nArrayC: { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 }");
            Console.WriteLine($"ArrayC has {CountArrayC()} elements.");
            Console.WriteLine($"The sum of numbers in ArrayC is {AddArrayC()}.");
            Console.WriteLine($"The average of ArrayC is {AverageArrayC()}.");
            Console.WriteLine($"The reverse of ArrayC is {ReverseArrayC()}.");
            int [] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            LeftRotateArrayC(ArrayC, ArrayC.Length, 4);
            PrintRotatedArrayC(ArrayC, ArrayC.Length);
            Console.WriteLine($"\nArrayC sorted is {SortArrayC()}.");
            Console.ReadLine();
        }
        public static int CountArrayA()
        {
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int Count = ArrayA.Length;
            return Count;
        }
        public static int AddArrayA()
        {
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int Sum = 0;
            for (int i = 0; i < ArrayA.Length; i++)
            {
                Sum += ArrayA[i];
            }
            return Sum;
        }
        public static double AverageArrayA()
        {
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            int Sum = 0;

            for (int i = 0; i < ArrayA.Length; i++)
            {
                Sum += ArrayA[i];
            }
            double Average = Sum / ArrayA.Length;
            return Average;
        }
        public static string ReverseArrayA()
        {
            int[] ArrayA = new int[] { 0, 2, 4, 6, 8, 10 };
            Array.Reverse(ArrayA);
            return string.Join(", ", ArrayA);
        }
        private static void LeftRotateArrayA(int[] ArrayA, int ArrayLength, int NumOfSpaces)
        {
            for (int i = 0; i < NumOfSpaces; i++)
            {
                int temp = ArrayA[0];
                Array.Copy(ArrayA, 1, ArrayA, 0, ArrayLength - 1);
                ArrayA[ArrayLength - 1] = temp;
            }
        }
        private static void PrintRotatedArrayA(int[] ArrayA, int ArrayLength)
        {
            for (int i = 0; i < ArrayLength; i++)
            {
                Console.Write(ArrayA[i] + " ");
            }
        }
        public static int CountArrayB()
        {
            int[] ArrayB = new int[] { 1, 3, 5, 7, 9 };
            int Count = ArrayB.Length;
            return Count;
        }
        public static int AddArrayB()
        {
            int[] ArrayB = new int[] { 1, 3, 5, 7, 9 };
            int Sum = 0;
            for (int i = 0; i < ArrayB.Length; i++)
            {
                Sum += ArrayB[i];
            }
            return Sum;
        }
        public static double AverageArrayB()
        {
            double Average = (AddArrayB() / CountArrayB());
            return Average;
        }
        public static string ReverseArrayB()
        {
            int[] ArrayB = new int[] { 1, 3, 5, 7, 9 };
            Array.Reverse(ArrayB);
            return string.Join(", ", ArrayB);
        }
        private static void LeftRotateArrayB(int[] ArrayB, int ArrayLength, int NumOfSpaces)
        {
            for (int i = 0; i < NumOfSpaces; i++)
            {
                int temp = ArrayB[0];
                Array.Copy(ArrayB, 1, ArrayB, 0, ArrayLength - 1);
                ArrayB[ArrayLength - 1] = temp;
            }
        }
        private static void PrintRotatedArrayB(int[] ArrayB, int NumOfSpaces)
        {
            for (int i = 0; i < NumOfSpaces; i++)
            {
                Console.Write(ArrayB[i] + " ");
            }
        }
        public static int CountArrayC()
        {
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int Count = ArrayC.Length;
            return Count;
        }
        public static double AddArrayC()
        {
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int Sum = 0;
            for (int i = 0; i < ArrayC.Length; i++)
            {
                Sum += ArrayC[i];
            }
            return Sum;
        }
        public static double AverageArrayC()
        {
            double Average = (AddArrayC() / CountArrayC());
            return Average;
        }
        public static string ReverseArrayC()
        {
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Array.Reverse(ArrayC);
            return string.Join(", ", ArrayC);
        }
        public static void RotateArrayC(int K)
        {
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            int[] NewArray = new int[ArrayC.Length];
            for (int i = 0; i < K; i++)
            {
                NewArray[i] = ArrayC[ArrayC.Length - K + i];
            }
            int j = 0;
            for (int i = K; i < ArrayC.Length; i++)
            {
                NewArray[i] = NewArray[j];
                j++;
            }
        }
        private static void LeftRotateArrayC(int[] ArrayC, int ArrayLength, int NumOfSpaces)
        {
            for (int i = 0; i < NumOfSpaces; i++)
            {
                int temp = ArrayC[0];
                Array.Copy(ArrayC, 1, ArrayC, 0, ArrayLength - 1);
                ArrayC[ArrayLength - 1] = temp;
            }
        }
        private static void PrintRotatedArrayC(int[] ArrayC, int NumOfSpaces)
        {
            for (int i = 0; i < NumOfSpaces; i++)
            {
                Console.Write(ArrayC[i] + " ");
            }
        }
        public static string SortArrayC()
        {
            int[] ArrayC = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            Array.Sort(ArrayC);
            return String.Join(", ", ArrayC);
        }
    }
}
