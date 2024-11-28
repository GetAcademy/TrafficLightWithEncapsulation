namespace TrafficLightWithEncapsulation.Demo7Clicker
{
    internal class Clicker
    {
        public int Points { get; private set; }
        private int _upgrades;
        private char _character;

        public Clicker(char character)
        {
            _upgrades = 1;
            _character = character;
        }

        public void Show()
        {
            Console.WriteLine($"Klikker {char.ToUpper(_character)}: Du har {Points} poeng. ({_character}=klikk, {char.ToUpper(_character)}=upgrade)");
        }

        public void HandleCommand(ConsoleKeyInfo cmdKey)
        {
            if (cmdKey.KeyChar == _character)
            {
                Points += _upgrades;
            }
            else if (cmdKey.KeyChar == char.ToUpper(_character))
            {
                if (Points >= 10)
                {
                    _upgrades++;
                    Points -= 10;
                }
            }
        }
    }
}
