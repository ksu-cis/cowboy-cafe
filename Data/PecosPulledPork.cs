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
    public class PecosPulledPork : Entree
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
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the pulled pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold Pickle");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  "Pecos Pulled Pork";
        }
    }
}
