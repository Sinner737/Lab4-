using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Singleton s1 = Singleton.Initialize();

            Console.WriteLine(s1.GetHashCode());

            Singleton s2 = Singleton.Initialize();

            Console.WriteLine(s2.GetHashCode());

            Console.ReadKey();

        }
    }
}
