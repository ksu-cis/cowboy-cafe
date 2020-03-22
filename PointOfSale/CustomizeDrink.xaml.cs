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
            Other.Items.Remove(Decaf);
            Other.Items.Remove(RoomForCream);
            SodaFlavor.Visibility = Visibility.Hidden;
            Other.Items.Remove(Sweet);
        }

        public void SodaMenu()
        {
            Soda.Visibility = Visibility.Visible;           
            Other.Items.Remove(Decaf);
            Other.Items.Remove(RoomForCream);
            Other.Items.Remove(Lemon);
            Other.Items.Remove(Sweet);
        }

        public void CoffeeMenu()
        {
            Decaf.Visibility = Visibility.Visible;
            RoomForCream.Visibility = Visibility.Visible;
            Other.Items.Remove(Lemon);
            SodaFlavor.Visibility = Visibility.Hidden;
            Other.Items.Remove(Sweet);
        }

        public void TeaMenu()
        {
            Sweet.Visibility = Visibility.Visible;
            Lemon.Visibility = Visibility.Visible;
            Other.Items.Remove(Decaf);           
            Other.Items.Remove(RoomForCream);
            SodaFlavor.Visibility = Visibility.Hidden;
        }

        public void ItemChanged(object sender, RoutedEventArgs e)
        {
            var ancestor = this.FindAncestor<OrderControl>();
            if(ancestor is OrderControl)
            {
                ancestor.ChangeSize();
            }
        }


    }
}
