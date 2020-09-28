using System.Security.Cryptography;
using NUnit.Framework;


namespace ECS.NewECS.Tests.temp
{
    [TestFixture]
    public class TempSensor_Test
    {
        private ITempSensor _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new TempSensor();
        }

        [Test]
        public void gettemp()
        {
            
        }
    }
}