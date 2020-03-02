using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// order number from previous number i think...
        /// </summary>
        private uint lastOrderNumber;
        
        /// <summary>
        /// backing variable for Items property
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of all items in the order
        /// </summary>
        public IEnumerable<IOrderItem> Items { get => items; }

        /// <summary>
        /// total price of all items on the order (before taxes)
        /// </summary>
        public double Subtotal
        {
            get
            {
                double subtotal = 0;
                foreach(IOrderItem item in items)
                {
                    subtotal += item.Price;
                }
                return subtotal;
            }
        }

        /// <summary>
        /// adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// removes an item from the order
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }

        /// <summary>
        /// updates stuff when the order is updated.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
