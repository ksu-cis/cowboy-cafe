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
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashRegisterControl.xaml
    /// </summary>
    public partial class CashRegisterControl : UserControl
    {
        private TransactionControl transaction; 
        public CashRegisterControl(TransactionControl transaction)
        {
            InitializeComponent();
            this.transaction = transaction;
            
        }


        /// <summary>
        /// Lets cashier know user is done giving money
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cashDone(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if (this.DataContext is CashRegisterModelView crmv)
            {

                if (crmv.TotalPaid >= transaction.TotalWithTax)
                {
                    transaction.PrintReciept();

                }
            }
            MainWindow mw = this.FindAncestor<MainWindow>();
            mw.DataContext = new Order();
            mw.Container.Child= new OrderControl();
        }
    }
}
