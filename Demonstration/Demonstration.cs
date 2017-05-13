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
        static void Main(string[] args)
        {
            string textFilePath = ConfigurationManager.AppSettings["TextFilePath"];
            string alhabetFilePath = ConfigurationManager.AppSettings["AlphabetFilePath"];

            ConcordanceCreater concordanceCreater = new ConcordanceCreater(alhabetFilePath);
            concordanceCreater.CreateConrcondance(textFilePath, 2);
        }
    }
}
