using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem ,INotifyPropertyChanged
    {
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        /// <summary>
        /// ID of previous order
        /// </summary>
        private static uint lastOrderNumber;

        /// <summary>
        /// List of current ordered items
        /// </summary>
        public List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// total of prices of dishes in order
        /// </summary>
        public double Subtotal => 0;

        /// <summary>
        /// ID of the order
        /// </summary>
        public uint OrderNumber { get; }

        /// <summary>
        /// Price of dish
        /// </summary>
        public double Price => throw new NotImplementedException();

        /// <summary>
        /// Special food intructions
        /// </summary>
        List<string> IOrderItem.SpecialInstructions => throw new NotImplementedException();

        /// <summary>
        /// Event handler to trigger when items or subtotal is updated
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// updates bound data properties when changed
        /// </summary>
        private void NotifyPropertyChanged(IOrderItem items, double Subtotal)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(items.ToString()));
                PropertyChanged(this, new PropertyChangedEventArgs(Subtotal.ToString()));
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">To be added from the menu</param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// Removes item from an order
        /// </summary>
        /// <param name="item">From the order menu</param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }
    }
}
