using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.NewECS
{
    class HeaterTester: ITester
    {
        public bool RunSelfTest()
        {
            return true;
        }
    }

    class TempsensorTester : ITester
    {
        public bool RunSelfTest()
        {
            return true;
        }
    }
}
