using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// Gets price of dish
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Gets special instructions
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
