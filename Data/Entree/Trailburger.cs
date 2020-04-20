using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TrailBurger : Entree
    {
        /// <summary>
        /// private backing variables for optional ingredients
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;

        /// <summary>
        /// does the burgar have a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set { bun = value; }
        }

        /// <summary>
        /// does the burgar have katchup?
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set { ketchup = value; }
        }

        /// <summary>
        /// does the burgar have mustard?
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set { mustard = value; }
        }

        /// <summary>
        /// chic-fil-a doesn't let them touch. Do you?
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        public bool Cheese
        {
            get { return cheese; }
            set { cheese = value; }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> s = new List<string>();

                if (!bun) s.Add("hold bun");
                if (!ketchup) s.Add("hold ketchup");
                if (!mustard) s.Add("hold mustard");
                if (!pickle) s.Add("hold pickle");
                if (!cheese) s.Add("hold cheese");

                return s;
            }
        }

        public TrailBurger()
        {
            price = 4.50;
            calories = 288;
        }

        /// <summary>
        /// returns a text representation of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}