using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExFuncs
{
    public class From1To5
    {//Ex1, Ex2 - Funcs for exs
        public static double Ex1FindY(double x)
        {
            return Math.Pow(Math.Sin(x), 2) + Math.Exp(Math.Pow(Math.Abs(Math.Pow(x, 2) + 1), 5)) - Math.Log(Math.Pow(x, 2) + 1);
        }
        public static double Ex2FindY(double x)
        {
            return Math.Sin(Math.Pow(x, 2)) / (Math.Cos(Math.Pow(x, 2)) + 5) + Math.Pow(Math.Log(x - 2) / (Math.Sin(Math.Pow(x, 2)) + Math.Pow(x, 2) + 1), 1 / 3);
        }/// <summary>
        /// Находит сумму X со степенями x^2^n всевозможных значений, где степень n - maxval for 1 to n
        /// </summary>
        /// <param name="x"></param>
        /// <param name="n"></param>
        /// <returns>Сумма S</returns>
        public static double Ex3FindS(double x, int n)
        {
            if (n <= 0) return 0;
            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += Math.Pow(x, Math.Pow(2, i));
            }
            return sum;
        }/// <summary>
        /// Создает массив, значения которого ai+j(i)
        /// </summary>
        /// <param name="masA"></param>
        /// <returns>masB - созданный массив значений</returns>
        public static int[] Ex4CreateMas(int[] masA)
        {
            if (masA == null) return null;
            int[] masB = new int[masA.Length];            
            for (int i = 0; i < masA.Length; i++)
            {   
                masB[i] = masA[i] + i;                
            }            
            return masB;
        }/// <summary>
        /// Происходит заполнение матрицы относительно установленного значения, которое является размером
        /// </summary>
        /// <param name="n"></param>
        /// <returns>matrix - полученный двумерный массив, представляющий собой матрицу</returns>
        public static int[,] GetMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                matrix[i, i] = i * (i + 1);
            }
            return matrix;
        }
    }
}
