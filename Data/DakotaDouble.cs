/*
 * Mohamed Khalil
 * 01/31/2020
 * Dakota Double
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class DakotaDoubleBurger : Entree
    {
        private bool bun = true;
        /// <summary>
        /// If Burger has Bun
        /// </summary>
        public bool Bun { 
            get { return bun; } 
            set 
            {
                bun = value;
                NotifyPropertyChange("Bun");
            } 
        }

        private bool tomato = true;
        /// <summary>
        /// If Burger has Tomato
        /// </summary>
        public bool Tomato { get { return tomato; } set { tomato = value; NotifyPropertyChange("Tomato"); } }

        private bool lettuce = true;
        /// <summary>
        /// If Burger has Lettuce
        /// </summary>
        public bool Lettuce { get { return lettuce; } set { lettuce = value; NotifyPropertyChange("Lettuce"); } }

        private bool mayo = true;
        /// <summary>
        /// If Burger has Mayo
        /// </summary>
        public bool Mayo { get { return mayo; } set { mayo = value; NotifyPropertyChange("Mayo"); } }

        private bool ketchup = true;
        /// <summary>
        /// If Burger has Ketchup
        /// </summary>
        public bool Ketchup { get { return ketchup; } set { ketchup = value; NotifyPropertyChange("Ketchup"); } }

        private bool pickle = true;
        /// <summary>
        /// If Burger has Pickle
        /// </summary>
        public bool Pickle { get { return pickle; } set { pickle = value; NotifyPropertyChange("Pickle"); } }

        private bool cheese = true;
        /// <summary>
        /// If Burger has Cheese
        /// </summary>
        public bool Cheese { get { return cheese; } set { cheese = value; NotifyPropertyChange("Cheese"); } }

        private bool mustard = true;
        /// <summary>
        /// If Burger has Mustard
        /// </summary>
        public bool Mustard { get { return mustard; } set { mustard = value; NotifyPropertyChange("Mustard"); } }

        /// <summary>
        /// The price of the Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// The calories of the Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Tomato) instructions.Add("hold Tomato");
                if (!Lettuce) instructions.Add("hold Lettuce");
                if (!Mayo) instructions.Add("hold Mayo");
                if (!Ketchup) instructions.Add("hold Ketchup");
                if (!Mustard) instructions.Add("hold Mustard");
                if (!Pickle) instructions.Add("hold Pickle");
                if (!Cheese) instructions.Add("hold Cheese");
                if (!Bun) instructions.Add("hold bun");
                return instructions;
            }
        }

        public override Size Size => throw new NotImplementedException();

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Dakota Double Burger";
        }
    }
}
