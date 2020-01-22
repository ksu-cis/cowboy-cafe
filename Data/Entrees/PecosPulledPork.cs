using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class PecosPulledPork : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// constructor
        /// </summary>
        public PecosPulledPork()
        {
            price = 5.88;
            calories = 528;
        }

        /// <summary>
        /// holds bread 
        /// </summary>
        public void HoldBread()
        {
            bread = false;
            special.Add("hold bread");
        }

        /// <summary>
        /// no pickles alllowed
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            special.Add("hold pickle");
        }
    }
}
