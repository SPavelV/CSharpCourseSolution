using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    class Character
    {
        int Health = 100;

        void Hit(int damage)
        {
            Health -= damage;
        }
    }
}
