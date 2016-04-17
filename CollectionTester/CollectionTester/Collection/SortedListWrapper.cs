using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collection
{
    class SortedListWrapper : ICollectionWrapper
    {
        private SortedList<string,bool> sortedlist = new SortedList<string,bool>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.SortedList;
            }
        }
        public int Count
        {
            get
            {
                return sortedlist.Count;
            }
        }
        public string SystemTypeName
        {
            get
            {
                return sortedlist.GetType().FullName;
            }
        }
        public void Add(string word)
        {
            if (!sortedlist.ContainsKey(word))
             sortedlist.Add(word, true);
        }

        public bool Contains(string word)
        {
            return sortedlist.ContainsKey(word);
        }

        public void DeleteOneWord()
        {
            sortedlist.RemoveAt(0);
        }
    }
}
