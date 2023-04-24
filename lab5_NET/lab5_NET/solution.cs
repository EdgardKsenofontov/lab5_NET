using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_NET
{
    internal class solution
    {
        public void Task1()
        {
            int sum = 0;
            string textLine = Console.ReadLine();

            foreach (var word in textLine.Split())
            {
                sum++;

                if (sum % 2 == 0) { 
                    Console.Write(word.Reverse().ToArray()) ;
                    Console.Write(' ');
                }
                else { Console.Write(word + " "); }
           
            }
            Console.ReadKey();
           
        }
        public void Task2()
        {
            Random random = new Random();
            int r = random.Next(2, 11);
            int[,] Matrix = new int[r, r];
            int[] sums = new int[r];
            for (int i = 0; i < r; i++)
            {
                sums[i] = 0;
            }
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    sums[i] += Matrix[i, j];
                    Console.Write(Matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < r; i++)
            {
                int j = i + 1;
                Console.WriteLine("Сумма " + j + "-го ряда: " + sums[i]);
            }


            Console.ReadKey();
        }
        public void Task3()
        {
            char[] alf = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k' };
            Random rand = new Random();
            Console.WriteLine("введите размерность матрицы:");
            int dim = Convert.ToInt32(Console.ReadLine());
            char[,] matrix = new char[dim, dim];
            Console.WriteLine("матрица:");
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    matrix[i, j] = alf[rand.Next(0, 11)];
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("новая матрица с заменой 'a' на 'e':");
            char[,] newMatrix = new char[dim, dim];
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    newMatrix[i, j] = matrix[i, j] == 'a' ? 'e' : matrix[i, j];
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("транспонированная новая матрица:");
            for (int i = 0; i < dim; i++)
            {
                for (int j = 0; j < dim; j++)
                {
                    char temp = newMatrix[i, j];
                    newMatrix[i, j] = newMatrix[j, i];
                    newMatrix[j, i] = temp;
                    Console.Write(newMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
