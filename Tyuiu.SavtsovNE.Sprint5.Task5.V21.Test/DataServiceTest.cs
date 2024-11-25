using Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib;

public class DataService
{
    public double DoubleFactorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(" Negative numbers are not supported.");
        }

        if (number == 0 || number == 1)
        {
            return 1;
        }

        return number * DoubleFactorial(number - 2);


    }
}

