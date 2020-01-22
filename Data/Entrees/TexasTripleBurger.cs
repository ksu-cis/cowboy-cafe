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

        /// <summary>
        /// hold the bacon
        /// </summary>
        public void HoldBacon()
        {
            bacon = false;
            special.Add("hold bacon");
        }

        public void HoldEgg()
        {
            egg = false;
            special.Add("hold egg");
        }
    }
}
