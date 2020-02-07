using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
    {
        /// <summary>
        /// initializes the values for the prices of various sizes
        /// </summary>
        public PanDeCampo()
        {
            prices = new double[] { 1.59, 1.79, 1.99 };
            calories = new uint[] { 227, 269, 367 };
        }
    }
}
