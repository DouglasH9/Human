namespace HumanProj
{
        public class Human
        {
            // Fields for Human
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
            public int Health
            {
                get {return health; }
            }
            
            public Human(string name, int strength, int intelligence, int dexterity)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                health = 100;
            }

            public Human(string name, int str, int intel, int dex, int healthAmnt)
            {
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = healthAmnt;
            }
            
            public int Attack(Human target)
            {
                int dmg = Strength * 5;
                target.health -= dmg;
                return target.health;
            }
            
        }
}
