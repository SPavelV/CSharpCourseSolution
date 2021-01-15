using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {
        // public
        // internal
        // protected
        private int health = 100;

        public int Health
        {
            get
            {
                return health;
            }
            private set
            {
                health = value;
            }
        }

        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;
            
            //health -= damage;
            Health -= damage;
        }
    }
}
