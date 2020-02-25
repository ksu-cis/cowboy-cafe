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

        /// <summary>
        /// Adds an angry chicken to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// adds a chilli to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowPokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// adds a double beeschuger to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// adds pulled pork to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// adds ribs to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// adds a triple burg to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// adds a trailer borgar to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TrailBurger());
        }

        //SIDES

        /// <summary>
        /// adds baked beans to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// adds cheesefries to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChilliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new ChilliCheeseFries());
        }

        /// <summary>
        /// adds corn dodgers to the menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// adds pan de camp0 to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new PanDeCampo());
        }


        //DRINKS

        /// <summary>
        /// adds covfefe to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// adds pop to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// adds tea to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new TexasTea());
        }

        /// <summary>
        /// adds vaten to the order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderListView.Items.Add(new Water());
        }
    }
}