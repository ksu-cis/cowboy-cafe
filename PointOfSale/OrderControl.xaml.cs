using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl, INotifyPropertyChanged
    {
        private int orderNumber = 1;

        public Order currentOrder;

        public OrderControl()
        {
            currentOrder = new Order(orderNumber);
            this.DataContext = currentOrder;
            InitializeComponent();
        }

        /// <summary>
        /// does nothing (yet......)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelectionButtonClick(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// replaces the current order with a blank one of the same ID number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            orderNumber++;
            this.DataContext = new Order(orderNumber);
        }

        /// <summary>
        /// Moves on the the next order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            orderNumber++;
            this.DataContext = new Order(orderNumber);
        }

        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }


        /// <summary>
        /// updates stuff when the order is updated.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}