using System;

namespace ECS.Legacy.Test.Unit
{
    internal class FakeTempSensor : ITempSensor
    {
        
        public int FakeTemp = 0;

        // Helper Function to limit int to [-5:45]
        private int GenFakeTemp()
        {
            if (this.FakeTemp < -5)
            {
                return -5;
            }
            else if (this.FakeTemp > 45)
            {
                return 45;
            }
            else
            {
                return this.FakeTemp;
            }
        }

        public int GetTemp()
        {
            return this.GenFakeTemp();
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}