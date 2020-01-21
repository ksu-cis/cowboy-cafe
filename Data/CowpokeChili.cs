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
        /// If the chili is topped with cheese
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
            set { tortillaStrips = false; }
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
        /// The ingredients of the chili
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                var ingredients = new List<string> ()
                {
                    "beef",
                    "pinto beans",
                    "vegetable stock",
                    "tomato sauce",
                    "onion",
                    "spices"
                };

                if (cheese) ingredients.Add("cheese");
                if (sourCream) ingredients.Add("sour cream");
                if (greenOnions) ingredients.Add("green onions");
                if (tortillaStrips) ingredients.Add("tortilla strips");
                
                return ingredients;
            }
        }
    }
}

