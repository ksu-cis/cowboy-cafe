/*
 * Mohamed Khalil
 * 01/31/2020
 * Angry Chicken
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken
    {
        /// <summary>
        /// If chicken has Bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If chicken has Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

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

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold Pickle");        
                return instructions;
            }
        }
    }
}
