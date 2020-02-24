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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {
            InitializeComponent();
        }

        private void AddCowPokeChilli_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.CowpokeChili());
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.RustlersRibs());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.PecosPulledPork());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.TrailBurger());
        }

        private void DakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.DakotaDoubleBurger());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.TexasTripleBurger());
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.AngryChicken());
        }

        private void AddChilliCHeeseFries_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.ChiliCheeseFries());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.CornDodgers());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.PanDeCampo());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.BakedBeans());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.JerkedSoda());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.TexasTea());
        }

        private void AddCowbyCoffee_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.CowboyCoffee());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            OrderBox.Items.Add(new CowboyCafe.Data.Water());
        }
    }
}
