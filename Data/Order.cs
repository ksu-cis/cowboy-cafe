using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem ,INotifyPropertyChanged
    {
        public Order()
        {
            OrderNumber = lastOrderNumber++;
        }
        public IEnumerable<IOrderItem> Items
        {
            get
            {
                return items.ToArray();
            }
        }

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
        public double Subtotal
        {
            get
            {
                double total = 0;
                foreach(var item in items)
                {
                    total += item.Price;
                }
                return total;
            }
        }

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
        private void NotifyPropertyChanged()
        {
            if(PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">To be added from the menu</param>
        public void Add(IOrderItem item)
        {
            if(item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged += OnItemPropertyChange;
            }
            items.Add(item);
            NotifyPropertyChanged();
        }

        /// <summary>
        /// Removes item from an order
        /// </summary>
        /// <param name="item">From the order menu</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChange;
            }
            items.Remove(item);
            NotifyPropertyChanged();
        }

        /// <summary>
        /// 
        /// </summary>
        private void OnItemPropertyChange(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }

    }
}
