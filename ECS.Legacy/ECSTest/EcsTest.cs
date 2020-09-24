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
            // modules used by unit
            var _heater = new FakeHeater();
            var _tempsensor = new FakeTempSensor();
            var _vindue = new FakeVindue();
            //
            _uut = new ECS_Main(28, 30, _heater, _tempsensor, _vindue);
        }

        [Test]
        public void ECSThreshold_Constructor_thres()
        {

            Assert.That(_uut.GetThreshold(),Is.EqualTo(28));

        }

        [Test]
        public void ECSThreshold_Constructor_vinthres()
        {
            Assert.That(_uut.GetThresholdVindue(), Is.EqualTo(30));

        }

        [Test]
        public void ECSThreshold_SetMethod()
        {
            _uut.SetThreshold(5);

            Assert.That(_uut.GetThreshold(), Is.EqualTo(5));

        }

        [Test]
        public void ECSThreshold_SetMethod_vindue()
        {
            _uut.SetThresholdVindue(32);

            Assert.That(_uut.GetThreshold(), Is.EqualTo(32));

        }

        [Test]
        public void ECSRegulateHeat()
        {
            Assert.That(_heater.State,Is.EqualTo(true));

        }

        public void ECSRegulatevindue()
        {
            Assert.That(_vindue.State, Is.EqualTo(false));

        }
    }
}