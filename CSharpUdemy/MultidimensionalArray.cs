using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpUdemy
{
    public class MultidimensionalArray
    {

        public static void MainDiagonal(int x, int[,] matriz)
        {
            Console.Write("Main diagonal: ");
            int diagonal = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (j == diagonal)
                    {
                        Console.Write(matriz[i, j] + " ");
                    }
                }
                diagonal++;
            }
        }

        public static void NegativeNumbers(int x, int[,] matriz)
        {
            int negative = 0;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    if (matriz[i, j] < 0)
                    {
                        negative++;
                    }
                }
            }
            Console.Write($"Negative Numbers = {negative}");
        }

        public static void FindNumbers(int x, int y, int[,] matriz)
        {
            int op = int.Parse(Console.ReadLine());
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (matriz[i, j] == op)
                    {
                        //left right up down
                        /* 3 4 
                         * 10 8 15 12
                         * 21 11 23 8
                         * 14 5 13 19
                         */
                        Console.WriteLine($"Position {i}, {j}");
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine($"Left: {matriz[i, j - 1]}");
                        }
                        if (j + 1 <= x)
                        {
                            Console.WriteLine($"Right: {matriz[i, j + 1]}");
                        }
                        if(i - 1 >= 0)
                        {
                            Console.WriteLine($"Up: {matriz[i - 1, j]}");
                        }
                        if(i + 1 <= x)
                        {
                            Console.WriteLine($"Down: {matriz[i + 1, j]}");
                        }
                    }
                }
            }
        }
    }
}
