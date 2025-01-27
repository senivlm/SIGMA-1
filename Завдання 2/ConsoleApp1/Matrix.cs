﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Matrix
    {
        public static int[,] vertical()
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв матрицi");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпцiв матрицi");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[n,m];
            for(int column = 0,elem=0; column < m; column++)
            {
                for (int row = 0; row < n; row++)
                {
                    if (column % 2 == 0)
                    {
                        matr[row, column] = ++elem;
                    }
                    else
                    {
                        if (row == 0)
                        {
                            elem = elem + n;
                        }
                        matr[row, column] = elem--;
                        if (row == n - 1)
                        {
                            elem=elem+n;
                        }
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return matr;
        }
        public static int[,] diagonal()
        {
            Console.WriteLine("Введiть розмiрнiсть квадратоної матрицi");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[n, n];
            int number=0;
            for(int line =0; line < n; line++)
            {
                if(line % 2 == 0)
                {
                    int i1 = line;
                    int j1 = 0;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matr[i1, j1] =++number;
                        i1--;
                        j1++;
                    }
                }
                else
                {
                    int i1 = 0;
                    int j1 = line;
                    for (int i = 0; i < line + 1; i++)
                    {
                        matr[i1, j1] = ++number;
                        i1++;
                        j1--;
                    }
                }
            }
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return matr;
        }
        public static int[,] spiral()
        {
            Console.WriteLine("Введiть кiлькiсть рядкiв матрицi");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введiть кiлькiсть стовпцiв матрицi");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] matr = new int[n, m];
            return matr;
        }
    }
}
