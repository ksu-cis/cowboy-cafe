/*
 * Mohamed Khalil
 * 02/05/2020
 * Corn Dodgers
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CornDodgers : Side
    {
        /// <summary>
        /// Gets calories of Corn Dodgers based on size of side dish
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 512;
                        break;
                    case (Size.Medium):
                        return 685;
                        break;
                    case (Size.Large):
                        return 717;
                        break;
                    default:
                        throw new NotImplementedException();
                }

            }
        }

        /// <summary>
        /// Gets price of Corn Dodgers based on size of side dish
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
            return Size.ToString() + "Corn Dodgers ";
        }
    }
}
