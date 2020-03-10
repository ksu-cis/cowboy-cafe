using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {
        private Size size = Size.Small;
        public override Size Size { get { return size; } set { size = value; NotifyPropertyChange("Size"); } }

        private SodaFlavor flavor = SodaFlavor.CreamSoda;
        /// <summary>
        /// gets flavor of soda
        /// </summary>
        public SodaFlavor Flavor { get { return flavor; } set { flavor = value; NotifyPropertyChange("Flavor"); } }

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
            if (Size == Size.Small)
            {
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Small Cream Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Small Orange Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Small Sarsparilla" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Small Birch Beer" + " Jerked Soda";
                }
                else
                {
                    return "Small Root Beer" + " Jerked Soda";
                }
            }
            else if (Size == Size.Medium)
            {
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Medium Cream Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Medium Orange Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Medium Sarsparilla" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Medium Birch Beer" + " Jerked Soda";
                }
                else
                {
                    return "Medium Root Beer" + " Jerked Soda";
                }
            }
            else
            {
                if (Flavor == SodaFlavor.CreamSoda)
                {
                    return "Large Cream Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.OrangeSoda)
                {
                    return "Large Orange Soda" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.Sarsparilla)
                {
                    return "Large Sarsparilla" + " Jerked Soda";
                }
                else if (Flavor == SodaFlavor.BirchBeer)
                {
                    return "Large Birch Beer" + " Jerked Soda";
                }
                else
                {
                    return "Large Root Beer" + " Jerked Soda";
                }
            }
           
            
        }
    }
}
