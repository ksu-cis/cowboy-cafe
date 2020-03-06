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

        public void OnItemAddButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            if(DataContext is Order order)
            {
                if(sender is Button button)
                {
                    switch (button.Name)
                    {
                        case "AddCowPokeChilli":
                            var entree = new CowpokeChili();
                            var screen = new CustomizeCowPokeChilli();
                            screen.DataContext = entree;
                            order.Add(entree);
                            orderControl.SwapScreen(screen);
                            break;
                        case "AddRustlersRibs":
                            var entree2 = new RustlersRibs();
                            var screen2 = new CustomizeCowPokeChilli();
                            screen2.DataContext = entree2;
                            order.Add(new CowpokeChili());
                            orderControl.SwapScreen(new CustomizeCowPokeChilli());
                            break;
                    }
                }
            }
        }

        private void AddRustlersRibs_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.RustlersRibs());
        }

        private void AddPecosPulledPork_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.PecosPulledPork());
        }

        private void AddTrailBurger_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.TrailBurger());
        }

        private void DakotaDoubleBurger_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.DakotaDoubleBurger());
        }

        private void AddTexasTripleBurger_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.TexasTripleBurger());
        }

        private void AddAngryChicken_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.AngryChicken());
        }

        private void AddChilliCHeeseFries_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.ChiliCheeseFries());
        }

        private void AddCornDodgers_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.CornDodgers());
        }

        private void AddPanDeCampo_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.PanDeCampo());
        }

        private void AddBakedBeans_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.BakedBeans());
        }

        private void AddJerkedSoda_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.JerkedSoda());
        }

        private void AddTexasTea_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.TexasTea());
        }

        private void AddCowbyCoffee_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.CowboyCoffee());
        }

        private void AddWater_Click(object sender, RoutedEventArgs e)
        {
            ((Order)DataContext).Add(new CowboyCafe.Data.Water());
        }
    }
}
