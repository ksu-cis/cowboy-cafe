/*
 * Mohamed Khalil
 * 02/03/2020
 * ChiliCheeseFries
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class ChiliCheeseFries : Side
    {
        /// <summary>
        /// Gets calories of Chilli Cheese Fries based on size of side dish
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 433;
                        break;
                    case (Size.Medium):
                        return 524;
                        break;
                    case (Size.Large):
                        return 610;
                        break;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Gets price of Chilli Cheese Fries based on size of side dish
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.99;
                        break;
                    case (Size.Medium):
                        return 2.99;
                        break;
                    case (Size.Large):
                        return 3.99;
                        break;
                    default:
                        throw new NotImplementedException();
                }
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
                return "Small Chili Cheese Fries";
            }
            else if (Size == Size.Medium)
            {
                return "Medium Chili Cheese Fries";
            }
            else
            {
                return "Large Chili Cheese Fries";
            }
        }
    }
}
