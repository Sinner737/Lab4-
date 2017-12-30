using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternSingleton
{
    class Singleton
    {
        private static Singleton single = null;


        protected Singleton() { }

        public static Singleton Initialize()
        {
            if (single == null)
                single = new Singleton();
            return single;
        }
    }
}
