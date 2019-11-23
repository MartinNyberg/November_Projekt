using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt
{
    class Fighter
    {
        private int hp = 1000;

        public string name = "";

        public string GiveName()
        {
            name = Console.ReadLine();
            Console.WriteLine("Du gav namnet " + name);

            return name;
        }


        //random generatorn för dmg
        public virtual int Attack()
        {
            Random generator = new Random();
            int damage = generator.Next(250, 600);

            return damage;
        }

        //Hurtmetoden drar hp och gör så hp inte går under 0
        public void Hurt(int amount)
        {
            hp = hp - amount;
            Console.WriteLine(name + " tog " + amount + " skada.");
            if (hp < 0)
            {
                hp = 0;
            }

        }

        //skriver current hp
        public int GetHp()
        {
            Console.WriteLine(name + " har nu " + hp + "hp kvar.");

            return hp;
        }

        //kollar om man lever eller inte
        public bool isAlive()
        {
            bool alive = false;

            if (hp >= 1)
            {
                alive = true;
            }

            return alive;
        }


    }
}
