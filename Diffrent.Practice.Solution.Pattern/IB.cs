using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp
{
    public interface IB : IA
    {
        int IBPrint() { return 0; }
    }
}
