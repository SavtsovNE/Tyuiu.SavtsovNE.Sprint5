using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavtsovNE.Sprint5.Task5.V21.Lib
{
    public class DataService : ISprint5Task5V21
    {
        public double[] ReadValuesFromFile(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines( filePath);
                return lines.Select(line => double.Parse(line)).ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при чтении файла: {ex.Message}");
                return Array.Empty<double>();
            }
        }

        public int FindLargestEvenNumber(double[] values)
        {
            return values.Where(v => v % 2 == 0).Select(v => (int)v).DefaultIfEmpty(-1).Max();
        }

        public long Factorial(int number)
        {
            if (number < 0) throw new ArgumentOutOfRangeException("number", "Факториал не определен для отрицательных чисел.");
            long result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }
            return result;
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}
