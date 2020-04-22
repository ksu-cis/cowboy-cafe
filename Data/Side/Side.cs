using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem
    {
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Notifies the data binding stuff when something changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            PropertyChanged.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// protected backing variable for size
        /// </summary>
        protected Size size = Size.Small;

        /// <summary>
        /// array of possable prices 
        /// small = [0]
        /// medium = [1]
        /// large = [2]
        /// </summary>
        protected double[] prices;

        /// <summary>
        /// array of possable calorie values 
        /// small = [0]
        /// medium = [1]
        /// large = [2]
        /// </summary>
        protected uint[] calories;

        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { get => size ; set => size = value ; }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public double Price { get => prices[(int)size]; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public uint Calories { get => calories[(int)size]; }

        /// <summary>
        /// list of specail instrucions for the chefs to make the fud
        /// </summary>
        public virtual List<string> SpecialInstructions { get => new List<string>(); }

    }
}
