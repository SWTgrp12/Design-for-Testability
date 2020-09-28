using System;

namespace ECS.NewECS
{
    public class TempSensor: ITempSensor
    {
        private Random gen = new Random();

        public int GetTemp()
        {
            return gen.Next(-5, 45);
        }

    }
}