using ConcordanceLibrary.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConcordanceDemonstration.Interfaces;

namespace ConcordanceLibrary.Classes
{
    public class Concordance : IConcordance
    {
        private IDictionary<char, IDictionary<string, IWordInfo>> _items;

        public IDictionary<char, IDictionary<string, IWordInfo>> Items
        {
            get
            {
                return _items;
            }
        }

        public Concordance(string letters)
        {
            _items = new Dictionary<char, IDictionary<string, IWordInfo>>();
            foreach(char letter in letters)
            {
                _items[char.ToUpper(letter)] = new Dictionary<string, IWordInfo>();
            }
        }

        public void SaveToFile()
        {
            throw new NotImplementedException();
        }
    }
}
