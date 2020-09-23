using System;
using System.Threading;

namespace ECS.NewECS
{
    public class Application
    {
        public static void Main(string[] args)
        {
            // Det her er til 4.2 extension 2: lade folk ændre thresholds i runtime
            // for at ændre arguments som man kører programmet med i Visual studio:
            // gå ind i properties for solution og ændr application arguments under debug
            int thr_heater = Int32.Parse(args[0]);
            int thr_vindue = Int32.Parse(args[1]);


            var ecs = new ECS(thr_heater, thr_vindue);

            // fyrede lige et loop ind for at se om ting ændrede sig som de skulle
            while (true)
            {

                ecs.Regulate();


                ecs.Regulate();

                Thread.Sleep(1000);
            }

        }
    }
}
