using System;
using System.IO;
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavtsovNE.Sprint5.Task5.V21.Lib 
{
    public class DataService : ISprint5Task5V21
    {
        public int Factorial(int number)
        {
            if (number < 0) throw new ArgumentException("Number must be non-negative.");
            return number == 0 ? 1 : number * Factorial(number - 1);
        }

        public int? FindMaxEven(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            var numbers = lines.Select(line =>
            {
                if (double.TryParse(line, out double num))
                    return (int?)num;
                return null;
            }).Where(num => num.HasValue && num.Value % 2 == 0).Select(num => num.Value);

            return numbers.Any() ? (int?)numbers.Max() : null;
        }

        public double LoadFromDataFile(string path)
        {
            throw new NotImplementedException();
        }
    }
}