namespace ECS.NewECS
{
    public class Heater: IHeater
    {

        public bool State { get; private set; } = false;
        public void TurnOn()
        {
            System.Console.WriteLine("Heater is on");
            State = true;
        }

        public void TurnOff()
        {
            System.Console.WriteLine("Heater is off");
            State = false;

        }


    }
}