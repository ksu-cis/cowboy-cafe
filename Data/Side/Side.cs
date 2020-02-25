﻿using System;
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
        /// protected backing variable for size
        /// </summary>
        protected Size size = Size.Small;

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
        public virtual Size Size { get => size ; set => size = value ; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price { get => prices[(int)size]; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public uint Calories { get => calories[(int)size]; }

        /// <summary>
        /// string representatino of the side
        /// </summary>
        /// <returns></returns>
        public abstract override string ToString();
    }
}
