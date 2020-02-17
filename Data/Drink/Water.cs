using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// gets and sets if a lemon gets put in en vatten
        /// </summary>
        public bool Lemon { get => lemon; set => lemon = value; }

        /// <summary>
        /// special prep instructions for the h2o
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");
                if (lemon) special.Add("Add Lemon");
                return special;
            }
        }

        /// <summary>
        /// override price getter becasue it's alwasy 0.12
        /// </summary>
        public override double Price { get => 0.12; }

        /// <summary>
        /// override calorie getter because it's always 0
        /// </summary>
        public override uint Calories { get => 0; }
    }
}
