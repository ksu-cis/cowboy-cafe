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

        /// <summary>
        /// tomatos is nasty 
        /// </summary>
        public void HoldTomato()
        {
            tomato = false;
            special.Add("hold tomato");
        }

        /// <summary>
        /// no lefs alllowed
        /// </summary>
        public void HoldLettuce()
        {
            lettuce = false;
            special.Add("hold lettuce");
        }

        /// <summary>
        /// hold my mayo
        /// </summary>
        public void HoldMayo()
        {
            pickle = false;
            special.Add("hold mayo");
        }
    }
}
