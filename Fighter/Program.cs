using System;

namespace Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter[] fighters = { new Fighter("John", 500, 50, 0), new Fighter("Mark", 250, 20, 25), new Fighter("Alex", 150, 100, 10), new Fighter("Nick", 300, 30, 10) };

            int FighterIndex;

            for (int i = 0; i < fighters.Length; i++)
            {
                Console.Write((i + 1) + " ");
                fighters[i].ShowStats();
            }

            Console.WriteLine("Оберіть борца червоного кутка: ");
            FighterIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter redFighter = fighters[FighterIndex];

            Console.WriteLine("Оберіть борца синього кутка: ");
            FighterIndex = Convert.ToInt32(Console.ReadLine()) - 1;
            Fighter blueFighter = fighters[FighterIndex];

            while (redFighter.Health > 0 && blueFighter.Health > 0)
            {
                redFighter.TakeDamage(redFighter.Damage);
                blueFighter.TakeDamage(blueFighter.Damage);

                Console.WriteLine();
                redFighter.ShowStats();
                blueFighter.ShowStats();
            }
            Console.ReadKey();
        }
    }


    class Fighter
    {
        private string _name;
        private int _health;
        private int _damage;
        private int _armor;

        public int Health
        {
            get
            {
                return _health;
            }
        }

        public int Damage
        {
            get
            {
                return _damage;
            }
        }

        public Fighter(string name, int health, int damage, int armor)
        {
            _name = name;
            _health = health;
            _damage = damage;
            _armor = armor;
        }

        public void ShowStats()
        {
            Console.WriteLine(_name + " HP- " + _health + " DMG- " + _damage + " ARMOR- " + _armor);
        }

        public void TakeDamage(int damage)
        {
            _health -= damage - _armor;
        }
    }

}