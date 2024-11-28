namespace TrafficLightWithEncapsulation.Demo7Clicker
{
    internal class Clicker
    {
        private int _points;
        private int _upgrades;
        private char _character;

        public Clicker(char character)
        {
            _upgrades = 1;
            _character = character;
        }

        public void Show()
        {
            Console.WriteLine($"Klikker {char.ToUpper(_character)}: Du har {_points} poeng. ({_character}=klikk, {char.ToUpper(_character)}=upgrade)");
        }

        public void HandleCommand(ConsoleKeyInfo cmdKey)
        {
            if (cmdKey.KeyChar == _character)
            {
                _points += _upgrades;
            }
            else if (cmdKey.KeyChar == char.ToUpper(_character))
            {
                if (_points >= 10)
                {
                    _upgrades++;
                    _points -= 10;
                }
            }
        }
    }
}
