using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    public interface IOrderItem : INotifyPropertyChanged
    {
        /// <summary>
        /// price of the order item before taxes
        /// </summary>
        double Price { get; }

        /// <summary>
        /// special preperation instructions for cheif
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
