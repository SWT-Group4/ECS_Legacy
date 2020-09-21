using System.Security.Cryptography.X509Certificates;
using NUnit.Framework;

namespace ECS.Legacy.Test.Unit
{
    [TestFixture]
    public class EcsLegacyUnitTests
    {
        /**
         *  @brief Unit tests for the ECS class (legacy code)
         *  @params FakeHeater, FakeTempSensor, Threshold
         *
         * Resume:
         * Answers to exercise 3 & 4 lektion 3.1+3.2 W38
         * This Test Fixture will create an ECS object as UUT,
         * and stimulate it with controllable input
         * i.e. fakes as input that we implement in sub-classes
         * refer to FakeTempSensor.cs and FakeHeater.cs
         * They interface to the ECS class through abstract
         * class (interface) IHeater and ITempSensor
         */

        // Declare the UUT to be of type ECS class
        private ECS _uut;

        // Declare that we will use some fake sources as input
        FakeHeater _fakeHeater;
        FakeTempSensor _fakeTempSensor;

        // Initialize Test Variables that can be adjusted to stimulate UUT
        public int FakeThreshold = 10;
        
        [SetUp]
        public void Setup()
        {
            // Create fakes and interface them to ECS to enable us to
            // stimulate ECS to test it from known inputs that we control!
            _fakeHeater = new FakeHeater();
            _fakeTempSensor = new FakeTempSensor();

            // Create the Unit Under Test (The ECS class)
            _uut = new ECS(FakeThreshold, _fakeTempSensor, _fakeHeater);
        }

        // Test Methods:
        // 1. SetThreshold sets a threshold value
        // 2. GetThreshold retrieves the correct value
        [TestCase(55,55)]
        [TestCase(888, 888)]
        [TestCase(-1, -1)]
        public void CanSetThreshold_CorrectValue(int testData, int expectedOutputValue)
        {
            _uut.SetThreshold(testData);
            Assert.That(_uut.GetThreshold(), Is.EqualTo(expectedOutputValue));
        }
        }
}