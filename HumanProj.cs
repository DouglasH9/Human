using System;
using System.Collections.Generic;

namespace HumanProj
{
    public class Human
        {
            public string Name;
            public int Strength;
            public int Intelligence;
            public int Dexterity;
            private int health;
             
            public int Health
            {
                get { return health; }
            }
             
            public Human(string name)
            {
                Name = name;
                Strength = 3;
                Intelligence = 3;
                Dexterity = 3;
                health = 100;
            }
             
            public Human(string name, int str, int intel, int dex, int hp)
            {
                Name = name;
                Strength = str;
                Intelligence = intel;
                Dexterity = dex;
                health = hp;
            }
             
            // Build Attack method
            public virtual int Attack(Human target)
            {
                int dmg = Strength * 3;
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }

            public virtual int Attack(Human target, int dmg)
            {
                target.health -= dmg;
                Console.WriteLine($"{Name} attacked {target.Name} for {dmg} damage!");
                return target.health;
            }
        }

    public class Wizard : Human
    {
        public Wizard(string name) : base(name, 3, 25, 3, 50){}
        public override int Attack(Human target)
        {
            int dished = base.Attack(target, Intelligence * 5);
            target.health -= dished;
            return dished;
        }
    }
    public class Ninja : Human
    {
        public Ninja(string name) : base(name, 3, 3, 175, 100){}
        public override int Attack(Human target)
        {
            Random rand = new Random();
            int dished = base.Attack(target, Dexterity * 5);
            if (rand.Next(100) <= 20)
            {
                dished += 10;
            }
            target.health -= dished;
            return dished;
        }
    }
    public class Samurai : Human
    {
        public Samurai(string name) : base(name, 3, 3, 3, 200){}
    }
}
