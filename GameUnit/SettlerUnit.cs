using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameUnit
{
    public class SettlerUnit : Unit
    {
        public override float Cost { get => 5;}
        public SettlerUnit() : base(1, 3) //Constructor, uses move and health and
        //changes values
        {
        }
    }
}