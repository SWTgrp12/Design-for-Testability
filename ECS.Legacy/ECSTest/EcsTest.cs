using NUnit.Framework;


namespace ECS.NewECS.Tests
{
    [TestFixture]
    public class Ecs_Test
    {
        private IHeater _heater;
        private ITempSensor _tempsensor;
        private IVindue _vindue;

        private ECS_Main _uut;

        [SetUp]
        public void Setup()
        {
            //Startup test Values for ECS constructor 
            int threshold_Heater = 28;
            int threshold_Vindue = 30;

            // modules used by ECS
            _heater = new FakeHeater();
            _tempsensor = new FakeTempSensor();
            _vindue = new FakeVindue();
            //
            _uut = new ECS_Main(threshold_Heater, threshold_Vindue, _heater, _tempsensor, _vindue);
        }

        [Test]
        public void Constructor_Heater()
        {
            Assert.That(_uut._thresholdHeater, Is.EqualTo(28));
        }

        [Test]
        public void Constructor_Vindue()
        {
            Assert.That(_uut._thresholdVindue, Is.EqualTo(30));
        }

        [Test]
        public void ECS_HeaterThreshold_SetMethod()
        {
            _uut.SetThresholdHeater(5);

            Assert.That(_uut._thresholdHeater, Is.EqualTo(5));
        }

        [Test]
        public void ECS_VindueThreshold_SetMethod()
        {
            _uut.SetThresholdVindue(32);

            Assert.That(_uut._thresholdVindue, Is.EqualTo(32));
        }

        [Test]
        public void ECSRegulateHeat()
        {
            Assert.That(_heater.State, Is.False);
        }

        public void ECSRegulatevindue()
        {
            Assert.That(_vindue.State, Is.False);
        }
    }
}