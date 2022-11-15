using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    //can not create an instance for static class
    static class AStaticClass
    {
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi " + name);
        }
    }
}
