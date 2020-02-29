using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class TexasTripleBurger : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;
        private bool bacon = true;
        private bool egg = true;

        /// <summary>
        /// constructor
        /// </summary>
        public TexasTripleBurger()
        {
            price = 6.45;
            calories = 698;
        }
    }
}
