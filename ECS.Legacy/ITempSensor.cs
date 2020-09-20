namespace ECS.Legacy
{
    //Implements interface
    public interface ITempSensor
    {
        //Implements abstract function GetTemp
        public abstract int GetTemp();

        //Implements abstract function RunSelfTest
        public abstract bool RunSelfTest();
    }
}