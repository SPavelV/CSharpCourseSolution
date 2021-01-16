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

        //public int Health
        //{
        //    get
        //    {
        //        return health;
        //    }
        //    private set
        //    {
        //        health = value;
        //    }
        //}

        public int GetHealth()
        {
            return health;
        }

        private void SetHealth(int value)
        {
            health = value;
        }

        public void Hit(int damage)
        {
            if (damage > health)
                damage = health;
            
            health = GetHealth() - damage;
            //Health -= damage;
        }
    }
}
