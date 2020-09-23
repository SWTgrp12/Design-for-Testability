
namespace ECS.NewECS
{
    public class ECS_Main
    {
        private int _threshold;
        private int _thresholdVindue;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;
        private readonly IVindue _vindue;

        public ECS(int thr, int thr2, IHeater a, ITempSensor b, IVindue c)
        {
            SetThresholdVindue(thr2);
            SetThreshold(thr);
            _tempSensor = b;
            _heater = a;
            _vindue = c;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold){
                _heater.TurnOn();
                _vindue.Close();
            }
            else if(t > _threshold)
            {
                _heater.TurnOff();
                _vindue.Open();
            }

            else
            {
                // do nothing
            }
            
               

        }

        public void SetThreshold(int thr)
        {
            if (thr < _thresholdVindue)
                _threshold = thr;
            else
                System.Console.WriteLine("Heater threshold must be lower than Window threshold");
        }

        public int GetThreshold()
        {
            return _threshold;
        }
        public void SetThresholdVindue(int thr)
        {
            if (thr > _threshold)
                _thresholdVindue = thr;
            else
                System.Console.WriteLine("Window threshold must be higher than heater threshold");
        }

        public int GetThresholdVindue()
        {
            return _thresholdVindue;
        }


        /* needs changing
        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
        */
    }
}
