using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger : Entree
    {
        /// <summary>
        /// private backing variables for optional ingredients
        /// </summary>
        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;


        /// <summary>
        /// does the burgar have a bun
        /// </summary>
        public bool Bun
        {
            get { return bun; }
            set 
            { 
                bun = value;
                NotifyOfPropertyChange("Bun");
            }
        }

        /// <summary>
        /// does the burgar have katchup?
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            { 
                ketchup = value;
                NotifyOfPropertyChange("Kethcup");
            }
        }

        /// <summary>
        /// does the burgar have mustard?
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set 
            { 
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        /// <summary>
        /// chic-fil-a doesn't let them touch. Do you?
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set 
            { 
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        /// <summary>
        /// does it got cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set 
            { 
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }

        /// <summary>
        /// is there a tomaot on the burg
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set 
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        /// <summary>
        /// is there saled in my burgre?
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set 
            { 
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        /// <summary>
        /// mayo is nasty
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set 
            { 
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
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
                if (!tomato) s.Add("hold tomato");
                if (!lettuce) s.Add("hold lettuce");
                if (!mayo) s.Add("hold mayo");

                return s;
            }
        }

        public DakotaDoubleBurger()
        {
            price = 5.20;
            calories = 464;
        }

        /// <summary>
        /// returns a text representation of the entree
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}