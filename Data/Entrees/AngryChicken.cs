using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class AngryChicken : Entree
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool bread = true;
        private bool pickle = true;

        /// <summary>
        /// public property for bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { value = bread; }
        }

        /// <summary>
        /// does the sammich have a pickle?
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { value = pickle; }
        }

        /// <summary>
        /// constructor
        /// </summary>
        public AngryChicken()
        {
            price = 5.99;
            calories = 190;
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> s = new List<string>();
                if (!pickle) s.Add("hold pickle");
                if (!bread) s.Add("hold bread");
                return s;
            }
        }
    }
}
