using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// protected backing variables
        /// </summary>
        protected Size size = Size.Small;
        protected bool ice = true;

        /// <summary>
        /// array of possable prices 
        /// small = [0]
        /// medium = [1]
        /// large = [2]
        /// </summary>
        protected double[] prices;

        /// <summary>
        /// array of possable calorie values 
        /// small = [0]
        /// medium = [1]
        /// large = [2]
        /// </summary>
        protected uint[] calories;

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get => size; set => size = value; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public virtual double Price { get => prices[(int)size]; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public virtual uint Calories { get => calories[(int)size]; }

        /// <summary>
        /// does this DRANK have ice?
        /// </summary>
        public bool Ice { get => ice; set => ice = value; }

        /// <summary>
        /// gets special prep instructions for the drank
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
