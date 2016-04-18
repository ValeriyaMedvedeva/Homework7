using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CollectionTester.Model;

namespace CollectionTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Controller controll = new Controller();
            controll.TestAllCollectionsAndDisplayResults();
        }
    }
}
