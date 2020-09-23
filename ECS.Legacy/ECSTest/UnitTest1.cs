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
        public void ECSThreshold_Constructor()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var ecs = new ECS_Main(28,b,a);

            Assert.That(ecs.GetThreshold(),Is.EqualTo(28));

        }

        [Test]
        public void ECSThreshold_SetMethod()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var ecs = new ECS_Main(28, b, a);

            ecs.SetThreshold(5);

            Assert.That(ecs.GetThreshold(), Is.EqualTo(5));

        }

        public void ECSRegulate()
        {
            var a = new FakeHeater();

            var b = new FakeTempSensor();

            var ecs = new ECS_Main(28, b, a);

            Assert.

        }
    }
}