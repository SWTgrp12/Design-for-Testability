using NSubstitute;
using NUnit.Framework;


namespace ECS.NewECS.Tests.heater
{
    [TestFixture]
    public class Heater_Test
    {
        private IHeater _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Heater();
        }

        [Test]
        public void turnon()
        {
            _uut.TurnOn();
            Assert.That(_uut.State,Is.EqualTo(true));
        }

        [Test]
        public void turnoff()
        {
            _uut.TurnOff();
            Assert.That(_uut.State, Is.EqualTo(false));
        }

    }
}