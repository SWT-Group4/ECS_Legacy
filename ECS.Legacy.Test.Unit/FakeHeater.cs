namespace ECS.Legacy.Test.Unit
{
    public class FakeHeater : IHeater
    {

        // Test Variables:
        public bool HeaterIsOn = false;
        public bool HeaterIsOff = false;
        // _TestVariables End

        public void TurnOn()
        {
            // Substitute System.Console.WriteLine("Heater is on");
            // With HeaterIsOn = true;
            HeaterIsOn = true;
        }

        public void TurnOff()
        {
            // Substitute System.Console.WriteLine("Heater is off");
            // With HeaterIsOff = true;
            HeaterIsOff = true;
        }

        public bool RunSelfTest()
        {
            return true;
        }
    }
}