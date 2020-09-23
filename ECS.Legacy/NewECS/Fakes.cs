using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.NewECS
{
    public class FakeHeater: IHeater
    {
        public void TurnOn()
        {
            Console.WriteLine("on fake heater");
        }

        public void TurnOff()
        {
            Console.WriteLine("off fake heater");
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 28;
        }
    }
}
