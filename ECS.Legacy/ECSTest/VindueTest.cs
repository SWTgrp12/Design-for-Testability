using NUnit.Framework;

namespace ECS.NewECS.Tests
{
    [TestFixture]
    public class Vindue_Test
    {
        private IVindue _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Vindue();
        }

        [Test]
        public void Startup()
        {

            Assert.That(_uut.State, Is.False);

        }

        [Test]
        public void Open()
        {
            _uut.Open();
            Assert.That(_uut.State, Is.True);

        }
        [Test]
        public void Close()
        {
            _uut.Open();
            Assert.That(_uut.State, Is.True);
            _uut.Close();
            Assert.That(_uut.State, Is.False);

        }

    }
}