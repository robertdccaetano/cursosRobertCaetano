using System;
using System.Collections.Generic;
using System.IO;

namespace secao15Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the file full path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader sr = File.OpenText(filePath))
                {
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();

                    while (!sr.EndOfStream)
                    {

                        string[] votingRecord = sr.ReadLine().Split(',');
                        string candidate = votingRecord[0];
                        int votes = int.Parse(votingRecord[1]);


                        if (dictionary.ContainsKey(candidate))
                        {
                            dictionary[candidate] += votes;
                        }
                        else
                        {
                            dictionary[candidate] = votes;
                        }
                    }
                    foreach (KeyValuePair<string, int> item in dictionary)
                    {
                        Console.WriteLine(item.Key + ": " + item.Value);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error ocurred");
                Console.Write(ex.Message);
                
            }
        }
    }
}
