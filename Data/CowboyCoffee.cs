using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        private bool ice = false;
        /// <summary>
        /// Checks to see if there is Ice
        /// </summary>
        public override bool Ice { get { return ice; } set { ice = value; NotifyPropertyChange("Ice"); } }

        private bool decaf;
        /// <summary>
        /// Checks to see if coffee is decaf or regular
        /// </summary>
        public bool Decaf { get { return decaf; } set { decaf = value; NotifyPropertyChange("Decaf"); } }

        private bool roomforcream = false;
        /// <summary>
        /// Checks to see if there is room for cream
        /// </summary>
        public bool RoomForCream { get { return roomforcream; } set { roomforcream = value; NotifyPropertyChange("RoomForCream"); } }

        /// <summary>
        /// Gtes price of coffe
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 0.60;
                        break;
                    case (Size.Medium):
                        return 1.10;
                        break;
                    case (Size.Large):
                        return 1.60;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets calories of coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                        break;
                    case (Size.Medium):
                        return 5;
                        break;
                    case (Size.Large):
                        return 7;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// gets special instructions for coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if (!Decaf)
            {
                if (Size == Size.Small)
                {
                    return "Small Cowboy Coffee";
                }
                else if (Size == Size.Medium)
                {
                    return "Medium Cowboy Coffee";
                }
                else
                {
                    return "Large Cowboy Coffee";
                }
            }
            else
            {
                if (Size == Size.Small)
                {
                    return "Small Decaf Cowboy Coffee";
                }
                else if (Size == Size.Medium)
                {
                    return "Medium Decaf Cowboy Coffee";
                }
                else
                {
                    return "Large Decaf Cowboy Coffee";
                }
            }
        }
    }
}
