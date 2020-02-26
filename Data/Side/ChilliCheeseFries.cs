using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChilliCheeseFries : Side
    {
        /// <summary>
        /// initializes the values for the prices of various sizes
        /// </summary>
        public ChilliCheeseFries()
        {
            prices = new double[] { 1.99, 2.99, 3.99 };
            calories = new uint[] { 433, 524, 610 };
        }

        /// <summary>
        /// side represented by a string
        /// </summary>
        /// <returns>name and size of side</returns>
        public override string ToString()
        {
            return size.ToString() + " Chilli Cheese Fries";
        }
    }
}
