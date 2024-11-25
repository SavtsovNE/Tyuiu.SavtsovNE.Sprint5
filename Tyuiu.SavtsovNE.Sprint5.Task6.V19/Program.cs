using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Tyuiu.SavtsovNE.Sprint5.Task6.V19.Lib;

namespace Tyuiu.SavtsovNE.Sprint5.Task6.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил : Савцов Никита Евгеньевич | ИБКСБ-24-1";
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* Спринт #5                                                                    *");
            Console.WriteLine("* Обработка файлов                                                             *");
            Console.WriteLine("* Задание #6                                                                   *");
            Console.WriteLine("* Вариант #19                                                                  *");
            Console.WriteLine("* Выполнил : Савцов Никита Евгеньевич | ИБКСБ-24-1                            *");
            Console.WriteLine("********************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                     *");
            Console.WriteLine("* Найти количество двузначных чисел в заданной строке.                         *");

            Console.WriteLine("********************************************************************************");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask6V19.txt";
            Console.WriteLine("Данные находятся в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                         *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine("Сумма двузначных элементов файла = " + res);
            Console.ReadKey();
        }
    }
}