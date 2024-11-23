using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib;

namespace Tyuiu.SavtsovNE.Sprint5.Task2.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #5 | Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1";
            Console.WriteLine("******************************************************************** *******");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Класс File. Запись структурированных данных в текстовый файл      *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #4                                                              *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить положительные элементы массива на 1,  *");
            Console.WriteLine("* отрицательные на 0.                                                     *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            int[,] mtrx = new int[3, 3];
            int rows = mtrx.GetUpperBound(0) + 1;
            int columns = mtrx.GetUpperBound(1) + 1;
            Console.WriteLine($"Дана матрица 3х3. Введите элементы матрицы: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i}, {j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }
            Console.WriteLine("Массив: ");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}