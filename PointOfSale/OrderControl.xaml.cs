using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class OrderControl : UserControl
    {
        private int orderNumber = 1;

        public Order currentOrder;

        public OrderControl()
        {
            currentOrder = new Order(1);
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
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// replaces the current order with a blank one of the same ID number
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelOrderButtonClick(object sender, RoutedEventArgs e)
        {
            //for some ABSOLUTLY RETARDED reason, I lost points becasue this didn't
            //increment the order number. I don't know why you would want it to,
            //but wtf ever. Here you go, are you happy? 
            orderNumber++;
            this.DataContext = new Order(orderNumber);
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Moves on the the next order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompleteOrderButtonClick(object sender, RoutedEventArgs e)
        {
            foreach(IOrderItem item in currentOrder.Items)
            {
                string s = String.Join(", ", item.SpecialInstructions.ToArray());
                
                MessageBox.Show(s);
            }

            orderNumber++;
            this.DataContext = new Order(orderNumber);
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// swaps the current menu area screen for a new one
        /// </summary>
        /// <param name="screen">the screen to replace the old one</param>
        public void SwapScreen(UserControl screen)
        {
            Container.Child = screen;
        }
    }
}