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
    }
}
