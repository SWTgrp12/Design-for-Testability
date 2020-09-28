using NUnit.Framework;
using NSubstitute;

namespace ECS.NewECS.TestsSubstitute
{
    [TestFixture]
    public class Ecs_Test_Nsubs
    {
      private IHeater _heater;
      private ITempSensor _tempsensor; 
      private IVindue _vindue;

        private ECS_Main _uut;
        // you need to make objects under textfixture otherwise they get hidden in setup 
        [SetUp]
        public void Setup()
        {
            // modules used by unit
           _heater = Substitute.For<IHeater>();
           _tempsensor = Substitute.For<ITempSensor>();
           _vindue = Substitute.For<IVindue>();
            //
            _uut = new ECS_Main(28, 30, _heater, _tempsensor, _vindue);
        }

        
        [Test]
        public void ECSRegulateHeater_on()
        {
            _tempsensor.GetTemp().Returns(26);
            _uut.Regulate();
            _heater.Received().TurnOn();
        }

        [Test]
        public void ECSRegulateHeater_off()
        {
            _tempsensor.GetTemp().Returns(29);
            _uut.Regulate();
            _heater.Received().TurnOff();
        }

        [Test]
        public void ECSRegulatevindue_on()
        {
            _tempsensor.GetTemp().Returns(29);
            _uut.Regulate();
            _vindue.Received().Open();
        }

        [Test]
        public void ECSRegulatevindue_off()
        {
            _tempsensor.GetTemp().Returns(26);
            _uut.Regulate();
            _vindue.Received().Close();
        }

    }
}