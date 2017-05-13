﻿using ConcordanceDemonstration.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcordanceDemonstration.Classes
{
    class WordInfo : IWordInfo
    {
        private int _count;
        private string _value;
        ICollection<int> _pageNumbers;

        public int Count
        {
            get
            {
                return _count;
            }
        }
        public int CounUp
        {
            set
            {
                _count += 1;
            }
        }
        public ICollection<int> PageNumbers
        {
            get
            {
                return _pageNumbers;
            }
        }
        public string Value
        {
            get
            {
                return _value;
            }
        }

        public WordInfo(string value, int pageNumber)
        {
            _value = value;
            _count = 1;
            _pageNumbers = new List<int>();
            _pageNumbers.Add(pageNumber);
        }

        public void AddPageNumber(int pageNumber)
        {
            if (_pageNumbers.Contains(pageNumber) == false)
                _pageNumbers.Add(pageNumber);
        }
        public string PageNumbersToString()
        {
            return string.Join(" ", _pageNumbers);
        }
    }
}
