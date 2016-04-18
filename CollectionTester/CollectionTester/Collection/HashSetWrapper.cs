using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collection
{
    class HashSetWrapper : ICollectionWrapper
    {
        private HashSet<string> hashset = new HashSet<string>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.HashSet;
            }
        }
        public int Count
        {
            get
            {
                return hashset.Count;
            }
        }

        public string SystemTypeName
        {
            get
            {
                return hashset.GetType().FullName;
            }
        }
        public void Add(string word)
        {
            if (!hashset.Contains(word))
                hashset.Add(word);
        }
        public bool Contains(string word)
        {
            return hashset.Contains(word);
        }
        public void DeleteOneWord()
        {
            hashset.Remove(hashset.First());
        }
    }
}
