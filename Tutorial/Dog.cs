using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    public class Dog
    {
        public string name;
        public int age;
        //rating can only be one of A, B, C, D
        //private attribute
        private string rating;
        //static attribute: belong to the class, not for a specific instance/object
        public static int dogCount = 0;


        //Property: getter & setter
        // https://www.youtube.com/watch?v=8FmE_-QXg3Y
        public string Name { get; set; }
        public int Age { get; set; }
        public string Rating
        {
            get { return rating; }
            set { 
                if(value=="A"||value=="B" || value == "C" || value == "D")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }
        }
        

        //constructor
        public Dog(string aname, int aage, string aRating):this()
        {
            Console.WriteLine("calling constructor");
            name = aname;
            age = aage;
            Rating = aRating;
            //dogCount++;
        }

        //constructor
        public Dog()
        { 
            Console.WriteLine("calling constructor2");
            dogCount++;
        }

        //method
        public void Bark()
        {
            Console.WriteLine("Bark");
        }
        public int getDogCount()
        {
            return dogCount;
        }
        //static method
        //could be accessed directly without creating an instance of that class
        public static void SayHi(string name)
        {
            Console.WriteLine("Hi "+name);
        }

    }
}
