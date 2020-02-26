using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    interface IOrderItem
    {
        /// <summary>
        /// price of the order item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// specail prep instructions for the chefs
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
