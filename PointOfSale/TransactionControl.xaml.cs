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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {      
        /// <summary>
        /// Checks to see if paid by cash or card
        /// </summary>
        private bool paymentMethod;

        /// <summary>
        ///  Tax to be applied to subtotal
        /// </summary>
        private const double tax = 0.16;

        /// <summary>
        /// Private backing variable for cash tended
        /// </summary>
        private double cashTend;

        /// <summary>
        /// Cash tended for pay
        /// </summary>
        public double CashTend = 0.0;

        /// <summary>
        /// private backing variable for total
        /// </summary>
        private double total;
        
        /// <summary>
        /// Final order total
        /// </summary>
        public double TotalWithTax
        {
            get { return Math.Round(total, 2); }
            private set { total = Math.Round(value, 2); }
        }

        public TransactionControl(Order order)
        {
            InitializeComponent();
            DataContext = order;
            total = (order.Subtotal * 0.16) + order.Subtotal;
        }

        /// <summary>
        /// Creates reciept for order
        /// </summary>
        /// <returns></returns>
        public string Reciept()
        {
            StringBuilder reciept = new StringBuilder();
            if(DataContext is Order order)
            {
                reciept.Append("---------- COWBOY CAFE ----------\n");
                reciept.Append(DateTime.Now + "\n");
                reciept.Append("Order #: " + order.OrderNumber + "\n");
                foreach (IOrderItem i in order.Items)
                {
                    reciept.Append(i.ToString() + "\t\t" + i.Price.ToString("C2") + "\n");
                    foreach (string s in i.SpecialInstructions)
                        reciept.Append(s + "\n");

                    reciept.Append("\n");
                }

                reciept.AppendFormat("Subtotal: ${0}", order.Subtotal).AppendLine();
                reciept.Append("Tax: " + tax + "%").AppendLine();
                reciept.AppendFormat("TotalWithTax: ${0}", TotalWithTax).AppendLine();

                if (paymentMethod == true)
                {
                    double change = TotalWithTax - CashTend;

                    reciept.Append("Payement Method: Cash").AppendLine();
                    reciept.AppendFormat("Cash Tended: ${0}", CashTend).AppendLine();
                    reciept.AppendFormat("Change: ${0}", change).AppendLine();
                }
                else
                {
                    reciept.Append("Payment Method: Card").AppendLine();
                }

                reciept.Append("Thank You! Comeback Soon.").AppendLine();
                ReceiptPrinter rp = new ReceiptPrinter();
                rp.Print(reciept.ToString());
            }
            return reciept.ToString();
        }

        /// <summary>
        /// Proccess Credit Card Transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCreditClicked(object sender, RoutedEventArgs e)
        {
            CardTerminal card = new CardTerminal();
            paymentMethod = false;
            ReceiptPrinter printer = new ReceiptPrinter();
            MainWindow mw = this.FindAncestor<MainWindow>();
            if (DataContext is Order order)
            {
                
                var result = card.ProcessTransaction(TotalWithTax);
                if (result == ResultCode.Success)
                {
                    MessageBox.Show("Success");
                    printer.Print(Reciept());
                    mw.DataContext = new Order();
                    mw.Container.Child = new OrderControl();
                }
                else
                {
                    MessageBox.Show(result.ToString());
                    mw.Container.Child = new TransactionControl(order);
                }
            }
        }

        /// <summary>
        /// Proccesses Cash Transaction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCashClicked(object sender, RoutedEventArgs e)
        {
            CashDrawer cash = CashRegisterModelView.drawer;
            CashRegisterControl register = new CashRegisterControl(this);
            register.DataContext = new CashRegisterModelView();
            ReceiptPrinter printer = new ReceiptPrinter();
            var orderControl = this.FindAncestor<OrderControl>();
            MainWindow mw = this.FindAncestor<MainWindow>();
            mw.Container.Child = register;
            paymentMethod = true;


        }

        /// <summary>
        /// Cancles order and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelClick(object sender, RoutedEventArgs e)
        {
            MainWindow mw = this.FindAncestor<MainWindow>();
            mw.DataContext = new Order();
            mw.Container.Child = new OrderControl();

        }


        /// <summary>
        /// Calls PrintReciept
        /// </summary>
        public void PrintReciept()
        {
            ReceiptPrinter rp = new ReceiptPrinter();
            rp.Print(Reciept());
        }

    }

         


}

