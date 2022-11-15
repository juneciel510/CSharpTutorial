using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    //Delegates: store a function in a variable
    //Action: delegate with void return type, no parameters
    //Action<T>,Action<T1,T2>,and so on: delegate with void return type, custom parameters
    //Func<T>: delegate with custom return type, no parameters
    //Func<T1,T2>,Func<T1,T2,T3>: delegate with custom return type(the last one), custom parameters(the previous ones)
    /*
     * Func<int, string, bool> myDelegate;
     * equals
     * delegate bool MyDelegate(int a, string b);
     * MyDelegate myDelegate;
     
     */

    class TestingDelegates
    {
        delegate void TestExample2(string s);
        public void Test()
        {
            MyClass myClass = new MyClass();
            myClass.IterateThroughNumber(MyHome);

            TestExample2 testExample2 = new TestExample2(Example2);
            testExample2.Invoke("Lejun_delegate");

            //Anonymous Function
            TestExample2 testExample3 = (x)=>
            {
                Console.WriteLine($"Hello {x}");
            };
            testExample3.Invoke("Lejun1_delegate");
        }

        static void MyHome(int finalCount)
        {
            if (finalCount >= 3 && finalCount < 7)
            {
                Console.WriteLine("Thats a big number");
            }
            else
            {
                Console.WriteLine(finalCount);
            }
        }

        static void Example2(string s)
        {
            Console.WriteLine($"Hello {s}");
        }

    }
    class MyClass
    {
        public delegate void MyDelegate(int passedCount);
        public void IterateThroughNumber(MyDelegate myDelegate)
        {
            var count = 0;
            while (count < 10)
            {
                count++;
                myDelegate(count);
            }
        }

        
    }
}
