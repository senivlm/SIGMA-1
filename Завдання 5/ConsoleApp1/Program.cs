using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vector arr1 = new Vector(10);
            arr1.InitRand(1,15);
            Console.WriteLine(arr1);
            arr1.HeapSort();
            Console.WriteLine(arr1);
            //arr1.BubbleSort();
            //
            //arr1[0] = 1;
            //arr1[1] = 1;
            //arr1[2] = 3;
            //arr1[3] = 3;
            //arr1[4] = 4;
            //arr1[5] = 4;
            //Console.WriteLine(arr1);
            //Console.WriteLine("Палiндром: "+arr1.IsPalindrome());
            //arr1.ReverseArray();
            //Console.WriteLine(arr1);
            //Array.Reverse(arr1.Array);
            //Console.WriteLine(arr1);
            //arr1.InitRand(5, 11);
            //int[] sub = arr1.LongestSequence();
            //for (int i = 0; i < sub.Length; i++)
            //{
            //    Console.Write(sub[i] + " ");
            //}

            //arr1.InitRand(1, 5);
            //Pair[] pairs = arr1.CalculateFreq();
            ////arr1.InitShuffle();
            //arr1[0] = 99;
            //for(int i = 0; i < pairs.Length; i++)
            //{
            //    Console.WriteLine(pairs[i]);
            //}
            //try
            //{
            //    Console.WriteLine(arr1[12]);
            //}
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            //Pair p1 = new Pair(1, 2);
            //Pair p2 = new Pair(1, 2);
            //Console.WriteLine(p1.Equals(p2));
            //Console.WriteLine(p1 == p2);
            //Console.WriteLine(ReferenceEquals(p1, p2));
        }
    }
}
