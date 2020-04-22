using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem
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
        /// protected backing variables
        /// </summary>
        protected double price;
        protected uint calories;


        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price { get => price; }

        /// <summary>
        /// The number of calories in the entree
        /// </summary>
        public uint Calories { get => calories; }

        /// <summary>
        /// gets special prep instructions
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// returns a text representation of the entree
        /// </summary>
        /// <returns>Name of entree</returns>
        public override abstract string ToString();
    }
}
