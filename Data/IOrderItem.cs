using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public interface IOrderItem
    {
        /// <summary>
        /// 
        /// </summary>
        double Price { get; }

        /// <summary>
        /// 
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
