using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//interface
namespace Tutorial
{
    public class Cat : ICatWalker
    {
        public void CatMiao() //void: do not return anything
        {
            Console.WriteLine("Miao");
        }
        public void WalkToTheCity()
        {
            Console.WriteLine("WalkToTheCity");
        }

        public void WalkToTheFoodBowl()
        {
            Console.WriteLine("WalkToTheFoodBowl");
        }

        public void WalkToThePark()
        {
            Console.WriteLine("WalkToThePark()");
        }
    }
}
