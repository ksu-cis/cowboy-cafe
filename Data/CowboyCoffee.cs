﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : DrinkBase
    {
        /// <summary>
        /// Checks to see if there is room for cream
        /// </summary>
        public bool RoomForCream { get; set; } = false;

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
                if (RoomForCream) instructions.Add("Room for cream");
                return instructions;
            }
        }
    }
}