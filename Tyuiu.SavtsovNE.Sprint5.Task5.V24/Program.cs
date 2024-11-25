using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.SavtsovNE.Sprint5.Task5.V24.Lib;
using System.IO;

namespace Tyuiu.SavtsovNE.Sprint5.Task5.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #5 | Выполнил: Молодых В. Ю. | ИИПБ-23-3";
            //Длина строки 75 символов
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* Спринт #5                                                                            *");
            Console.WriteLine("* Тема: Обработка файлов                                                               *");
            Console.WriteLine("* Задание #5                                                                           *");
            Console.WriteLine("* Вариант #24                                                                          *");
            Console.WriteLine("* Выполнил: Молодых Владислав Юрьевич | ИИПБ-23-3                                      *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                             *");
            Console.WriteLine("* Дан файл С:DataSprint5InPutDataFileTask4V0.txt (файл взять из архива                 *");
            Console.WriteLine("* согласно вашему варианту. Создать папку в ручную С:DataSprint5 и скопировать         *");
            Console.WriteLine("* в неё файл) в котором есть набор значений.                                           *");
            Console.WriteLine("* Найти сумму всех двузначных целых чисел в файле.  Полученный результат вывести       *");
            Console.WriteLine("* на консоль. У вещественных значений округлить до трёх знаков после запятой.          *");
            Console.WriteLine("* до трёх знаков после запятой) и вернуть полученный результат на консоль.             *");
            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                     *");
            Console.WriteLine("****************************************************************************************");

            string path = @"C:\DataSprint5\InPutDataFileTask5V24.txt";

            Console.WriteLine("****************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                           *");
            Console.WriteLine("****************************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine(res);


            Console.ReadLine();
        }
    }
}