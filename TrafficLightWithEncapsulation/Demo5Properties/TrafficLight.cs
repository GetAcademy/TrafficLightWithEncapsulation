namespace TrafficLightWithEncapsulation.Demo5Properties
{
    internal class TrafficLight
    {
        public int Phase { get; private set; }

        //public int Phase
        //{
        //    get
        //    {
        //        return _phase;
        //    }

        //    set
        //    {
        //        if (value >= 0 && value <= 3)
        //        {
        //            _phase = value;
        //        }
        //    }
        //}

        //public void SetPhase(int phase)
        //{
        //    if (phase >= 0 && phase <= 3)
        //    {
        //        _phase = phase;
        //    }
        //}

        public void Show()
        {
            var red = Phase < 2;
            var yellow = Phase is 1 or 3;
            //var yellow = _phase % 2 == 1;
            var green = Phase == 2;
            TrafficLightConsole.Show(red, yellow, green);
        }

        public void GoToNextPhase()
        {
            Phase++;
            if (Phase == 4)
            {
                Phase = 0;
            }
            //_phase = _phase < 3 ? _phase + 1 : 0;
            //_phase = (_phase + 1) % 4;
        }
    }
}
