using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class EcsLegacyUnitTests
    {
        private ECS _uut;
        public int FakeThreshold = 10;
        FakeHeater _fakeHeater;
        FakeTempSensor _fakeTempSensor;
        [SetUp]
        public void Setup()
        {
            _fakeHeater = new FakeHeater();
            _fakeTempSensor = new FakeTempSensor();
            
            _uut = new ECS(FakeThreshold, _fakeTempSensor, _fakeHeater);
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}