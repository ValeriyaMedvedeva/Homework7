using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Interfaces;
using CollectionTester.Collection;
using CollectionTester.Model;

namespace CollectionTester.Model
{
    //Класс,который производит работу с контейнерами,выводит результат тестирования каждого контейнера на экран.
    public class Controller : IController
    {
        public void TestAllCollectionsAndDisplayResults()
        {
            int kol = 0;
            bool flag = false;
            List<ICollectionWrapper> collection = new List<ICollectionWrapper>();
            Console.WriteLine("Введите количество желаемых контейнеров(от 1 до 9) для хранения строк:");
            while (!flag)
            {
                if (!Int32.TryParse(Console.ReadLine(), out kol))
                {
                    Console.WriteLine("Вы ввели не число,пожалуйста,повторите вход!");
                }
                else
                    if (kol < 0 || kol > 9)
                    {
                        Console.WriteLine("Вы ввели неверное число,такого количества контейнеров не существует,пожалуйста,повторите вход!");
                    }
                else flag = true;
            }
            while (kol != 0)
            {
                collection = AddCollection(collection);
                kol--;
            }
            long time;
            GeneratorWord generator = new GeneratorWord();
            string[] massiv = generator.Generator(100000, 10);
            bool f;
            int count;
            Console.WriteLine("\nРезультаты тестирования:");
            foreach (ICollectionWrapper coll in collection)
            {
                Console.WriteLine("\nТип: {0}", coll.CollectionType);
                Console.WriteLine("Полное имя пространства имен: {0}", coll.SystemTypeName);
                time = DateTime.Now.Ticks;
                for (int i = 0; i < massiv.Count(); i++)
                {
                    coll.Add(massiv[i]);
                }
                Console.WriteLine("Время(в секундах) на добавление строк: {0}", (double)(DateTime.Now.Ticks - time) / 10000000);
                time = DateTime.Now.Ticks;
                kol = coll.Count;
                Console.WriteLine("Время(в секундах) на определеие количества строк: {0}, количество записей: {1}", (double)(DateTime.Now.Ticks - time) / 10000000, kol);
                time = DateTime.Now.Ticks;
                f = coll.Contains("телевизоры");
                if (f)
                    Console.WriteLine("Строка найдена,время(в секундах) на поиск: {0}", (double)(DateTime.Now.Ticks - time) / 10000000);
                else
                    Console.WriteLine("Строка не найдена,время(в секундах) на поиск: {0}", (double)(DateTime.Now.Ticks - time) / 10000000);
                count = coll.Count;
                time = DateTime.Now.Ticks;
                while (count != 0)
                {
                    coll.DeleteOneWord();
                    count--;
                }
                Console.WriteLine("Время(в секундах) удаление всех строк: {0}, количество записей: {1}", (double)(DateTime.Now.Ticks - time) / 10000000, kol = coll.Count);
            }
            Console.ReadLine();
        }
        public List<ICollectionWrapper> AddCollection(List<ICollectionWrapper> collection)
        {
            bool flag = true;
            ConsoleKeyInfo opt;
            do
            {
                Console.Clear();
                Console.WriteLine("1. Введите 1,чтобы добавить контейнер List;");
                Console.WriteLine("2. Введите 2,чтобы добавить контейнер ArrayList;");
                Console.WriteLine("3. Введите 3,чтобы добавить контейнер Massiv;");
                Console.WriteLine("4. Введите 4,чтобы добавить контейнер Hashtable;");
                Console.WriteLine("5. Введите 5,чтобы добавить контейнер HashtableGetHashCode;");
                Console.WriteLine("6. Введите 6,чтобы добавить контейнер HashSet;");
                Console.WriteLine("7. Введите 7,чтобы добавить контейнер Dictionary;");
                Console.WriteLine("8. Введите 8,чтобы добавить контейнер DictionaryGetHashCode;");
                Console.WriteLine("9. Введите 9,чтобы добавить контейнер SortedList;");
                opt = Console.ReadKey();
                switch (opt.Key)
                {
                    case ConsoleKey.D1:
                        if (!collection.Contains(new ListWrapper()))
                        {
                            collection.Add(new ListWrapper());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D2:
                        if (!collection.Contains(new ArrayListWrapper()))
                        {
                            collection.Add(new ArrayListWrapper());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D3:
                        if (!collection.Contains(new MassivWrapper()))
                        {
                            collection.Add(new MassivWrapper());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D4:
                        if (!collection.Contains(new Hashtable1()))
                        {
                            collection.Add(new Hashtable1());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D5:
                        if (!collection.Contains(new HashtableGetHashCode()))
                        {
                            collection.Add(new HashtableGetHashCode());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D6:
                        if (!collection.Contains(new HashSetWrapper()))
                        {
                            collection.Add(new HashSetWrapper());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D7:
                        if (!collection.Contains(new DictionaryWrapper()))
                        {
                            collection.Add(new DictionaryWrapper());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D8:
                        if (!collection.Contains(new DictionaryGetHashCode()))
                        {
                            collection.Add(new DictionaryGetHashCode());
                            flag = false;
                        }
                        break;
                    case ConsoleKey.D9:
                        if (!collection.Contains(new SortedListWrapper()))
                        {
                            collection.Add(new SortedListWrapper());
                            flag = false;
                        }
                        break;
                    default:
                        Console.WriteLine("\nНе правильный ввод или данная коллекция уже существует,пожалуйста,попробуйте еще раз!");
                        Console.ReadKey();
                        break;
                }
                Console.ReadKey();
            } while (flag);
            Console.Clear();
            return collection;
        }
    }
}
