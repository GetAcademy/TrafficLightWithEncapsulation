namespace TrafficLightWithEncapsulation.Demo4OtherImplementation
{
    internal class TrafficLight
    {
        private int _phase;

        public void SetPhase(int phase)
        {
            if (phase >= 0 && phase <= 3)
            {
                _phase = phase;
            }
        }

        public void Show()
        {
            var red = _phase < 2;
            var yellow = _phase is 1 or 3;
            //var yellow = _phase % 2 == 1;
            var green = _phase == 2;
            TrafficLightConsole.Show(red, yellow, green);
        }

        public void GoToNextPhase()
        {
            _phase++;
            if (_phase == 4)
            {
                _phase = 0;
            }
            //_phase = _phase < 3 ? _phase + 1 : 0;
            //_phase = (_phase + 1) % 4;
        }
    }
}
