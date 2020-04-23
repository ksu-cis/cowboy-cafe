using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// Interaction logic for OrderItemCostomizer.xaml
    /// </summary>
    public partial class OrderItemCostomizer : UserControl
    {
        /// <summary>
        /// the order item being costomized
        /// </summary>
        private IOrderItem item;


        public OrderItemCostomizer(IOrderItem i)
        {
            InitializeComponent();
            item = i;
            DataContext = item;
            OrderItemName.Content = item.ToString();

            if (item is Entree)
            {
                switch (item.ToString())
                {
                    case "Texas Triple Burger":
                        EggSelector.Visibility = Visibility.Visible;
                        BaconSelector.Visibility = Visibility.Visible;
                        goto case "Dakota Double Burger";
                    case "Dakota Double Burger":
                        TomatoSelector.Visibility = Visibility.Visible;
                        LettuceSelector.Visibility = Visibility.Visible;
                        MayoSelector.Visibility = Visibility.Visible;
                        goto case "Trail Burger";
                    case "Trail Burger":
                        KetchupSelector.Visibility = Visibility.Visible;
                        MustardSelector.Visibility = Visibility.Visible;
                        CheeseSelector.Visibility = Visibility.Visible;
                        goto case "Angry Chicken";
                    case "Pecos Pulled Pork":
                        goto case "Angry Chicken";
                    case "Angry Chicken":
                        PickleSelector.Visibility = Visibility.Visible;
                        BunSelector.Visibility = Visibility.Visible;
                        break;
                    case "Cowpoke Chilli":
                        CheeseSelector.Visibility = Visibility.Visible;
                        break;
                }
            }
            else
            {
                SizeSelector.Visibility = Visibility.Visible;
                if(item is CowboyCoffee)
                {
                    IceSelector.Visibility = Visibility.Visible;
                    DecafSelector.Visibility = Visibility.Visible;
                    CreamSelector.Visibility = Visibility.Visible;
                }
                else if(item is JerkedSoda)
                {
                    IceSelector.Visibility = Visibility.Visible;
                    FlavorSelector.Visibility = Visibility.Visible;
                } 
                else if(item is TexasTea)
                {
                    IceSelector.Visibility = Visibility.Visible;
                    LemonSelector.Visibility = Visibility.Visible;
                    SweetSelector.Visibility = Visibility.Visible;
                }
                else if(item is Water)
                {
                    IceSelector.Visibility = Visibility.Visible;
                    LemonSelector.Visibility = Visibility.Visible;
                }
            }
        }

        private void SmallButton_Checked(object sender, RoutedEventArgs e)
        {
            if (item is Drink) ((Drink)item).Size = CowboyCafe.Data.Size.Small;
            else if (item is Side) ((Side)item).Size = CowboyCafe.Data.Size.Small;
        }

        private void MediumButton_Checked(object sender, RoutedEventArgs e)
        {
            if (item is Drink) ((Drink)item).Size = CowboyCafe.Data.Size.Medium;
            else if (item is Side) ((Side)item).Size = CowboyCafe.Data.Size.Medium;
        }

        private void LargeSelector_Checked(object sender, RoutedEventArgs e)
        {
            if (item is Drink) ((Drink)item).Size = CowboyCafe.Data.Size.Large;
            else if (item is Side) ((Side)item).Size = CowboyCafe.Data.Size.Large;
        }
    }
}
