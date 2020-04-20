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

        /// <summary>
        /// Gets calories
        /// </summary>
        uint Calories { get; }

        /// <summary>
        /// Gets size
        /// </summary>
        Size Size { get; set; }
    }
}
