using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class TrailBurger
    {
        /// <summary>
        /// If Burger has ketchup
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If Burger has pickle
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If Burger has cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If Burger has mustard
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// The price of the Burger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }
    }
}
