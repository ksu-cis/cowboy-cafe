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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeDrink.xaml
    /// </summary>
    public partial class CustomizeDrink : UserControl
    {
        public CustomizeDrink()
        {
            InitializeComponent();
        }

        public void WaterMenu()
        {
            Lemon.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Decaf);
            Toppings.Items.Remove(RoomForCream);
            Toppings.Items.Remove(Soda);
            Toppings.Items.Remove(CreamSoda);
            Toppings.Items.Remove(OrangeSoda);
            Toppings.Items.Remove(Sarsparilla);
            Toppings.Items.Remove(BirchBeer);
            Toppings.Items.Remove(RootBeer);
            Toppings.Items.Remove(Sweet);
        }

        public void SodaMenu()
        {
            Soda.Visibility = Visibility.Visible;
            CreamSoda.Visibility = Visibility.Visible;
            OrangeSoda.Visibility = Visibility.Visible;
            Sarsparilla.Visibility = Visibility.Visible;
            BirchBeer.Visibility = Visibility.Visible;
            RootBeer.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Decaf);
            Toppings.Items.Remove(RoomForCream);
            Toppings.Items.Remove(Lemon);
            Toppings.Items.Remove(Sweet);
        }

        public void CoffeeMenu()
        {
            Decaf.Visibility = Visibility.Visible;
            RoomForCream.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Lemon);
            Toppings.Items.Remove(Soda);
            Toppings.Items.Remove(CreamSoda);
            Toppings.Items.Remove(OrangeSoda);
            Toppings.Items.Remove(Sarsparilla);
            Toppings.Items.Remove(BirchBeer);
            Toppings.Items.Remove(RootBeer);
            Toppings.Items.Remove(Sweet);
        }

        public void TeaMenu()
        {
            Sweet.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Decaf);
            Toppings.Items.Remove(Soda);
            Toppings.Items.Remove(CreamSoda);
            Toppings.Items.Remove(OrangeSoda);
            Toppings.Items.Remove(Sarsparilla);
            Toppings.Items.Remove(BirchBeer);
            Toppings.Items.Remove(RootBeer);
            Toppings.Items.Remove(RoomForCream);
        }
    }
}
