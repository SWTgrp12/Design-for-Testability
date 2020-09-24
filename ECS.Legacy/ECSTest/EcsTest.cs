using NUnit.Framework;
using ECS.NewECS;

namespace ECSTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ECSThreshold_Constructor_thres()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(28,30,a,b,c);

            Assert.That(ecs.GetThreshold(),Is.EqualTo(28));

        }

        [Test]
        public void ECSThreshold_Constructor_vinthres()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(28, 30, a, b, c);

            Assert.That(ecs.GetThresholdVindue(), Is.EqualTo(28));

        }

        [Test]
        public void ECSThreshold_SetMethod()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(28, 30, a, b, c);

            ecs.SetThreshold(5);

            Assert.That(ecs.GetThreshold(), Is.EqualTo(5));

        }

        [Test]
        public void ECSThreshold_SetMethod_vindue()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(28, 30, a, b, c);

            ecs.SetThresholdVindue(32);

            Assert.That(ecs.GetThreshold(), Is.EqualTo(32));

        }

        [Test]
        public void ECSRegulateHeat()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(24, 30, a, b, c);

            Assert.That(a.State,Is.EqualTo(true));

        }

        public void ECSRegulatevindue()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var c = new FakeVindue();


            var ecs = new ECS_Main(24, 30, a, b, c);

            Assert.That(c.State, Is.EqualTo(false));

        }
    }
}