namespace TrafficLightWithEncapsulation.Demo2WithOO
{
    internal class TrafficLight
    {
        bool red;
        bool yellow;
        bool green;

        public TrafficLight()
        {
            red = true;
        }

        public void Show()
        {
            TrafficLightConsole.Show(red, yellow, green);
        }

        public void GoToNextPhase()
        {
            if (red && !yellow)
            {
                yellow = true;
            }
            else if (red)
            {
                red = false;
                yellow = false;
                green = true;
            }
            else if (green)
            {
                green = false;
                yellow = true;
            }
            else if (yellow)
            {
                yellow = false;
                red = true;
            }
        }
    }
}
