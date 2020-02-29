using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// constructor
        /// </summary>
        public DakotaDoubleBurger()
        {
            price = 5.20;
            calories = 464;
        }
    }
}
