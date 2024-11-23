using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = @"C:\Users\Admin\source\repos\Tyuiu.SavtsovNE.Sprint5\Tyuiu.SavtsovNE.Sprint5.Task2.V4.Lib";
            string ans = "";
            File.Delete(filePath);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    if (j == 2 && i != 2)
                    {
                        ans += $"{matrix[i, j]}\n";
                    }
                    else if (i == 2 && j == 2)
                    {
                        ans += $"{matrix[i, j]}";
                    }
                    else
                    {
                        ans += $"{matrix[i, j]};";
                    }
                }
            }
            try { File.WriteAllText(filePath, ans); } catch (Exception ex) { }
            return ans;
        }
    }
}