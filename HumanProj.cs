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
            }

            public Human(string name, int strength, int intelligence, int dexterity, int healthAmnt)
            {
                Name = name;
                Strength = strength;
                Intelligence = intelligence;
                Dexterity = dexterity;
                health = healthAmnt;
            }
            
            public int Attack(Human target)
            {
                target.health -= 5 * Human.Strength;
            }
            
        }
}
