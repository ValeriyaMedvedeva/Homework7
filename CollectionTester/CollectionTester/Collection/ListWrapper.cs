using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collection
{
    class ListWrapper : ICollectionWrapper
    {
        private List<string> list = new List<string>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.List;
            }
        }

        public int Count
        {
            get
            {
                return list.Count;
            }
        }

        public string SystemTypeName
        {
            get
            {
                return list.GetType().FullName;
            }
        }

        public void Add(string word)
        {
            list.Add(word);
        }

        public bool Contains(string word)
        {
            return list.Contains(word);
        }

        public void DeleteOneWord()
        {
            list.RemoveAt(0);
        }
    }
}
