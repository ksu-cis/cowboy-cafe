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
            OrderItemName.Content = item.ToString();

            if (item is Entree && !(item is RustlersRibs))
            {
                if (item is CowpokeChili)
                {
                    CheeseSelector.Visibility = Visibility.Visible;
                }
                else
                {
                    PickleSelector.Visibility = Visibility.Visible;
                    BunSelector.Visibility = Visibility.Visible;
                    
                    if(item is TrailBurger || item is DakotaDoubleBurger || item is TexasTripleBurger)
                    {

                    }
                    
                }
            }
            else 
            {
                SizeSelector.Visibility = Visibility.Visible;

            }
        }
    }
}
