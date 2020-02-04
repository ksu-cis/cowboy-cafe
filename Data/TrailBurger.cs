/*
 * Mohamed Khalil
 * 01/31/2020
 * TrailBurger
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger
    {
        /// <summary>
        /// If Burger has Bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If Burger has Ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If Burger has Pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If Burger has Cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If Burger has Mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

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

                if (!Ketchup) instructions.Add("hold Ketchup");
                if (!Mustard) instructions.Add("hold Mustard");
                if (!Pickle) instructions.Add("hold Pickle");
                if (!Cheese) instructions.Add("hold Cheese");
                if (!Bun) instructions.Add("hold bun");
                return instructions;
            }
        }
    }
}
