using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConcordanceLibrary.Classes
{
    public class ConcordanceCreater
    {
        private string _alphabet;

        public ConcordanceCreater(string alphabetPath)
        {
            StreamReader alphabet = new StreamReader(alphabetPath);
            _alphabet = alphabet.ReadLine();
        }

        public void CreateConrcondance(string path, int N) // N - count of string in one page;
        {
            StreamReader text = new StreamReader(path);

            string pattern = string.Format("\\b[{0}]*\\b", _alphabet);
            Regex regex = new Regex(pattern);

            StringBuilder currentPage = new StringBuilder();
            string currentString = text.ReadLine();
            int currentStringNumber = 0;
            while (currentString != null)
            {
                currentStringNumber += 1;
                currentPage.Append(currentString + " ");
                if (currentStringNumber == N || text.ReadLine() == null)
                {

                }
                currentString = text.ReadLine();
            }
        }
    }
}
