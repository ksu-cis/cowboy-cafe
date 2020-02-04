/*
 * Mohamed Khalil
 * 01/31/2020
 * CowPoke chili
 */
using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili
    {
        private bool cheese = true;
        /// <summary>
        /// If the chili is topped with Cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        private bool sourCream = true;
        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream
        {
            get { return sourCream; }
            set { sourCream = value; }
        }

        private bool greenOnions = true;
        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions
        {
            get { return greenOnions; }
            set { greenOnions = value; }
        }

        private bool tortillaStrips = true;
        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips
        {
            get { return tortillaStrips; }
            set { tortillaStrips = value; }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public double Price
        {
            get
            {
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!cheese) instructions.Add("hold Cheese");
                if (!sourCream) instructions.Add("hold sour cream");
                if (!greenOnions) instructions.Add("hold green onions");
                if (!tortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }
    }
}

