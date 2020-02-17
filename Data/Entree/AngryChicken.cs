using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// Is it really a sammich if it doesn't have bread?
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// chic-fil-a doesn't let them touch. Do you?
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }


        /// <summary>
        /// Special instructions for the preparation of the sammich
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// constructor that sets the price and calorie values
        /// </summary>
        public AngryChicken()
        {
            price = 5.99;
            calories = 190;
        }
    }
}
