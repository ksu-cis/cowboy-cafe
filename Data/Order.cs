using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public class Order : IOrderItem ,INotifyPropertyChanged
    {
        /// <summary>
        /// 
        /// </summary>
        static uint lastOrderNumber;

        /// <summary>
        /// 
        /// </summary>
        List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// 
        /// </summary>
        public double Subtotal { get; }

        /// <summary>
        /// 
        /// </summary>
        public uint OrderNumber { get; }

        public double Price => throw new NotImplementedException();

        public IEnumerable<string> SpecialInstructions => throw new NotImplementedException();

        /// <summary>
        /// 
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {

        }
    }
}
