using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    // https://www.youtube.com/watch?v=VcAubtFBOdY
    /*
     * IEnumerable interface is the base interface for many collections in C#, 
     * and its job is to provide a way of iteration through a collection.
     * 
     *1. IEumerable <T> for generic collection
     *2. IEumerable for non-generic collection
     */

    /*
     * IEumerable <T> contains a single method that you must implement when implementing this interface;
     * GetEnumerator(), which returns an IEnumerator<T> object.
     * The returned IEnumerator<T> provides the ability to interate through the collection
     * by exposing a current property that points at the object we are currently at in the collection. 
     */
    class TestingIEmumerable
    {
        public void Test()
        {
            BirdShelter shelter = new BirdShelter();
            foreach (Bird bird in shelter)
            {
                if (!bird.IsNoisyBird)
                {
                    bird.GiveTreat(2);
                }
                else
                {
                    bird.GiveTreat(1);
                }
            }
        }

        public void Test2()
        {
            Console.WriteLine("testing Inumerable 2");
            IEnumerable<int> unknownCollection;
            unknownCollection = GetCollection(2);
            foreach(int num in unknownCollection)
            {
                Console.WriteLine(num + " ");
            }
            CollectionSum(unknownCollection);


        }


        static IEnumerable<int> GetCollection(int option)
        {
            List<int> numberList = new List<int>() { 1, 12, 3, 4 };
            Queue<int> numberQueue = new Queue<int>();
            numberQueue.Enqueue(6);
            numberQueue.Enqueue(7);
            numberQueue.Enqueue(8);
            numberQueue.Enqueue(9);
            numberQueue.Enqueue(10);

            if (option == 1)
            {
                return numberList;
            }
            else if (option == 2)
            {
                return numberQueue;
            }
            else
            {
                return new int[] { 11, 12, 13, 14 };
            }
        }

        static void CollectionSum(IEnumerable<int> anyCollection)
        {
            int sum = 0;
            foreach(int num in anyCollection)
            {
                sum += num;
            }
            Console.WriteLine("Sum is {0}",sum);
        }
    }

    class Bird
    {
        public string Name { get; set; }
        public bool IsNoisyBird { get; set; }

        public Bird(string name, bool isNoisyBird)
        {
            this.Name = name;
            this.IsNoisyBird = isNoisyBird;
        }
        public void GiveTreat(int numberofTreats)
        {
            Console.WriteLine("Bird: {0} get treats {1} times!", Name, numberofTreats);
        }

    }

    class BirdShelter:IEnumerable<Bird>
    {
        public List<Bird> birds;
        public BirdShelter()
        {
            birds = new List<Bird>()
            {
                new Bird("Casper",false),
                new Bird("Sif",false),
                new Bird("Oreo",true),
                new Bird("Pixel",false),
            };
        }

        //generic Enumberator
        public IEnumerator<Bird> GetEnumerator()
        {
            return birds.GetEnumerator();
        }

        //non generic Enumberator
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

        
    }
}
