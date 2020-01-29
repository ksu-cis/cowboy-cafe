using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class AngryChicken
    {
        /// <summary>
        /// If chicken has bread
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If chicken has pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// The price of the Chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the Chicken
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chicken
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");        
                return instructions;
            }
        }
    }
}
