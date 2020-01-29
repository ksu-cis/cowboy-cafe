using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class DakotaDouble
    {
        /// <summary>
        /// If Burger has tomato
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// If Burger has lettuce
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// If Burger has mayo
        /// </summary>
        private bool mayo = true;

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
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 464;
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

                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                return instructions;
            }
        }
    }
}
