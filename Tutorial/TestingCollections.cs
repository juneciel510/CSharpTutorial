using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    // https://www.youtube.com/watch?v=j9N2YOyInRE
    //collection: store a collection of object, usually for data storage
    /*Generic collections:
     * List
     * Dictionary
     * Sorted List
     * Stack
     * Queue
     */
    /*Non-generic collections:
     * ArrayList
     * HashTable
     * Sorted List
     * Stack
     * Queue
     */
    class TestingCollections
    {
        public void TestList()
        {    
            ListExample<int> listExample = new ListExample<int>();
            listExample.Add(30);
            listExample.Add(50);
            listExample.Display();

            ListExample<string> listExample2 = new ListExample<string>();
            listExample2.Add("sgs");
            listExample2.Add("sgsg");
            listExample2.Display();

        }

        public void TestGeneric()
        {
            List<string> myList = new List<string>();
            myList.Add("sgsshh5");
            myList.Add("kgiig");
            myList.Add("date");

            foreach (string str in myList)
            {
                Console.WriteLine(str);
            }

        }
        public void TestNonGeneric()
        {
            ArrayList arrayList = new ArrayList();
            string str = "ssgsg";
            int x = 11;
            DateTime date = DateTime.Parse("3-dec-1998");
            arrayList.Add(str);
            arrayList.Add(x);
            arrayList.Add(date);

            foreach(object obj in arrayList)
            {
                Console.WriteLine(obj);
            }

        }
    }

    public class ListExample<T>
    {
        List<T> list;
        public ListExample()
        {
            this.list = new List<T>();
        }
    
        public void Add(T value)
        {
            this.list.Add(value);
        }

        public void Display()
        {
            foreach(T x in list)
            {
                Console.WriteLine(x);
            }
        }
                
    }
}
