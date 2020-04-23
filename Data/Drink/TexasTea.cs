using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool sweet = true;
        private bool lemon = false;

        /// <summary>
        /// gets and sets if the tea is sweet
        /// </summary>
        public bool Sweet 
        {
            get {
                return sweet; 
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Sweet");
            }
        }

        /// <summary>
        /// gets and sets if a lemon gets put in the tea
        /// </summary>
        public bool Lemon {
            get
            {
                return lemon;
            }
            set 
            { 
                lemon = value;
                NotifyOfPropertyChange("Lemon");
            }
        }

        /// <summary>
        /// special prep instructions for the covfefe
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");
                if (!sweet) special.Add("Unsweet");
                if (lemon) special.Add("Add Lemon");
                return special;
            }
        }

        /// <summary>
        /// override calories to return half the normal value 
        /// if the tea isn't sweet
        /// </summary>
        public override uint Calories
        {
            get
            {
                uint cal = base.Calories;
                if (!sweet) cal = cal / 2;
                return cal;
            }
        }

        /// <summary>
        /// tea constructor
        /// </summary>
        public TexasTea()
        {
            prices = new double[] { 1.00, 1.50, 2.00 };
            calories = new uint[] { 10, 22, 36 };
        }

        /// <summary>
        /// gives a string representation of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return size.ToString() + " Texas Tea";
        }
    }
}
