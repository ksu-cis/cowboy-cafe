/*
 * Mohamed Khalil
 * 02/05/2020
 * Entrees
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public abstract class Entree : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets calories of dish
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets Price of dish
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets special instructions of dish
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        protected void NotifyPropertyChange(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
