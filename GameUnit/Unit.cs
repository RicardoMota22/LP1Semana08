using System;
using Humanizer;
using System.Globalization;

namespace GameUnit
{
    public abstract class Unit
    {
        private readonly int Movement;
        public virtual int Health { get; set; }
        //fica virtual para poder ser sobreposto nas classes derivadas
        
        public Unit(int movement, int health)
        {
            this.Movement = movement;
            Health = health;
        }
        public void Move(int movement)
        {
            //Coverts int spaces to roman numerals
            Console.WriteLine($"Unidade moveu {movement.ToRoman()}");
        }

        public abstract float Cost{get;} // Propriedade read only

        //making cost 2dp
        public string Newcost()
        {
            return Cost.ToString("F2",CultureInfo.InvariantCulture);
        }
        

        public override string ToString()
        {
            return $"{this.GetType().Name}: HP={Health}"+
            $" COST={Newcost()} ";
        }

        
    }
}
