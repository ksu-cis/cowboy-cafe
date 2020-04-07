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
        public TransactionControl(Order order)
        {
            InitializeComponent();
            DataContext = order;
        }
       
        /// <summary>
        /// Checks to see if paid by cash or card
        /// </summary>
        private bool paymentMethod;

        /// <summary>
        ///  Tax to be applied to subtotal
        /// </summary>
        private const double tax = 0.16;

        /// <summary>
        /// Cash tended for pay
        /// </summary>
        public double CashTend = 0.0;
        
        /// <summary>
        /// Final order total
        /// </summary>
        public double Total
        {
            get
            {
                if(DataContext is Order order)
                {
                    var total = order.Subtotal * tax;

                    return total + order.Subtotal;
                }
                else
                {
                    throw new Exception();
                }
            }
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
                reciept.Append(order.OrderNumber).AppendLine();
                reciept.Append(System.DateTime.Now.ToString()).AppendLine();
                foreach(object Item in order.items)
                {
                    if (Item is CowpokeChili item)
                    {
                        reciept.AppendFormat("{0} ${1}", item, item.Price).AppendLine();
                        SpecialsList(reciept, item.SpecialInstructions);
                    }
                    else if (Item is AngryChicken items)
                    {
                        reciept.AppendFormat("{0} ${1}", items, items.Price).AppendLine();
                        SpecialsList(reciept, items.SpecialInstructions);
                    }
                    else if (Item is DakotaDoubleBurger itemA)
                    {
                        reciept.AppendFormat("{0} ${1}", itemA, itemA.Price).AppendLine();
                        SpecialsList(reciept, itemA.SpecialInstructions);
                    }
                    else if (Item is PecosPulledPork itemB)
                    {
                        reciept.AppendFormat("{0} ${1}", itemB, itemB.Price).AppendLine();
                        SpecialsList(reciept, itemB.SpecialInstructions);
                    }
                    else if (Item is RustlersRibs itemC)
                    {
                        reciept.AppendFormat("{0} ${1}", itemC, itemC.Price).AppendLine();
                        SpecialsList(reciept, itemC.SpecialInstructions);
                    }
                    else if (Item is TrailBurger itemD)
                    {
                        reciept.AppendFormat("{0} ${1}", itemD, itemD.Price).AppendLine();
                        SpecialsList(reciept, itemD.SpecialInstructions);
                    }
                    else if (Item is TexasTripleBurger itemE)
                    {
                        reciept.AppendFormat("{0} ${1}", itemE, itemE.Price).AppendLine();
                        SpecialsList(reciept, itemE.SpecialInstructions);
                    }
                    else if (Item is BakedBeans itemF)
                    {
                        reciept.AppendFormat("{0} ${1}", itemF, itemF.Price).AppendLine();
                        SpecialsList(reciept, itemF.SpecialInstructions);

                    }
                    else if (Item is ChiliCheeseFries itemG)
                    {
                        reciept.AppendFormat("{0} ${1}", itemG, itemG.Price).AppendLine();
                        SpecialsList(reciept, itemG.SpecialInstructions);
                    }
                    else if (Item is PanDeCampo itemH)
                    {
                        reciept.AppendFormat("{0} ${1}", itemH, itemH.Price).AppendLine();
                        SpecialsList(reciept, itemH.SpecialInstructions);
                    }
                    else if (Item is CornDodgers itemI)
                    {
                        reciept.AppendFormat("{0} ${1}", itemI, itemI.Price).AppendLine();
                        SpecialsList(reciept, itemI.SpecialInstructions);
                    }
                    else if (Item is JerkedSoda itemJ)
                    {
                        reciept.AppendFormat("{0} ${1}", itemJ, itemJ.Price).AppendLine();
                        SpecialsList(reciept, itemJ.SpecialInstructions);
                    }
                    else if (Item is CowboyCoffee itemK)
                    {
                        reciept.AppendFormat("{0} ${1}", itemK, itemK.Price).AppendLine();
                        SpecialsList(reciept, itemK.SpecialInstructions);
                    }
                    else if (Item is Water itemL)
                    {
                        reciept.AppendFormat("{0} ${1}", itemL, itemL.Price).AppendLine();
                        SpecialsList(reciept, itemL.SpecialInstructions);
                    }
                    else if (Item is TexasTea itemM)
                    {
                        reciept.AppendFormat("{0} ${1}", itemM, itemM.Price).AppendLine();
                        SpecialsList(reciept, itemM.SpecialInstructions);
                    }
                }

                reciept.AppendFormat("Subtotal: ${0}", order.Subtotal).AppendLine();
                reciept.Append("Tax: " + tax + "%").AppendLine();
                reciept.AppendFormat("Total: ${0}", Total);

                if (paymentMethod == true)
                {
                    double change = Total - CashTend;

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
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                
                var result = card.ProcessTransaction(Total);
                if (result == ResultCode.Success)
                {
                    MessageBox.Show("Success");
                    printer.Print(Reciept());
                    orderControl.DataContext = new Order();
                    orderControl.SwapScreen(new MenuItemSelectionControl());
                }
                else
                {
                    MessageBox.Show(result.ToString());
                    orderControl.SwapScreen(new TransactionControl(order));
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
            orderControl.SwapScreen(register);
            paymentMethod = true;


        }

        /// <summary>
        /// Cancles order and creates a new one
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnCancelClick(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.DataContext = new Order();
            orderControl.SwapScreen(new MenuItemSelectionControl());

        }


        /// <summary>
        /// Calls PrintReciept
        /// </summary>
        public void PrintReciept()
        {
            ReceiptPrinter rp = new ReceiptPrinter();
            rp.Print(Reciept());
        }


        /// <summary>
        /// Prints special instructions to reciept
        /// </summary>
        /// <param name="s"></param>
        /// <param name="list"></param>
        public void SpecialsList(StringBuilder s, List<string> list)
        {
            foreach (string v in list)
            {
                s.Append(v).AppendLine();
            }
        }

    }

         


}

