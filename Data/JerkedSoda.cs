using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        /// <summary>
        /// gets flavor of soda
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Gtes price of jerked soda
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
                        return 2.10;
                        break;
                    case (Size.Large):
                        return 2.59;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets calories of jerked soda
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                        break;
                    case (Size.Medium):
                        return 146;
                        break;
                    case (Size.Large):
                        return 198;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets special instructions for jerked soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Overrides to string method in order control
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            if(Flavor == SodaFlavor.CreamSoda)
            {
                return Size.ToString() + " Cream Soda" + " Jerked Soda";
            }
            else if (Flavor == SodaFlavor.OrangeSoda)
            {
                return Size.ToString() + " Orange Soda" + " Jerked Soda";
            }
            else if (Flavor == SodaFlavor.Sarsparilla)
            {
                return Size.ToString() + " Sarsparilla" + " Jerked Soda";
            }
            else if (Flavor == SodaFlavor.BirchBeer)
            {
                return Size.ToString() + " Birch Beer" + " Jerked Soda";
            }
            else
            {
                return Size.ToString() + " Root Beer" + " Jerked Soda";
            }
            
        }
    }
}
