namespace TrafficLightWithEncapsulation.Demo3WithEncapsulation
{
    internal class TrafficLight
    {
        private bool _red;
        private bool _yellow;
        private bool _green;

        public TrafficLight()
        {
            _red = true;
        }

        public void Show()
        {
            TrafficLightConsole.Show(_red, _yellow, _green);
        }

        public void GoToNextPhase()
        {
            if (_red && !_yellow)
            {
                _yellow = true;
            }
            else if (_red)
            {
                _red = false;
                _yellow = false;
                _green = true;
            }
            else if (_green)
            {
                _green = false;
                _yellow = true;
            }
            else if (_yellow)
            {
                _yellow = false;
                _red = true;
            }
        }
    }
}
