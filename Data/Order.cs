using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    class Order
    {
        /// <summary>
        /// private backing variables
        /// </summary>
        uint lastOrderNumber = 0;
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// list of items in the order
        /// </summary>
        public List<IOrderItem> Items { get => items; }

        /// <summary>
        /// total price of all items in the order before taxes
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
        /// ID number for the order
        /// </summary>
        public uint OrderNumber { get; }

       
        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// removed an item from the order
        /// </summary>
        /// <param name="item"></param>
        private void Remove(IOrderItem item)
        {
            items.Remove(item);
        }
    }
}
