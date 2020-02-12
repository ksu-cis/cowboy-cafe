using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class DrinkBase
    {
        /// <summary>
        /// 
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// 
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// 
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// 
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
