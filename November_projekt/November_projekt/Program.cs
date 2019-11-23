using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter A = new Fighter();
            Fighter B = new Fighter();

            //ger namn åt spelaren
            Console.Write("Välj namne på spelare 1:");
            string namnA = A.GiveName();
            Console.Write("Välj namne på spelare 2:");
            string namnB = B.GiveName();
            Console.WriteLine("Nu börjar kampen!");

            Console.ReadKey();

            bool playerAisAlive = A.isAlive();

            bool playerBisAlive = B.isAlive();

            while (playerAisAlive == true && playerBisAlive == true)
            //Spelare attackerar om båda lever
            {
                playerBisAlive = B.isAlive();
                int attack = A.Attack();
                B.Hurt(attack);
                B.GetHp();
                playerBisAlive = B.isAlive();
                Console.ReadKey();
                attack = B.Attack();

                playerAisAlive = A.isAlive();
                A.Hurt(attack);
                A.GetHp();
                playerAisAlive = A.isAlive();
                Console.ReadKey();
            }

            //Skriver vilekn spelare som vann
            if (playerAisAlive == true && playerBisAlive == false)
            {
                Console.WriteLine(namnA + " vann!");
            }
            else if (playerBisAlive == true && playerAisAlive == false)
            {
                Console.WriteLine(namnB + " vann!");
            }
            else
            {
                Console.WriteLine("oavgjort");
            }

            Console.ReadKey();

        }
    }
}
