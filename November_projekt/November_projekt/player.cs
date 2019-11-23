using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace November_projekt
{
    class player : Fighter
    {
        private int hp = + 300;

        private int Mult = 2;

        static int AttackA;

        public override int Attack()
        {
            AttackA = base.Attack();

            AttackA = AttackA * Mult;

            return AttackA;
        }

    }
}
