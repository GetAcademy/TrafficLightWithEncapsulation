﻿namespace TrafficLightWithEncapsulation.Demo2WithOO
{
    internal class Demo2
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
            }
        }
    }
}