using System.IO;
using System.Text;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.SavtsovNE.Sprint5.Task7.V5.Lib
{
    public class DataService : ISprint5Task7V5
    {
        public string LoadDataAndSave(string path)
        {
            StringBuilder strLine = new StringBuilder();

            try
            {
                using (StreamReader reader = new StreamReader(path))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        for (int i = 0; i < line.Length; i++)
                        {
                            // Проверка символов на кириллицу, а также на специальные символы
                            if ((line[i] >= 'А' && line[i] <= 'я') || line[i] == '!' || line[i] == '.' || line[i] == ',' || line[i] == ' ')
                            {
                                strLine.Append(line[i]);
                            }
                        }
                    }
                }
            }
            catch (IOException ex)
            {

                throw new Exception("Ошибка при чтении файла.", ex);
            }

            return strLine.ToString().Trim('!');
        }
    }
}
