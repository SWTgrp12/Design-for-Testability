
namespace ECS.NewECS
{
    public class ECS_Main
    {
        public int _thresholdHeater { get; private set; }
        public int _thresholdVindue { get; private set; }
        private readonly IHeater _heater;
        private readonly ITempSensor _tempSensor;
        private readonly IVindue _vindue;

        /// <summary>
        /// Insert HeaterThreshold, VindueThreshold, og objects Heater, Tempsensor, Vindue.
        /// </summary>
        public ECS_Main(int thresholdHeater, int thresholdVindue, IHeater heater, ITempSensor tempSensor, IVindue vindue)
        {
            SetThresholdHeater(thresholdHeater);
            SetThresholdVindue(thresholdVindue);
            _heater = heater;
            _tempSensor = tempSensor;
            _vindue = vindue;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _thresholdHeater)
            {
                _heater.TurnOn();
                _vindue.Close();
            }
            else if(t > _thresholdHeater)
            {
                _heater.TurnOff();
                _vindue.Open();
            }

            else
            {
                // do nothing
            }
            
               

        }

        public void SetThresholdHeater(int thr)
        {
                _thresholdHeater = thr;
      
        }
        public void SetThresholdVindue(int thr)
        {
            if (thr >= _thresholdHeater)
                _thresholdVindue = thr;
            else
                System.Console.WriteLine("Window threshold must be higher than heater threshold");
        }
    }
}
