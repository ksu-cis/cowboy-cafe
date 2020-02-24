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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for sideSelecction.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        /// <summary>
        /// represents the size of the side to be made
        /// </summary>
        private DinoDiner.Menu.Size size;

        /// <summary>
        /// initaLIZER for this bad boy
        /// </summary>
        public DrinkSelection()
        {
            InitializeComponent(); //Runs the defintions in the xam
        }

        /// <summary>
        /// for when you click on the fryceritops  button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectFryceritops(object sender, RoutedEventArgs args)
        {
        }

        /// <summary>
        /// nepoleon, gimme some tots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectTriceritots(object sender, RoutedEventArgs args)
        {
        }

        /// <summary>
        /// for when you click the mac and chees button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMeteorMacAndCheese(object sender, RoutedEventArgs args)
        {
        }

        /// <summary>
        /// ye olde mozzerella stick button evenet handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMozzerellaSticks(object sender, RoutedEventArgs args)
        {
        }

        /// <summary>
        /// updates slected side size variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSmall(object sender, RoutedEventArgs args)
        {
            size = DinoDiner.Menu.Size.Small;
        }

        /// <summary>
        /// updates slected side size variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectMedium(object sender, RoutedEventArgs args)
        {
            size = DinoDiner.Menu.Size.Medium;
        }

        /// <summary>
        /// updates slected side size variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectLarge(object sender, RoutedEventArgs args)
        {
            size = DinoDiner.Menu.Size.Large;
        }
    }
}
