namespace ECS.Legacy
{
    public interface IHeater
    {
        //Implements abstract function TurnOn
        public abstract void TurnOn();

        //Implements abstract function TurnOff
        public abstract void TurnOff();

        //Implements abstract function RunSelfTest
        public abstract bool RunSelfTest();
    }
}