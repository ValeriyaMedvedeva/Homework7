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
    class DictionaryWrapper : ICollectionWrapper
    {
        private Dictionary<string,bool> dictionary = new Dictionary<string,bool>();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.Dictionary;
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
            if (!dictionary.ContainsKey(word))
                dictionary.Add(word, true);
        }

        public bool Contains(string word)
        {
            return dictionary.ContainsKey(word);
        }

        public void DeleteOneWord()
        {
            dictionary.Remove(dictionary.Keys.First());
        }
    }
}
