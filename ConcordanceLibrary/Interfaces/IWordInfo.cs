using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcordanceDemonstration.Interfaces
{
    public interface IWordInfo
    {
        string Value { get; }
        int Count { get; }
        int CounUp { set; }
        ICollection<int> PageNumbers { get; }
        string PageNumbersToString();
    }
}
