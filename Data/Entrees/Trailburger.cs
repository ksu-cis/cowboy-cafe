using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class Trailburger : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// constructor
        /// </summary>
        public Trailburger()
        {
            price = 4.50;
            calories = 288;
        }
    }
}
