using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// protected backing variables
        /// </summary>
        protected Size size = Size.Small;
        protected double[] prices;
        protected uint[] calories;

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get => size ; set => size = value ; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price { get => prices[(int)size]; }

        /// <summary>
        /// Gets the calories of the entreec
        /// </summary>
        public uint Calories { get => calories[(int)size]; }
    }
}
