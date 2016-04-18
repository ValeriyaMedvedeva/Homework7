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
    class HashtableGetHashCode : ICollectionWrapper
    {
        private Hashtable hashtable = new Hashtable();
        private List<string> list;
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.HashtableGetHashCode;
            }
        }

        public int Count
        {
            get
            {
                return hashtable.Count;
            }
        }

        public string SystemTypeName
        {
            get
            {
                return hashtable.GetType().FullName;
            }
        }

        public void Add(string word)
        {
            int key = word.GetHashCode();
            if (!hashtable.ContainsKey(key))
                hashtable.Add(key, new List<string>());
            list = hashtable[key] as List<string>;
            list.Add(word);
        }
        public bool Contains(string word)
        {
            int key = word.GetHashCode();
            if (hashtable.ContainsKey(key))
            {
                list = hashtable[key] as List<string>;
                return list.Contains(word);
            }
            else
                return false;
        }

        public void DeleteOneWord()
        {
            var key = hashtable.Keys.GetEnumerator();
            key.MoveNext();
            hashtable.Remove(key.Current);
        }
    }
}

