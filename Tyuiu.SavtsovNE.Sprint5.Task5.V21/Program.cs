using System;
using System.IO;
using Tyuiu.SavtsovNE.Sprint5.Task5.V21.Lib;

namespace Tyuiu.SavtsovNE.Sprint5.Task5.V21
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Спринт #5 | Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Чтение данных из текстового файла                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #21                                                             *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСб-24-1                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask5V21.txt (файл взять из архива согласно вашему варианту.        *");
            Console.WriteLine("* Создать папку в ручную С:\\DataSprint5\\ и скопировать в неё файл) в котором есть набор значений. Найти факториал наибольшего целого.            *");
            Console.WriteLine("*                                         *");
            Console.WriteLine("* числа, которое делится на 2, в файле. Полученный результат вывести на консоль. У вещественных значений округлить до трёх знаков после запятой.        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string filePath = Path.Combine(Path.GetTempPath(), "InPutDataFileTask5V21.txt");

            // Убедитесь, что файл существует
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Файл не найден: {filePath}");
                return;
            }

            DataService dataService = new DataService();
            int? maxEven = dataService.FindMaxEven(filePath);

            if (maxEven.HasValue)
            {
                int factorial = dataService.Factorial(maxEven.Value);
                Console.WriteLine($"Факториал наибольшего четного числа {maxEven.Value} равен {factorial}");
            }
            else
            {
                Console.WriteLine("Четные числа не найдены в файле.");
            }
        }
    }
}