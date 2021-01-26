using System;
using System.Collections.Generic;
using System.Text;

namespace D_OOP
{
    public class Point2d
    {
        private int x;
        private int y;

        public Point2d(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    public class Character
    {
        private int speed;
        public int Health { get; private set; } = 100;

        public Race Race { get; private set; }

        public int Armor { get; private set; }

        public Character(Race race)
        {
            Race = race;

            switch (race)
            {
                case Race.Elf:
                    Armor = 30;
                    break;
                case Race.Ork:
                    Armor = 40;
                    break;
                case Race.Terrain:
                    Armor = 20;
                    break;
                default:
                    throw new AggregateException("Unknown race.");
            }

            if(race == Race.Terrain)
            {
                Armor = 20;
            }
            else if (race == Race.Ork)
            {
                Armor = 40;
            }
            else if(race == Race.Elf)
            {
                Armor = 30;
            }
            else
            {
                throw new AggregateException("Unknown race.");
            }

        }

        public Character(Race race, int armor)
        {
            Race = race;
            Armor = armor;
        }

        //public Character(string race, int armor, int speed)
        //{
        //    Race = race;
        //    Armor = armor;
        //    this.speed = speed;
        //}

        public void Hit(int damage)
        {
            if (damage > Health)
                damage = Health;

            //Health = GetHealth() - damage;
            Health -= damage;
        }

        public int PrintSpeed()
        {
            return speed;
        }

        public void IncreaseSpeed()
        {
            speed += 10;
        }
    }
}
  