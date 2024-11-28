using System.Text.Json;

namespace TrafficLightWithEncapsulation.Demo7Clicker
{
    internal class Demo7
    {
        public static void Run()
        {
            var clickers = new Clicker[]
            {
                new Clicker('a'),
                new Clicker('b'),
                new Clicker('c'),
                new Clicker('d'),
                new Clicker('e'),
            };
            //clickers[3].Upgrades = 15;
            //clickers[3].Points = 1500;
            while (true)
            {
                Console.Clear();
                foreach (var clicker in clickers)
                {
                    clicker.Show();
                }
                var cmdKey = Console.ReadKey(true);
                foreach (var clicker in clickers)
                {
                    clicker.HandleCommand(cmdKey);
                    if (clicker.Points == 100) break;
                }
            }
        }
    }
}
