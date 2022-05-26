using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vector
    {
        int[] array;

        public int[] Array { get => array; set => array = value; }

        public int this[int index]
        {
            get 
            {
                if (index >= 0&&index<Array.Length)
                {
                    return Array[index];
                }
                else
                {
                    throw new IndexOutOfRangeException("Index out of range array.");
                }
            }
            set { Array[index] = value; }
        }
        public Vector(int n)
        {
            Array = new int[n];
        }
        public void InitRand(int a, int b)
        {
            Random random = new Random();
            for(int i = 0; i < Array.Length; i++)
            {
                Array[i] = random.Next(a,b);
            }
        }
        public void InitShuffle()
        {
            int r;
            Random rand = new Random();
            for (int i = 0; i < Array.Length; i++)
            {
                while (true)
                {
                    r = rand.Next(1, Array.Length + 1);
                    int index = System.Array.IndexOf(Array, r);
                    if (index == -1)
                    {
                        Array[i] = r;
                        break;
                    }
                }
            }
            //int r;
            //Random rand = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    while (true)
            //    {
            //        r = rand.Next(1, array.Length + 1);
            //        bool isExist = false;
            //        for (int j = 0; j < i; j++)
            //        {
            //            if (array[j] == r)
            //            {
            //                isExist = true;
            //                break;
            //            }
            //        }
            //        if (!isExist)
            //        {
            //            array[i] = r;
            //            break;
            //        }
            //    }
            //}
        }
        public Pair[] CalculateFreq()
        {
            Pair[] pairs = new Pair[Array.Length];
            for(int i = 0; i < Array.Length; i++)
            {
                pairs[i] = new Pair(0,0);
            }
            int countDifference = 0;
            for(int i=0; i < Array.Length; i++)
            {
                bool isElement = false;
                for(int j=0; j < countDifference; j++)
                {
                    if(Array[i] == pairs[j].Number)
                    {
                        pairs[j].Frequency++;
                        isElement = true;
                        break;
                    }
                }
                if (!isElement)
                {
                    pairs[countDifference].Frequency++;
                    pairs[countDifference].Number=Array[i];
                    countDifference++;
                }
            }
            Pair[] result = new Pair[countDifference];
            for(int i = 0;i < countDifference; i++)
            {
                result[i] = pairs[i];
            }
            return result;
        }
        public bool IsPalindrome()
        {
            for(int i = 0, j=Array.Length-1; i < Array.Length / 2; i++,j--)
            {
                if (Array[i] != Array[j])
                {
                    return false;
                }
            }
            return true;
        }
        public void ReverseArray()
        {
            int buffer;
            for (int i = 0, j = Array.Length - 1; i < Array.Length / 2; i++, j--)
            {
                buffer = Array[i];
                Array[i] = Array[j];
                Array[j] = buffer;
            }
        }
        public int[] LongestSequence()
        {
            int[] length;
            int[] start;
            int i = 0;
            while (i<array.Length)
            {

            }
            //Pair[] pairs = new Pair[Array.Length];
            //for (int i = 0; i < Array.Length; i++)
            //{
            //    pairs[i] = new Pair(0, 0);
            //}
            //for(int i =1,j=0;i< Array.Length; i++)
            //{
            //    if(array[i] == Array[i - 1])
            //    {
            //        pairs[j].Number = i-1;
            //        pairs[j].Frequency++;
            //    }
            //    else
            //    {
            //        j++;
            //    }
            //}
            //int max = 0;
            //int number=0;
            //for(int i=0; i<pairs.Length; i++)
            //{
            //    if(pairs[i].Frequency > max)
            //    {
            //        max = pairs[i].Frequency;
            //        number=pairs[i].Number;
            //    }
            //}
            //int[] result = new int [max];
            //for(int i = 0; i < max; i++)
            //{
            //    result[i] = pairs[number].Number;
            //}
            //return result;
            return new int[6];
        }
        public void BubbleSort()
        {
            for(int i = 0; i < array.Length-1; i++)
            {
                for(int j = 0; j < array.Length-i-1; j++)
                {
                    if (array[j+1]>array[j])
                    {
                        int item = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = item;
                    }
                }
                
            }
        }
        public void Counting()
        {
            int max = array[0];
            int min = array[0];
            for(int i=1; i<array.Length; i++)
            {
                if(array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            int[] temp = new int[max - min + 1];
            for(int i = 0; i < array.Length; i++)
            {
                temp[array[i]-min]++;
            }
            int k = 0;
            for(int i = 0;i< temp.Length; i++)
            {
                for(int j = 0; j < temp[i]; j++)
                {
                    array[k] =i+min;
                    k++;
                }
            }
        }
        public void QuickSortCentral(int first,int last)
        {
            int middle = array[(first+last)/2];
            int i = first;
            int j = last;
            do
            {
                while (array[j] > middle)
                {
                    j--;
                }
                while (array[i] < middle)
                {
                    i++;
                }
                if (i <= j)
                {
                    int buffer = Array[i];
                    Array[i] = Array[j];
                    Array[j] = buffer;
                    i++;
                    j--;
                }
            } while (i <= j);
            if (j > first)
            {
                QuickSortCentral(first, j);
            }
            if (i < last)
            {
                QuickSortCentral(i,last);
            }
        }
        public override string ToString()
        {
            string line = "";
            for(int i=0; i < Array.Length; i++)
            {
                line += Array[i]+" ";
            }
            return line;
        }
    }
}