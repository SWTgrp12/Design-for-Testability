using System;
using System.Collections.Generic;
using System.Text;

namespace ECS.NewECS
{
    public class FakeHeater: IHeater
    {
        public bool State { get; private set; } = false;

        public void TurnOn()
        {
            Console.WriteLine("on fake heater");
            State = true;
        }

        public void TurnOff()
        {
            Console.WriteLine("off fake heater");
            State = false;
        }
    }

    public class FakeTempSensor : ITempSensor
    {
        public int GetTemp()
        {
            return 28;
        }
    }

    public class FakeVindue : IVindue
    {
        public bool State { get; private set; } = false;

        public void Open()
        {
            Console.WriteLine("fake Window is Open");
            State = true;
        }
        public void Close()
        {
            Console.WriteLine("fake Window is Closed");
            State = false;
        }
    }
}
