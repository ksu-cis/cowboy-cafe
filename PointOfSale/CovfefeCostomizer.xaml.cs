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
using Size = CowboyCafe.Data.Size;
using System.ComponentModel;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CovfefeCostomizer.xaml
    /// </summary>
    public partial class CovfefeCostomizer : UserControl
    {
        private CowboyCoffee covfefe;
        public CovfefeCostomizer(CowboyCoffee c)
        {
            covfefe = c;
            DataContext = c;
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            covfefe.Size = Size.Large;
            covfefe.Decaf = true;
        }
    }
}
