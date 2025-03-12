using System;
using System.Globalization;

namespace DesafioCombate
{
    class Champion
    {
        public string Name { get; private set; }
        public int Life { get; private set; }
        public int Attack { get; private set; }
        public int Armor { get; private set; }

        public Champion(string name, int life, int damage, int armor)
        {
            Name = name;
            Life = life;
            Attack = damage;
            Armor = armor;
        }

        public void TakeDamage (Champion other)
        {
            if (other.Life < Attack)
            {
                other.Life = 0;
            }
            else if (other.Armor >= Attack)
            {
                other.Life -= 1;
            }
            else
            {
                other.Life -= Attack - other.Armor;
            }

        }

        public string Status()
        {
            if(Life == 0)
            {
                return $"{Name}: {Life} de vida (morreu)";
            }
            
            return $"{Name}: {Life} de vida";
        }

    }
}
