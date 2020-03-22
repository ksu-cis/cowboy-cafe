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
    /// Interaction logic for CustomizeEntree.xaml
    /// </summary>
    public partial class CustomizeEntree : UserControl
    {
        public CustomizeEntree()
        {
            InitializeComponent();
        }

        public void ChilliMenu()
        {
            Cheese.Visibility = Visibility.Visible;
            TortillaStrips.Visibility = Visibility.Visible;
            SourCream.Visibility = Visibility.Visible;
            GreenOnions.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Ketchup);
            Toppings.Items.Remove(Mustard);
            Toppings.Items.Remove(Pickle);
            Toppings.Items.Remove(Bread);
            Toppings.Items.Remove(Bun);
            Toppings.Items.Remove(Lettuce);
            Toppings.Items.Remove(Mayo);
            Toppings.Items.Remove(Tomato);
            Toppings.Items.Remove(Bacon);
            Toppings.Items.Remove(Egg);
        }

        public void AngryChickenMenu()
        {
            Bread.Visibility = Visibility.Visible;
            Pickle.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Cheese);
            Toppings.Items.Remove(TortillaStrips);
            Toppings.Items.Remove(SourCream);
            Toppings.Items.Remove(GreenOnions);
            Toppings.Items.Remove(Bun);
            Toppings.Items.Remove(Lettuce);
            Toppings.Items.Remove(Mayo);
            Toppings.Items.Remove(Tomato);
            Toppings.Items.Remove(Bacon);
            Toppings.Items.Remove(Egg);
            Toppings.Items.Remove(Ketchup);
            Toppings.Items.Remove(Mustard);
        }

        public void PecosPulledPork()
        {
            Bread.Visibility = Visibility.Visible;
            Pickle.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Cheese);
            Toppings.Items.Remove(TortillaStrips);
            Toppings.Items.Remove(SourCream);
            Toppings.Items.Remove(GreenOnions);
            Toppings.Items.Remove(Bun);
            Toppings.Items.Remove(Lettuce);
            Toppings.Items.Remove(Mayo);
            Toppings.Items.Remove(Tomato);
            Toppings.Items.Remove(Bacon);
            Toppings.Items.Remove(Egg);
            Toppings.Items.Remove(Ketchup);
            Toppings.Items.Remove(Mustard);
        }

        public void TrailBurger()
        {
            Bun.Visibility = Visibility.Visible;
            Ketchup.Visibility = Visibility.Visible;
            Cheese.Visibility = Visibility.Visible;
            Pickle.Visibility = Visibility.Visible;
            Mustard.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Lettuce);
            Toppings.Items.Remove(Mayo);
            Toppings.Items.Remove(Tomato);
            Toppings.Items.Remove(Bacon);
            Toppings.Items.Remove(Egg);
            Toppings.Items.Remove(TortillaStrips);
            Toppings.Items.Remove(SourCream);
            Toppings.Items.Remove(GreenOnions);
            Toppings.Items.Remove(Bread);
        }

        public void DakotaDouble()
        {
            Bun.Visibility = Visibility.Visible;
            Ketchup.Visibility = Visibility.Visible;
            Cheese.Visibility = Visibility.Visible;
            Pickle.Visibility = Visibility.Visible;
            Mustard.Visibility = Visibility.Visible;
            Tomato.Visibility = Visibility.Visible;
            Lettuce.Visibility = Visibility.Visible;
            Mayo.Visibility = Visibility.Visible;
            Toppings.Items.Remove(Bacon);
            Toppings.Items.Remove(Egg);
            Toppings.Items.Remove(TortillaStrips);
            Toppings.Items.Remove(SourCream);
            Toppings.Items.Remove(GreenOnions);
            Toppings.Items.Remove(Bread);
        }

        public void TexasTriple()
        {
            Bun.Visibility = Visibility.Visible;
            Ketchup.Visibility = Visibility.Visible;
            Cheese.Visibility = Visibility.Visible;
            Pickle.Visibility = Visibility.Visible;
            Mustard.Visibility = Visibility.Visible;
            Tomato.Visibility = Visibility.Visible;
            Lettuce.Visibility = Visibility.Visible;
            Mayo.Visibility = Visibility.Visible;
            Bacon.Visibility = Visibility.Visible;
            Egg.Visibility = Visibility.Visible;
            Toppings.Items.Remove(TortillaStrips);
            Toppings.Items.Remove(SourCream);
            Toppings.Items.Remove(GreenOnions);
            Toppings.Items.Remove(Bread);
        }


    }

    
}
