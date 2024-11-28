namespace TrafficLightWithEncapsulation.Demo3WithEncapsulation
{
    internal class TrafficLightDemo3
    {
        public static void Run()
        {
            var trafficLight = new TrafficLight();
            while (true)
            {
                Console.Clear();
                trafficLight.Show();
                Console.ReadKey(true);
                trafficLight.GoToNextPhase();
                //trafficLight._green = true;                
            }
        }
    }
}
