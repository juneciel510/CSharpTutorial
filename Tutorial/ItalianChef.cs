using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial
{
    class ItalianChef: ChefInheritanceExample
    {
        public override void MakeSpecialDish() //virtual: sub-class can overwrite this method
        {
            Console.WriteLine("The chef makes BBQ ribs");
        }
        public void MakePasta() //void: do not return anything
        {
            Console.WriteLine("The chef makes pasta");
        }
    }
}
