using CollectionTester.Interfaces;
using CollectionTester.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CollectionTester.Collection
{
    class Hashtable1 : ICollectionWrapper
    {
        private Hashtable hashtable = new Hashtable();
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.Hashtable;
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
            if (!hashtable.Contains(word))
                hashtable.Add(word, true);
        }
        public bool Contains(string word)
        {
            return hashtable.ContainsKey(word);
        }

        public void DeleteOneWord()
        {
            var key = hashtable.Keys.GetEnumerator();
			key.MoveNext();
            hashtable.Remove(key.Current);
        }
    }
}

