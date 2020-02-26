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
        /// 
        /// </summary>
        private static uint lastOrderNumber;

        /// <summary>
        /// 
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal => 0;

        /// <summary>
        /// 
        /// </summary>
        public uint OrderNumber { get; }

        public double Price => throw new NotImplementedException();

        List<string> IOrderItem.SpecialInstructions => throw new NotImplementedException();

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void Remove(IOrderItem item)
        {
            items.Remove(item);
        }
    }
}
