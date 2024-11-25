using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.SavtsovNE.Sprint5.Task5.V24.Lib
{
    public class DataService : ISprint5Task5V24
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Проверяем на null или пустую строку
                        if (string.IsNullOrWhiteSpace(line))
                        {
                            continue; // Пропускаем пустые строки
                        }

                        // Заменяем точку на запятую для корректного парсинга в некоторых локалях
                        line = line.Replace('.', ',');

                        if (double.TryParse(line, out double n)) // Используем TryParse
                        {
                            if (n >= -99 && n <= 99)
                            {
                                res += n;
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Не удалось разобрать строку: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
            }

            return Math.Round(res, 3);
        }
    }
}