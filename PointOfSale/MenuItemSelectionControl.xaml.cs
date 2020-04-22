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
                            break;
                        case "Cow Poke Chili":
                            food = new CowpokeChili();
                            break;
                        case "Dakota Double":
                            food = new DakotaDoubleBurger();
                            break;
                        case "Pecos Pulled Pork":
                            food = new PecosPulledPork();
                            break;
                        case "Rustler's Ribs":
                            food = new RustlersRibs();
                            break;
                        case "Texas Triple":
                            food = new TexasTripleBurger();
                            break;
                        case "Trailburger":
                            food = new TrailBurger();
                            break;


                        case "Baked Beans":
                            food = new BakedBeans();
                            break;
                        case "Chilli Cheese Fries":
                            food = new ChilliCheeseFries();
                            break;
                        case "Corn Dodgers":
                            food = new CornDodgers();
                            break;
                        case "Pan De Campo":
                            food = new PanDeCampo();
                            break;


                        case "Cowboy Coffee":
                            
                            CowboyCoffee C = new CowboyCoffee();
                            parent.SwapScreen(new CovfefeCostomizer(C));
                            currentOrder.Add(C);
                            

                            food = new CowboyCoffee();


                            break;
                        case "Jerked Soda":
                            food = new JerkedSoda();
                            break;
                        case "Texas Tea":
                            food = new TexasTea();
                            break;
                        case "Water":
                            food = new Water();
                            break;
                        default:
                            throw new Exception("type on button text");
                    }
                    //parent.SwapScreen(new OrderItemCostomizer(food));
                    //currentOrder.Add(food);
                }
            }
        }
    }
}