using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public partial class Entree
    {
        protected double price;
        protected uint calories;

        /// <summary>
        /// public getters and private setters
        /// </summary>
        public double Price { get => price; }
        public uint Calories { get => calories; }
        public virtual List<string> SpecialInstructions { get; private set; }
    }
}
