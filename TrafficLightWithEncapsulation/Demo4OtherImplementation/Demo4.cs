namespace TrafficLightWithEncapsulation.Demo4OtherImplementation
{
    internal class Demo4
    {
        public static void Run()
        {
            var trafficLight = new TrafficLight();
            //trafficLight.green = true;
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
