using ConcordanceLibrary.Classes;
using System;
using System.Configuration;
using ConcordanceLibrary.Extensions;

namespace ConcordanceDemonstration
{
    class Demonstration
    {
        static void Main(string[] args)
        {
            string textFilePath = ConfigurationManager.AppSettings["TextFilePath"];
            string alhabetFilePath = ConfigurationManager.AppSettings["AlphabetFilePath"];

            ConcordanceCreater concordanceCreater = new ConcordanceCreater(alhabetFilePath);
            //int N - count of string in one page
            Concordance concordance = concordanceCreater.CreateConrcondance(textFilePath, 5);
            concordance.SaveToFile();
            concordance.Print();

            Console.ReadKey();
        }
    }
}
