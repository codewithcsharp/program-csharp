using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public class DerivedClass : BaseClass
    {
        public override void ShowInDerived()
        {
            Console.WriteLine("Hello show in Derived");
        }

        public int ShowOutDerived(int a)
        {
            return 0;
        }
        public void ShowOutDerived(int a, string b)
        {
            Console.WriteLine("Hello show in Derived");
        }
    }
}
