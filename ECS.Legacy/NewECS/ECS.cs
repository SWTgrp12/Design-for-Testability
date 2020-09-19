namespace ECS.NewECS
{
    public class ECS
    {
        private int _threshold;
        private int _thresholdVindue;
        private readonly TempSensor _tempSensor;
        private readonly Heater _heater;
        private readonly Vindue _vindue;

        public ECS(int thr, int thr2)
        {
            SetThresholdVindue(thr2);
            SetThreshold(thr);
            _tempSensor = new TempSensor();
            _heater = new Heater();
            _vindue = new Vindue();
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
            {
                _heater.TurnOff();
                // Siden Heater ikke har en state variabel, kan vindue kun åbnes, hvis heater er blevet slukket
                if (t > _thresholdVindue)
                    _vindue.Open();
            }
            // men Vindue kan lukkes uanset om heater er tændt eller ej.
            // Kunne ikke se en smartere måde uden at tilføje en variabel til hear
            if (t < _thresholdVindue)
                _vindue.Close();

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

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }
        /* needs changing
        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
        */
    }
}
