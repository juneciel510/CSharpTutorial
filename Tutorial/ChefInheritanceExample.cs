using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class ChefInheritanceExample
    {
        public void MakeChicken() //void: do not return anything
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad() //void: do not return anything
        {
            Console.WriteLine("The chef makes salad");
        }
        public virtual void MakeSpecialDish() //virtual: sub-class can overwrite this method
        {
            Console.WriteLine("The chef makes special dish");
        }
    }
}
