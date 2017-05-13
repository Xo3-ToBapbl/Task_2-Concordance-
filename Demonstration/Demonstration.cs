using ConcordanceLibrary.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;


namespace ConcordanceDemonstration
{
    class Demonstration
    {
        static void Print(Concordance concordance)
        {
            Console.WriteLine("Concordance:");
            foreach (char mainLetter in concordance.Items.Keys)
            {
                if (concordance[mainLetter].Values.Count != 0)
                {
                    Console.WriteLine(mainLetter);
                    foreach (var items in concordance[mainLetter])
                    {
                        Console.WriteLine("{0}..........{1}: {2}",
                            items.Key, items.Value.Count, items.Value.PageNumbersToString());
                    }
                }   
            }
        }

        static void Main(string[] args)
        {
            string textFilePath = ConfigurationManager.AppSettings["TextFilePath"];
            string alhabetFilePath = ConfigurationManager.AppSettings["AlphabetFilePath"];

            ConcordanceCreater concordanceCreater = new ConcordanceCreater(alhabetFilePath);
            //int N - count of string in one page
            Concordance concordance = concordanceCreater.CreateConrcondance(textFilePath, 5);
            concordance.SaveToFile();

            Print(concordance);
            Console.ReadKey();
        }
    }
}
