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
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
            var order = new Order();
            DataContext = order;
        }

        /// <summary>
        /// Swaps between screens
        /// </summary>
        /// <param name="element"></param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }

        /// <summary>
        /// Transitions to Transaction control
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrder_Click(object sender, RoutedEventArgs e)
        {
            Order o = (Order)DataContext;
            IOrderItem[] io = (IOrderItem[])o.Items;
            if (io.Length != 0)
            {
                MainWindow mw = this.FindAncestor<MainWindow>();
                mw.Container.Child = new TransactionControl(o);
            }
        }

        /// <summary>
        /// Cancels current order and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }

        /// <summary>
        /// Returns to item select
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ItemSelect_Click(object sender, RoutedEventArgs e)
        {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Notifies property change
        /// </summary>
        public void ChangeSize()
        {
            if(DataContext is Order x)
            {
                x.NotifyPropertyChanged();
            }
        }

    }
}
