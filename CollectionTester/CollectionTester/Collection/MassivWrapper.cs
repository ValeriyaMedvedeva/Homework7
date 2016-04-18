using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Model;

namespace CollectionTester.Collection
{
    class MassivWrapper : ICollectionWrapper
    {
        private string[] massiv=new string[0];
        private int count=0;
        public CollectionType CollectionType
        {
            get
            {
                return CollectionType.Massiv;
            }
        }

        public int Count
        {
            get
            {
                return count;
            }
        }

        public string SystemTypeName           
        {
            get
            {
                return massiv.GetType().FullName;
            }
        }

        public void Add(string word)
        {
            count++;
            Array.Resize(ref massiv, count);
            massiv[count-1] = word;
        }

        public bool Contains(string word)                    
        {
            return massiv.Contains(word);
        }

        public void DeleteOneWord()
        {
              count--;
              Array.Resize(ref massiv, count);
        }
    }
}

