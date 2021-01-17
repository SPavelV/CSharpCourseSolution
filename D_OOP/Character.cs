using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Character
    {
        public int Health { get; private set; } = 100;

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            //Health = GetHealth() - damage;
            Health -= damage;
        }
    }
}
  