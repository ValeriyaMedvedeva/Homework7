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
    class ArrayListWrapper : ICollectionWrapper
    {
        private ArrayList list = new ArrayList();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.ArrayList;
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
