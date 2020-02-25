using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    interface IOrderItem
    {
        /// <summary>
        /// 
        /// </summary>
        double Price { get; }

        /// <summary>
        /// 
        /// </summary>
        IEnumerable<string> SpecialInstructions { get; }
    }
}
