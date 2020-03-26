using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }

        public void Remove(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                    {
                        order.Remove(item);
                    }
                }
            }
        }

        private void OnItemSelectChange(object sender, SelectionChangedEventArgs e)
        {
            var Control = this.FindAncestor<OrderControl>();
            if(Control == null)
            {
                return;
            }

            foreach (object Item in e.AddedItems)
            {
                if(Item is CowpokeChili)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Cowpoke Chilli";
                    cpc.ChilliMenu();
                }
                else if (Item is AngryChicken)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Angry Chicken";
                    cpc.AngryChickenMenu();
                }
                else if (Item is DakotaDoubleBurger)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Dakota Double Burger";
                    cpc.DakotaDouble();
                }
                else if (Item is PecosPulledPork)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Pecos Pulled Pork";
                    cpc.PecosPulledPork();
                }
                else if (Item is RustlersRibs)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Rustler's Ribs";
                }
                else if (Item is TrailBurger)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Trail Burger";
                    cpc.TrailBurger();
                }
                else if (Item is TexasTripleBurger)
                {
                    var cpc = new CustomizeEntree();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Texas Triple Burger";
                    cpc.TexasTriple();
                }
                else if (Item is BakedBeans)
                {
                    var cpc = new CustomizeSides();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Baked Beans";
                }
                else if (Item is ChiliCheeseFries)
                {
                    var cpc = new CustomizeSides();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Chilli Cheese Fries";
                }
                else if (Item is PanDeCampo)
                {
                    var cpc = new CustomizeSides();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Pan De Campo";
                }
                else if (Item is CornDodgers)
                {
                    var cpc = new CustomizeSides();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Corn Dodgers";
                }
                else if (Item is JerkedSoda)
                {
                    var cpc = new CustomizeDrink();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Jerked Soda";
                    cpc.SodaMenu();
                }
                else if (Item is CowboyCoffee)
                {
                    var cpc = new CustomizeDrink();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Cowboy Coffee";
                    cpc.CoffeeMenu();
                }
                else if (Item is Water)
                {
                    var cpc = new CustomizeDrink();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Water";
                    cpc.WaterMenu();
                }
                else if (Item is TexasTea)
                {
                    var cpc = new CustomizeDrink();
                    cpc.DataContext = Item;
                    Control.SwapScreen(cpc);
                    cpc.Title.Text = "Customize Texas Tea";
                    cpc.TeaMenu();
                }
            }
        }


    }
}
