using ConcordanceDemonstration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcordanceLibrary.Interfaces
{
    public interface IConcordance
    {
        IDictionary<char, IDictionary<string, IWordInfo>> Items { get; }
        void SaveToFile();
    }
}
