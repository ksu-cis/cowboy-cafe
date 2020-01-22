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
        public PecosPulledPork()
        {
            price = 4.50;
            calories = 288;
        }

        /// <summary>
        /// ketchup is nasty 
        /// </summary>
        public void HoldKetchup()
        {
            ketchup = false;
            special.Add("hold ketchup");
        }

        /// <summary>
        /// no mustard alllowed
        /// </summary>
        public void HoldMustard()
        {
            mustard = false;
            special.Add("hold mustard");
        }

        /// <summary>
        /// hold my pickle
        /// </summary>
        public void HoldPickle()
        {
            pickle = false;
            special.Add("hold pickle");
        }

        /// <summary>
        /// no chesesz
        /// </summary>
        public void HoldCheese()
        {
            cheese = false;
            special.Add("hold cheese");
        }
    }
}
