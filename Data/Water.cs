using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Water : Drink, INotifyPropertyChanged
    {
       
        private bool lemon = false;
        /// <summary>
        /// Checks whether to add lemon or not
        /// </summary>
        public bool Lemon { get { return lemon; } set { lemon = value; NotifyPropertyChange("Lemon"); } }

        /// <summary>
        /// Gets price of water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// Gets calories of water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// gets special instructions for water
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (Size == Size.Small)
            {
                return "Small Water";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Water";
            }
            else
            {
                return "Large Water";
            }
        }
    }
}
