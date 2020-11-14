using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonStaticNoReturnType
{
    class NonStaticNoReturn
    {
        class StaticNoReturn
        {
            static void Main(string[] args)
            {
                Functions f = new Functions();
                f.Fun();
            }
        }
    }
}
