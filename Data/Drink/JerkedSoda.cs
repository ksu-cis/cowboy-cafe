using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// enumerator for the various flavors avalible
    /// </summary>
    public enum SodaFlavor
    {
        CreamSoda,
        OrangeSoda,
        Sarsparilla,
        BirchBeer,
        RootBeer
    }

    public class JerkedSoda : Drink
    {
        /// <summary>
        /// additional private backing variables
        /// </summary>
        private SodaFlavor flavor = SodaFlavor.BirchBeer;

        /// <summary>
        /// gets and sets the flavor of the pop
        /// </summary>
        public SodaFlavor Flavor { get => flavor; set => flavor = value; }

        /// <summary>
        /// gets specail prep instructions for the pop
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> special = new List<string>();
                if (!ice) special.Add("Hold Ice");
                return special;
            }
        }

        /// <summary>
        /// constructor to make a new Jerked Soda
        /// </summary>
        public JerkedSoda()
        {
            prices = new double[] { 1.59, 2.10, 2.59 };
            calories = new uint[] { 110, 146, 198 };
        }
    }
}
