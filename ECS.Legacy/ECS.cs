namespace ECS.Legacy
{
    public class ECS
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;   //Uses Interface instead of class directly
        private readonly IHeater _heater;           //Uses Interface instead of class directly

        //Constructor which uses constructor injection
        public ECS(int thr, ITempSensor Temp, IHeater Heat)
        {
            SetThreshold(thr);
            _tempSensor = Temp;
            _heater = Heat;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
