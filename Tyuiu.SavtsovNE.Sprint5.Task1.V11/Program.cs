using System.IO;
using Tyuiu.SavtsovNE.Sprint5.Task1.V11.Lib;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new();
        int startValue = -5;
        int stopValue = 5;
        Console.Title = "Спринт #5 | Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #11                                                             *");
        Console.WriteLine("* Выполнил: Савцов Никита Евгеньевич | ИБКСБ - 24 -1                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция. (произвести табулирование) f(x) на заданном диапазоне     *");
        Console.WriteLine("* [-5;5] с шагом 1. Произвести проверку деления на ноль.                  *");
        Console.WriteLine("* При делении на ноль вернуть значение 0. Результат сохранить в           *");
        Console.WriteLine("* текстовый файл OutPutFileTask1.txt и вывести на консоль в таблицу.      *");
        Console.WriteLine("* Значения округлить до двух знаков после запятой.                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Начало: " + startValue);
        Console.WriteLine("Конец: " + stopValue);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        string res = ds.SaveToFileTextData(startValue, stopValue);
        Console.WriteLine("Файл: " + res);
        Console.WriteLine("Создан");
        Console.ReadLine();
    }
}