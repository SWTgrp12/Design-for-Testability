using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ECS.NewECS
{
    public class HeaterTester: ITester
    {

        public bool RunSelfTest()
        {
            return true;
        }
    }

  public class TempsensorTester : ITester
    {
        public bool RunSelfTest()
        {
            return true;
        }
    }

    public class TestAll{
        private readonly  TempsensorTester tmptst = new TempsensorTester();
        private readonly HeaterTester httst = new HeaterTester();

        public bool RunTests()
       {
           return tmptst.RunSelfTest() && httst.RunSelfTest();
       }

    }

}
