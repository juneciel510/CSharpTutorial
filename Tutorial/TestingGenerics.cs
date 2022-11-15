using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class TestingGenerics
    {

        public void Start()
        {
            Console.WriteLine("TestingGenerics Start...");
            int[] intArray = CreateArray<int>(5, 6);
            Console.WriteLine(intArray.Length + " " + intArray[0] + " " + intArray[1]);
            Console.WriteLine(intArray.GetType());

            Console.WriteLine(CreateArray<string>("asfs", "sd2sgg").GetType());
            TestMultiGenerics<int,string>(1, "sgs");

            MyClass<int> myClass = new MyClass<int>();
            myClass.value = 3;
            Console.WriteLine(myClass.value);


        }
        

        private T[] CreateArray<T>(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }

        private void TestMultiGenerics<T1,T2>(T1 t1,T2 t2)
        {
            Console.Write(t1.GetType());
            Console.Write(t2.GetType());
            Console.WriteLine();

        }
    }

    public class MyClass<T>
    {
        public T value;
        //No need to have <T> after CreateArray, like private T[] CreateArray<T>(),
        //as T is already specified after MyClass
        private T[] CreateArray(T firstElement, T secondElement)
        {
            return new T[] { firstElement, secondElement };
        }
    }

    public interface ITestG<T>
    {
        void Damage(T t);
    }

    public class TestGMinor: ITestG<int>
    {
        public void Damage(int i)
        {
            Console.WriteLine("TestGMinor.Damage()");

        }
       
    }



}
