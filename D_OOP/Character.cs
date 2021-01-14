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
        public int Health = 100;

        public void Hit(int damage)
        {
            Health -= damage;
        }
    }
}
