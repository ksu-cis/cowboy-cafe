using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        private bool roomForCream = false;
        private bool decaf = false;

        /// <summary>
        /// gets and sets if the coffee should leave room for cream
        /// </summary>
        public bool RoomForCream { get => roomForCream; set => roomForCream = value; }


        public bool Decaf { get => decaf; set => decaf = value; }

        /// <summary>
        /// special prep instructions for the covfefe
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> special = new List<string>();
                if (ice) special.Add("Add Ice");
                if (roomForCream) special.Add("Room for Cream");
                return special;
            }
        }

        /// <summary>
        /// covfefe constructor
        /// </summary>
        public CowboyCoffee()
        {
            prices = new double[] { 0.60, 1.10, 1.60 };
            calories = new uint[] { 3, 5, 7 };
            //unlike all other drinks, ice not included by default
            ice = false;
        }

        /// <summary>
        /// gives a string representation of the item
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string s = size.ToString();
            if (decaf) s += " Decaf";
            return s + " Cowboy Coffee";
        }
    }
}
