using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Entree
    {
        /// <summary>
        /// protected backing variables
        /// </summary>
        protected double price;
        protected uint calories;


        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price { get => price; }

        /// <summary>
        /// The number of calories in the entree
        /// </summary>
        public uint Calories { get => calories; }

        /// <summary>
        /// gets special prep instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// returns a text representation of the entree
        /// </summary>
        /// <returns>Name of entree</returns>
        public override abstract string ToString();
    }
}
