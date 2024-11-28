namespace TrafficLightWithEncapsulation.Demo5Properties
{
    internal class Demo5
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
                //Console.WriteLine(trafficLight._phase);
                //trafficLight.Phase = 7;
            }
        }
    }
}
