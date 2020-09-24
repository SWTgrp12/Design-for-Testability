using NUnit.Framework;
using NSubstitute;

namespace ECS.NewECS.Tests
{
    [TestFixture]
    public class Ecs_Test_Nsubs
    {
        private IHeater _heater;
        private ITempSensor _tempsensor;
        private IVindue _vindue;

        private ECS_Main _uut;

        [SetUp]
        public void Setup()
        {
            // modules used by unit
            var _heater = Substitute.For<IHeater>();
            var _tempsensor = Substitute.For<ITempSensor>();
            var _vindue = Substitute.For<IVindue>();
            //
            _uut = new ECS_Main(28, 30, _heater, _tempsensor, _vindue);
        }

        [Test]
        public void ECSRegulatevindue()
        {
            _heater.State.Returns(false);
            _uut.Regulate();
        }
    }
}