/*
 * Mohamed Khalil
 * 02/05/2020
 * Baked Beans
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class BakedBeans : Side
    {
        /// <summary>
        /// Gets calories of Baked Beans based on size of side dish
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 312;
                        break;
                    case (Size.Medium):
                        return 378;
                        break;
                    case (Size.Large):
                        return 410;
                        break;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Gets price of Bkaed Beans based on size of side dish
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                        break;
                    case (Size.Medium):
                        return 1.79;
                        break;
                    case (Size.Large):
                        return 1.99;
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
            return Size.ToString() + " Baked Beans";
        }
    }
}
