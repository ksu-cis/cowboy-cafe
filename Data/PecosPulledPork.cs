/*
 * Mohamed Khalil
 * 01/31/2020
 * PecosPulledPork
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PecosPulledPork
    {
        /// <summary>
        /// If Pulled Pork has Bread
        /// </summary>
        public bool Bread = true;

        /// <summary>
        /// If Pulled Pork has Pickle
        /// </summary>
        public bool Pickle = true;

        /// <summary>
        /// The price of the Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Pulled Pork
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold Pickle");
                return instructions;
            }
        }
    }
}
