using System;
using Humanizer;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int movement;
        public virtual int Health { get; set; }
        //fica virtual para poder ser sobreposto nas classes derivadas

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
        public void Move(int spaces)
        {
            //Coverts int spaces to roman numerals
            Console.WriteLine($"Unidade moveu {spaces.ToRoman()}");
        }

        public abstract float Cost{get;} // Propriedade read only
        
    }
}
