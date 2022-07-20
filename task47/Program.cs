using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

            void Zadacha47()
            {
                /* Задача 47. Задайте двумерный массив размером m*n, запаолненный случайными вещественными чилами, округлёнными до одного знака.
                m = 3, n = 4
                */
                Random random = new Random();
                int rows = random.Next(2,6);
                int colums = random.Next(4,9);

                double[,] array = new double[rows, colums];
                FillArray(array);
                PrintArray(array);

            }

            void Zadacha50()
            {
                /* Напишите программу, которая на вход принимает позиции элемена в двумерном массиве, и 
                возвращает значение этого элемента или же указание, что такого элемента нет*/
                Random random = new Random();
                int rows = random.Next(2,6);
                int colums = random.Next(4,9);

                int[,] array = new int[rows, colums];
                FillArray(array);
                PrintArray(array);
                
                Console.WriteLine("Введите строку искомого элемента: ");
                int row = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите столбец искомого элемента: ");
                int colum = Convert.ToInt32(Console.ReadLine());
                if (row >= 1 && row <= rows && colum >=1 && colum <=colums)
                {
                    Console.WriteLine($"Искомый элемент array[{row-1},{colum-1}] = {array[row -1, colum - 1]}");
                }
                else
                {
                    Console.WriteLine("Искомый элемент не найден");
                }
                    
            }

            void Zadacha52()
            {
                /* Задайте двумерный массив из целых чисел. 
                Найдите среднее арифметическое элементов в каждом столбце */
                Random random = new Random();
                int rows = random.Next(2,6);
                int colums = random.Next(4,9);

                int[,] array = new int[rows, colums];
                FillArray(array);
                PrintArray(array);
                Console.WriteLine("Среднее арифметическое стоблца: "); 
                for(int j = 0; j < colums; j++)
                {
                    double sum = 0;
                    for(int i = 0; i < rows; i++)
                    {
                        sum += array[i,j];
                    }
                    double average = sum/rows;
                    Console.Write(average + "\t");
                }
                Console.WriteLine(); 
            }
            Zadacha52();
            //Zadacha50();
            //Zadacha47();
        }

        static void FillArray(double[,] array)
        {
            Random random = new Random();
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    array[i, j]=Math.Round(random.NextDouble() * 10 - 5,2);
                }
            }
        }

        static void PrintArray(double[,] array)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод массива: ");
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void FillArray(int[,] array)
        {
            Random random = new Random();
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    array[i, j]=random.Next(0,100);
                }
            }
        }
        static void PrintArray(int[,] array)
        {
            Console.WriteLine();
            Console.WriteLine("Вывод массива: ");
            int rows = array.GetLength(0);
            int colums = array.GetLength(1);
            for(int i = 0; i < rows; i++)
            {
                for(int j = 0; j < colums; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}