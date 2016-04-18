using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collection
{
    class DictionaryGetHashCode : ICollectionWrapper
    {
        private Dictionary<int, List<string>> dictionary = new Dictionary<int,List<string>>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.DictionaryGetHashCode;
            }
        }
        public int Count
        {
            get
            {
                return dictionary.Count;
            }
        }

        public string SystemTypeName
        {
            get
            {
                return dictionary.GetType().FullName;
            }
        }
        public void Add(string word)
        {
            int key = word.GetHashCode();
            if (!dictionary.ContainsKey(key))
                dictionary.Add(key, new List<string>());
            dictionary[key].Add(word);
        }
        public bool Contains(string word)
        {
            int key = word.GetHashCode();
            if (dictionary.ContainsKey(key))
                return (dictionary[key]).Contains(word);
            return false;
        }
        public void DeleteOneWord()
        {
            var first = dictionary.First();
            dictionary.Remove(first.Key);
        }
    }
}
