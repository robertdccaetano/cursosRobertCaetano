using secao13Ex01.Entities;
using System;
using System.Globalization;
using System.IO;

namespace secao13Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file full path: ");
            string fileFullPath = Console.ReadLine();

            try
            {
                string[] lines = File.ReadAllLines(fileFullPath);

                string sourceFolderPath = Path.GetDirectoryName(fileFullPath);
                string targetFolderPath = sourceFolderPath + @"\out";
                string targetFilePath = targetFolderPath + @"\summary.csv";

                Directory.CreateDirectory(targetFolderPath);

                using (StreamWriter sw = File.AppendText(targetFilePath))
                {
                    foreach (string line in lines)
                    {
                        string[] fields = line.Split(',');
                        string name = fields[0];
                        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                        int quantity = int.Parse(fields[2]);

                        Products product = new Products(name, price, quantity);

                        sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));

                    }
                }

            } 
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.WriteLine(ex.Message);
            }
           
        }
    }
}
