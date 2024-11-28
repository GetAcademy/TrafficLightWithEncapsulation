namespace TrafficLightWithEncapsulation.Demo6Stats
{
    internal class Demo6
    {
        public static void Run()
        {
            var stats = new Stats();
            stats.Show();
            stats.AddNumber(10);
            stats.AddNumber(20);
            stats.Show();
        }
    }
}
