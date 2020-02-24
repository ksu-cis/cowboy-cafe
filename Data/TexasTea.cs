using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea : Drink
    {
        /// <summary>
        /// Mkaes drink sweet or unsweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// Checks whether to dd lemon or not
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Gets price of tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                        break;
                    case (Size.Medium):
                        return 1.50;
                        break;
                    case (Size.Large):
                        return 2.00;
                        break;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets calories of tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                if (Sweet)
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 10;
                            break;
                        case (Size.Medium):
                            return 22;
                            break;
                        case (Size.Large):
                            return 36;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case (Size.Small):
                            return 5;
                            break;
                        case (Size.Medium):
                            return 11;
                            break;
                        case (Size.Large):
                            return 18;
                            break;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        /// <summary>
        /// gets special instructions for tea
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
            if (Sweet)
            {
                return Size.ToString() + " Texas Sweet Tea";
            }
            else
            {
                return Size.ToString() + " Texas Plain Tea";
            }
        }
    }
}
