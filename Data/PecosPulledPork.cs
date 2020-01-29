using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class Pecos_Pulled_Pork
    {
        /// <summary>
        /// If Pulled Pork has bread
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If Pulled Pork has pickle
        /// </summary>
        private bool pickle = true;

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

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");
                return instructions;
            }
        }
    }
}
