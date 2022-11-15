using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class Program
    {
        static void SayHi(string name)
        {
            Console.WriteLine("Hello "+ name);
        }

        //<Thing>: Thing can be any word, i.e. T 
        public static void displayElements<Thing>(Thing[] array)
        {
            foreach (Thing item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void Main(string[] args)
        {
            //call method
            SayHi("Lejun");
            //variable
            string name = "John";
            int age;
            age = 10;
            long num = 1099877777;
            Console.WriteLine(" a man named "+ name);
            Console.WriteLine("He was "+ age + " years old");
            Console.WriteLine("/|");
                
            //Console.Write("Enter a number:");
            //double num1=Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("num1"+num1);

            //type casting
            double x = 1232.7;
            int a;
            a = (int)x;
            Console.WriteLine("a:"+a);

            string value = "7584949asfe";
            int result = 0;
            if(int.TryParse(value,out result))
            {
                Console.WriteLine("Success: " + result);
            }
            else
            {
                Console.WriteLine("Failure.");
            }


            static float FahrenheitToCelsius(float temperatureFahrenheit)
            {
                float temperatureCelsuis = (temperatureFahrenheit - 32) / 1.8f;//1.8 is a double, should be casted to float,like 1.8f
                return temperatureCelsuis;
            }
            
            // Stack is for value type and a Heap is for reference types
            //Stack
            //IMPORTANT!!! --value type can not be null
            int testValue = 4;
            byte lowLevelValue = 3; //0-256
            bool boolValue = false;

            //heap
            string stringValue = "awfaf1oo";
            StackHeapExampleLejun stackHeap = new StackHeapExampleLejun();
            int result1=stackHeap.AddFive(1);
            Console.WriteLine("result1:"+result1);


            //Array: array are used to store multiple values in a single variable
            // FIxed vs Dynamic
            //fixed
            int[] intArray = new int[2]; //array has 2 elements
            intArray[0] = 1;
            Console.WriteLine("intArray:"+intArray);

            string[] stringArray = new string[2];
            Console.WriteLine(stringArray);

            //dynamic
            int[] staticIntArray = new int[] { 5, 2, 3, 4, 1 };
            foreach (int i in staticIntArray) {
            Console.Write("{0} ", i);
            }
            int[] luckyNumbers= { 5, 2, 3, 4, 1 };
            Console.WriteLine("luckyNumbers[0]: " +luckyNumbers[0]);
            Console.WriteLine("luckyNumbers: " +luckyNumbers);
            staticIntArray.Average();
            Array.Sort(staticIntArray);
            Console.WriteLine(staticIntArray);
            foreach (int i in staticIntArray) {
            Console.Write("{0} ", i);
            }

            
            //two dimensional array
            int[,] numberGrid = {
                {1,2},
                {3,4},
                {5,6}
            };

            Console.WriteLine("numberGrid[0,0]"+numberGrid[0,0]);
            //Linq
            //array.

            /*
            */
            //string: an object, a reference type
            //double quoatation
            string testString = "test";
            String testCapitalString = "capitalString";
            string msg = null;
            //Literal VS Verbatim
            string filePath = "c:\\ProgramFiles";
            string filePathVerbatim= @"c:\ProgramFiles";
            // string immutability (read only)
            string s1 = "Hello";
            string s2 = s1;
            s1 += " World";
            Console.WriteLine("s1: " + s1); //Hello World
            Console.WriteLine("s2: " + s2); //Hello
            //string interpolation+composite formatting
            string firstName = "Teddy";
            string lastName = "Smith";
            Console.WriteLine($"My name {firstName} {lastName}");
            Console.WriteLine("My name {0} {1}", firstName, lastName);

            //string builder: string concatenate
            var sb = new StringBuilder();
            sb.Append(firstName);
            sb.Append(lastName);
            Console.WriteLine(sb);

            //single quatation
            char[] testLowLevel = new[] { 'a', 't', 'b' };

            //List
            var numbers = new int[] { 1, 2, 3, 4, 5 };
            var type = numbers.GetType();
            Console.WriteLine(type.FullName);

            do
            {
                Console.WriteLine(type.FullName);
                type = type.BaseType;
            }
            while (type != null);


            //generic= "Not specific to a particular data type"
            //          add <T> to: classes, methods, fields, etc
            //          allow for code reusability for different data types
            int[] intArray1= { 1, 2, 3, 4, 5 };
            double[] doubleArray1 = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            String[] stringArray1= { "1", "2", "3" };
            displayElements(intArray1);
            displayElements(doubleArray1);
            displayElements(stringArray1);

            List <int> lst = new List<int>();
            List<Part> partLst = new List<Part>();
            partLst.Add(new Part { PartName = "Headlight", PartId = 1 });
            partLst.Add(new Part { PartName = "Bumper", PartId = 2 });

            foreach (Part part in partLst)
            {
                Console.WriteLine(part);
                Console.WriteLine(part.PartName.ToString());
                Console.WriteLine(part.PartId.ToString());
            }

            TestingGenerics testingGenerics = new TestingGenerics();
            testingGenerics.Start();

            //if statement
            var test = 0;
            if (test==0)
            {
                Console.WriteLine("if executed");
            }
            else if (test == 1)
            {
                Console.WriteLine("else if executed"); 
            }
            else
            {
                Console.WriteLine("else statement");
            }


            //operator
            //inline or ternary operator
            var inlineCondiction = 3 > 2 ? 10 : 5;
            //equal or not equal
            bool equal = 5 == 5;//true
            bool notEqual = 5 != 1;//true
            //AND OR
            bool andAnd = 5==5&& 3 != 7;//true
            bool orOr= 5 == 5 || 3 == 7;//true

            //switch statement
            void DisplayMeasurement(double measurement)
            {
                switch (measurement)
                {
                    case < 0.0:
                        Console.WriteLine($"measure is {measurement}, too low");
                        break;
                    case > 15.0:
                        Console.WriteLine($"measure is {measurement}, too high");
                        break;
                    case double.NaN:
                        Console.WriteLine($"measure is {measurement}");
                        break;
                    default:
                        Console.WriteLine($"measure is {measurement}");
                        break;

                }
            }

            DisplayMeasurement(3.2);

            //class
            Dog dog = new Dog("Jim",5,"AA");
            Console.WriteLine("The age of the dog: "+dog.age+". The name of the dog:"+dog.name + ". The rating of the dog:" + dog.Rating);
            //Static attribute
            //Dog.attribute is static method for Dog class
            //could be accessed directly without creating an instance of that class as line 213
            Console.WriteLine("Dog.dogCount: "+Dog.dogCount);//1
            Dog dog1 = new Dog("John", 10, "A");
            Console.WriteLine("Dog.dogCount: " + Dog.dogCount);//2
            Console.WriteLine("dog1.getDogCount(): " + dog1.getDogCount());//2
            //static method
            //could be accessed directly without creating an instance of that class as line 213
            Dog.SayHi("Lejun");
            Dog dog2 = new Dog();
            Console.WriteLine("Dog.dogCount: " + Dog.dogCount);//3
            dog.Bark();

            //static class
            //can not create an instance for a static class
            AStaticClass.SayHi("Lejun");

            //class inheritance
            ChefInheritanceExample chef = new ChefInheritanceExample();
            ItalianChef italianChef = new ItalianChef();
            italianChef.MakeChicken();
            italianChef.MakePasta();
            chef.MakeSpecialDish();
            italianChef.MakeSpecialDish();

            //interface
            Cat chenxi = new Cat();
            chenxi.CatMiao();

            ICatWalker chenxi2 = new Cat();
            chenxi2.WalkToTheCity();

            //abstract class
            PingIPV6 pingIPV6 = new PingIPV6();
            Console.WriteLine(pingIPV6.Init());
            Console.WriteLine(pingIPV6.SendPing());

            PingIPV4 pingIPV4 = new PingIPV4();
            Console.WriteLine(pingIPV4.Init());
            Console.WriteLine(pingIPV4.SendPing());

            //delegate
            TestingDelegates testingDelegates = new TestingDelegates();
            testingDelegates.Test();
            
            //this
            TestingThis testingThis = new TestingThis();
            testingThis.Test();

            //event
            TestingEvents testingEvent = new TestingEvents();
            testingEvent.Test();
            testingEvent.Test();

            //collection
            TestingCollections testingCollections = new TestingCollections();
            testingCollections.TestList();
            testingCollections.TestNonGeneric();

            //IEnumerable vs IEnumerator interface
            TestingIEmumerable testingIEmumerable = new TestingIEmumerable();
            testingIEmumerable.Test();
            testingIEmumerable.Test2();



            Console.ReadLine();


        }
    }

}
