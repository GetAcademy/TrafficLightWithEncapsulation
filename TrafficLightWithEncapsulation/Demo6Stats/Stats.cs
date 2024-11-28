namespace TrafficLightWithEncapsulation.Demo6Stats
{
    internal class Stats
    {
        private int _sum;
        private int _n;

        public void AddNumber(int number)
        {
            _n++;
            _sum += number;
        }

        public void Show()
        {
            if (_n > 0)
            {
                Console.WriteLine($"Sum: {_sum} Snitt: {_sum / _n} Ant tall: {_n}");
            }
            else
            {
                Console.WriteLine($"Sum: 0 Ant tall: 0");
            }
        }
    }
}
