using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavtsovNE.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Pow(x - 1, 3 * x + 1);
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            File.WriteAllText(path, Convert.ToString(y));
            return path;
        }
    }
}