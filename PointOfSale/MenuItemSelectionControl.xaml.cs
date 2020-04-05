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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// event for when a button is pressed. creates new instance of that
        /// order item and switches screens to the item editor
        /// </summary>
        /// <param name="sender">the button that was pressed</param>
        /// <param name="e"></param>
        private void OrderItemButton_Click(object sender, RoutedEventArgs e)
        {
            OrderControl parent = this.FindAncestor<OrderControl>();
            if (DataContext is Order currentOrder)
            {

                if (sender is Button button)
                {
                    IOrderItem food;
                    switch (button.Content)
                    {
                        case "Angry Chicken":
                            food = new AngryChicken();
                            parent.SwapScreen(new OrderItemCostomizer(new AngryChicken()));
                            break;
                        default:
                            food = new Water();
                            break;
                    }
                    currentOrder.Add(food);
                }
                    
                //IOrderItem food = new TexasTripleBurger();
                //parent.SwapScreen(new OrderItemCostomizer(food));

            }
        }




        /*
        /// <summary>
        /// Adds an angry chicken to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new AngryChicken());
            if(DataContext is Order currentOrder)
            {
                currentOrder.Add(new AngryChicken());
            }
        }

        /// <summary>
        /// adds a chilli to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowPokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowpokeChili());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new CowpokeChili());
            }
        }

        /// <summary>
        /// adds a double beeschuger to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new DakotaDoubleBurger());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new DakotaDoubleBurger());
            }
        }

        /// <summary>
        /// adds pulled pork to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PecosPulledPork());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new PecosPulledPork());
            }
        }

        /// <summary>
        /// adds ribs to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new RustlersRibs());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new RustlersRibs());
            }
        }

        /// <summary>
        /// adds a triple burg to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTripleBurger());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new TexasTripleBurger());
            }
        }

        /// <summary>
        /// adds a trailer borgar to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TrailBurger());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new TrailBurger());
            }
        }

        //SIDES

        /// <summary>
        /// adds baked beans to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderControl parent = this.FindAncestor<OrderControl>();
            if(DataContext is Order currentOrder)
            {
                parent.SwapScreen(new OrderItemCostomizer());
            }


            //OrderListView.Items.Add(new BakedBeans());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new BakedBeans());

            }
        }

        /// <summary>
        /// adds cheesefries to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChilliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new ChilliCheeseFries());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new ChilliCheeseFries());
            }
        }

        /// <summary>
        /// adds corn dodgers to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CornDodgers());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// adds pan de camp0 to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new PanDeCampo());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new PanDeCampo());
            }
        }


        //DRINKS

        /// <summary>
        /// adds covfefe to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new CowboyCoffee());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new CowboyCoffee());
            }
        }

        /// <summary>
        /// adds pop to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new JerkedSoda());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new JerkedSoda());
            }
        }

        /// <summary>
        /// adds tea to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new TexasTea());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new TexasTea());
            }

        }

        /// <summary>
        /// adds vaten to the currentOrder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            //OrderListView.Items.Add(new Water());
            if (DataContext is Order currentOrder)
            {
                currentOrder.Add(new Water());
            }
        }

    */
    }
}