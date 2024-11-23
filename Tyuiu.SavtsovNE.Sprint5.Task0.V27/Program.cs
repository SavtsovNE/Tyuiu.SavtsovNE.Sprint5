using Tyuiu.SavtsovNE.Sprint5.Task0.V27.Lib;

namespace Tyuiu.SavtsovNE.Sprint5.Task0.V27
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #5 | Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1";
            //Длинна строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Класс File. Запись данных в текстовый файл                              *");
            Console.WriteLine("* Задание #0                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");

            Console.WriteLine("*Дано выражение вычислить его значение при x = 3, результат сохранить в те*");
            Console.WriteLine("*екстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить до трёх*");
            Console.WriteLine("*х знаков после запятой.                                                  *");

            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine();
            Console.WriteLine("x = 3");
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            DataService ds = new DataService();

            var result = ds.SaveToFileTextData(3);
            Console.WriteLine($"Файл: {result}");
            Console.ReadKey();
        }
    }
}