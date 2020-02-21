/*
 * Mohamed Khalil
 * 02/05/2020
 * Pan De Campo
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class PanDeCampo : Side
    {
        /// <summary>
        /// Gets calories of Pan De Campo based on size of side dish
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 227;
                        break;
                    case (Size.Medium):
                        return 269;
                        break;
                    case (Size.Large):
                        return 367;
                        break;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Gets price of Pan De Campo based on size of side dish
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
            return Size.ToString() + " Pan De Campo ";
        }
    }
}
