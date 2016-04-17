using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionTester.Model
{
    //Класс,который генерирует заданное количество различных слов(из русского алфавита) заданной длины.
    class GeneratorWord
    {
        public string[] Generator(int count, int size)
        {
            Random rand = new Random();
            string[] massiv=new string[count];
            int n;
            char simvol;
            for (int i = 0; i < count; i++)
            {
               n = size;
               while(n!=0){
                    simvol = (char)rand.Next(0x0410, 0x44F);
                    massiv[i] += simvol;
                    n--;
                }
            }
            return massiv;
        }
    }
}
