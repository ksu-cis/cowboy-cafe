/*
 * Mohamed Khalil
 * 01/31/2020
 * Dakota Double
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// If Burger has Bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If Burger has Tomato
        /// </summary>
        public bool Tomato { get; set; } = true;

        /// <summary>
        /// If Burger has Lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If Burger has Mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

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
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Tomato) instructions.Add("hold Tomato");
                if (!Lettuce) instructions.Add("hold Lettuce");
                if (!Mayo) instructions.Add("hold Mayo");
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
