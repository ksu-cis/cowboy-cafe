using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public abstract class Drink
    {
        /// <summary>
        /// Gets size of drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Gets price of drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets calories of drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Checks to see if drink has ice or not
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Gets special instructons for drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
