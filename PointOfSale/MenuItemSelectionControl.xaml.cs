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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }

        public void OnItemAddEntreeClicked(object sender, RoutedEventArgs e)
        {
            IOrderItem entree;
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Name)
                    {
                        case "AddCowPokeChilli":
                            entree = new CowpokeChili();
                            var screen = new CustomizeEntree();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen);
                            screen.Title.Text = "Customize Cowpoke Chilli";
                            screen.ChilliMenu();
                            break;
                        case "AddRustlersRibs":
                            entree = new RustlersRibs();
                            var screen2 = new CustomizeEntree();
                            screen2.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen2);
                            screen2.Title.Text = "Customize Rustler's Ribs";
                            break;
                        case "AddPecosPulledPork":
                            entree = new PecosPulledPork();
                            var screen3 = new CustomizeEntree();
                            screen3.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen3);
                            screen3.Title.Text = "Customize Pecos Pulled Pork";
                            screen3.PecosPulledPork();
                            break;
                        case "AddTrailBurger":
                            entree = new TrailBurger();
                            var screen4 = new CustomizeEntree();
                            screen4.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen4);
                            screen4.Title.Text = "Customize Trail Burger";
                            screen4.TrailBurger();
                            break;
                        case "DakotaDoubleBurger":
                            entree = new DakotaDoubleBurger();
                            var screen5 = new CustomizeEntree();
                            screen5.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen5);
                            screen5.Title.Text = "Customize Dakota Double Burger";
                            screen5.DakotaDouble();
                            break;
                        case "AddTexasTripleBurger":
                            entree = new TexasTripleBurger();
                            var screen6 = new CustomizeEntree();
                            screen6.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen6);
                            screen6.Title.Text = "Customize Texas Triple Burger";
                            screen6.TexasTriple();
                            break;
                        case "AddAngryChicken":
                            entree = new AngryChicken();
                            var screen7 = new CustomizeEntree();
                            screen7.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen7);
                            screen7.Title.Text = "Customize Angry Chicken";
                            screen7.AngryChickenMenu();
                            break;
                    }
                }
            }
        }

        public void OnItemAddDrinkClick(object sender, RoutedEventArgs e)
        {
            IOrderItem Drink;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Name)
                    {
                        case "AddJerkedSoda":
                            Drink = new JerkedSoda();
                            var screen = new CustomizeDrink();
                            screen.DataContext = Drink;
                            order.Add(Drink);
                            orderControl.SwapScreen(screen);
                            screen.Title.Text = "Customize Jerked Soda";
                            screen.SodaMenu();
                            break;
                        case "AddTexasTea":
                            Drink = new TexasTea();
                            var screen2 = new CustomizeDrink();
                            screen2.DataContext = Drink;
                            order.Add(Drink);
                            orderControl.SwapScreen(screen2);
                            screen2.Title.Text = "Customize Texas Tea";
                            screen2.TeaMenu();
                            break;
                        case "AddCowbyCoffee":
                            Drink = new CowboyCoffee();
                            var screen3 = new CustomizeDrink();
                            screen3.DataContext = Drink;
                            order.Add(Drink);
                            orderControl.SwapScreen(screen3);
                            screen3.Title.Text = "Customize Cowboy Coffee";
                            screen3.CoffeeMenu();
                            break;
                        case "AddWater":
                            Drink = new Water();
                            var screen4 = new CustomizeDrink();
                            screen4.DataContext = Drink;
                            order.Add(Drink);
                            orderControl.SwapScreen(screen4);
                            screen4.Title.Text = "Customize Water";
                            screen4.WaterMenu();
                            break;
                    }
                }
            }
        }

        public void OnItemAddSideClick(object sender, RoutedEventArgs e)
        {
            IOrderItem Side;
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is Order order)
            {
                if (sender is Button button)
                {
                    switch (button.Name)
                    {
                        case "AddChilliCheeseFries":
                            Side = new ChiliCheeseFries();
                            var screen = new CustomizeSides();
                            screen.DataContext = Side;
                            order.Add(Side);
                            orderControl.SwapScreen(screen);
                            screen.Title.Text = "Customize Chilli Cheese Fries";
                            break;
                        case "AddCornDodgers":
                            Side = new CornDodgers();
                            var screen2 = new CustomizeSides();
                            screen2.DataContext = Side;
                            order.Add(Side);
                            orderControl.SwapScreen(screen2);
                            screen2.Title.Text = "Customize Corn Dodgers";
                            break;
                        case "AddPanDeCampo":
                            Side = new PanDeCampo();
                            var screen3 = new CustomizeSides();
                            screen3.DataContext = Side;
                            order.Add(Side);
                            orderControl.SwapScreen(screen3);
                            screen3.Title.Text = "Customize Pan De Campo";
                            break;
                        case "AddBakedBeans":
                            Side = new BakedBeans();
                            var screen4 = new CustomizeSides();
                            screen4.DataContext = Side;
                            order.Add(Side);
                            orderControl.SwapScreen(screen4);
                            screen4.Title.Text = "Customize Baked Beans";
                            break;
                    }
                }
            }
        }
    }
}
