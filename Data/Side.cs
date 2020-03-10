/*
 * Mohamed Khalil
 * 02/03/2020
 * Sides
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {
        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size { 
            get
            {
                return size;
            }
            set
            {
                size = value;
                NotifyPropertyChange("Size");
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets special instructions for side
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                return new List<string>();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        //public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="PropertyName"></param>
        protected void NotifyPropertyChange(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
        }
    }
}
