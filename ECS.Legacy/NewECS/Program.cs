using System;

namespace ECS.NewECS
{
    class Program
    {
        static void Main(string[] args)
        {
            ECS_Main ECS = new ECS_Main(26, 28,new Heater(), new TempSensor(), new Vindue());
            ConsoleKeyInfo keyInfo; 

            while(true){
                Console.WriteLine("Enter heater threshold:");
                int thers_heat = Console.ReadLine();
                Console.WriteLine("new heater threshold is: " + thers_heat);
                Console.WriteLine("Enter window threshold:");
                int thers_heat = Console.ReadLine();
                Console.WriteLine("new window threshold is: " + thers_heat);

                while ((keyInfo = Console.ReadKey()).Key != ConsoleKey.Enter)){
                 ECS.Regulate();
                }
            }

        }
    }
}
