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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        /// <summary>
        /// initaLIZER for this bad boy
        /// </summary>
        public MenuCategorySelection()
        {
            InitializeComponent(); //Runs the defintions in the xam
        }

        /// <summary>
        /// for when you click on the combo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectCombo(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new ComboSelection());
        }

        /// <summary>
        /// for when you click the entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectEntree(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new EntreeSelection());
        }

        /// <summary>
        /// for when you click the side button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectSide(object sender, RoutedEventArgs args)
        {
            NavigationService.Navigate(new SideSelection());
        }

        /// <summary>
        /// for when yea hit that drank button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void SelectDrink(object sender, RoutedEventArgs args)
        {
        }
    }
}
