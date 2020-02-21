using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
/*
namespace CowboyCafe.DataTests
{
    public class ToStringTests
    {
        [Theory]
        [InlineData(typeof(CowpokeChili), "Cowpoke Chili")]
        [InlineData(typeof(RustlersRibs), "Rustler's Ribs")]
        [InlineData(typeof(PecosPulledPork), "Pecos Pulled Pork")]
        [InlineData(typeof(TrailBurger), "Trail Burger")]
        [InlineData(typeof(DakotaDoubleBurger), "Dakota Double Burger")]
        [InlineData(typeof(TexasTripleBurger), "Texas Triple Burger")]
        [InlineData(typeof(AngryChicken), "Angry Chicken")]
        public void EntreeToStringShouldMatchExpectations(Type type, string expected)
        {
            Entree entree = Activator.CreateInstance(type) as Entree;
            Assert.Equal(expected, entree.ToString());
        }

        [Theory]
        [InlineData(typeof(ChiliCheeseFries), Size.Small, "Small Chili Cheese Fries")]
        [InlineData(typeof(ChiliCheeseFries), Size.Medium, "Medium Chili Cheese Fries")]
        [InlineData(typeof(ChiliCheeseFries), Size.Large, "Large Chili Cheese Fries")]
        [InlineData(typeof(BakedBeans), Size.Small, "Small Baked Beans")]
        [InlineData(typeof(BakedBeans), Size.Medium, "Medium Baked Beans")]
        [InlineData(typeof(BakedBeans), Size.Large, "Large Baked Beans")]
        [InlineData(typeof(CornDodgers), Size.Small, "Small Corn Dodgers")]
        [InlineData(typeof(CornDodgers), Size.Medium, "Medium Corn Dodgers")]
        [InlineData(typeof(CornDodgers), Size.Large, "Large Corn Dodgers")]
        [InlineData(typeof(PanDeCampo), Size.Small, "Small Pan de Campo")]
        [InlineData(typeof(PanDeCampo), Size.Medium, "Medium Pan de Campo")]
        [InlineData(typeof(PanDeCampo), Size.Large, "Large Pan de Campo")]
        public void SideToStringShouldMatchExpectations(Type type, Size size, string expected)
        {
            Side side = Activator.CreateInstance(type) as Side;
            side.Size = size;
            Assert.Equal(expected, side.ToString());
        }

        [Theory]
        [InlineData(Size.Small, "Small Water")]
        [InlineData(Size.Medium, "Medium Water")]
        [InlineData(Size.Large, "Large Water")]
        public void WaterToStringShouldMatchExpectations(Size size, string expected)
        {
            var water = new Water()
            {
                Size = size
            };
            Assert.Equal(expected, water.ToString());
        }

        [Theory]
        [InlineData(SodaFlavor.BirchBeer, Size.Small, "Small Birch Beer Jerked Soda")]
        [InlineData(SodaFlavor.BirchBeer, Size.Medium, "Medium Birch Beer Jerked Soda")]
        [InlineData(SodaFlavor.BirchBeer, Size.Large, "Large Birch Beer Jerked Soda")]
        [InlineData(SodaFlavor.CreamSoda, Size.Small, "Small Cream Soda Jerked Soda")]
        [InlineData(SodaFlavor.CreamSoda, Size.Medium, "Medium Cream Soda Jerked Soda")]
        [InlineData(SodaFlavor.CreamSoda, Size.Large, "Large Cream Soda Jerked Soda")]
        [InlineData(SodaFlavor.OrangeSoda, Size.Small, "Small Orange Soda Jerked Soda")]
        [InlineData(SodaFlavor.OrangeSoda, Size.Medium, "Medium Orange Soda Jerked Soda")]
        [InlineData(SodaFlavor.OrangeSoda, Size.Large, "Large Orange Soda Jerked Soda")]
        [InlineData(SodaFlavor.RootBeer, Size.Small, "Small Root Beer Jerked Soda")]
        [InlineData(SodaFlavor.RootBeer, Size.Medium, "Medium Root Beer Jerked Soda")]
        [InlineData(SodaFlavor.RootBeer, Size.Large, "Large Root Beer Jerked Soda")]
        [InlineData(SodaFlavor.Sarsparilla, Size.Small, "Small Sarsparilla Jerked Soda")]
        [InlineData(SodaFlavor.Sarsparilla, Size.Medium, "Medium Sarsparilla Jerked Soda")]
        [InlineData(SodaFlavor.Sarsparilla, Size.Large, "Large Sarsparilla Jerked Soda")]
        public void JerkedSodaToStringShouldMatchExpectations(SodaFlavor flavor, Size size, string expected)
        {
            var soda = new JerkedSoda
            {
                Flavor = flavor,
                Size = size
            };
            Assert.Equal(expected, soda.ToString());
        }

        [Theory]
        [InlineData(Size.Small, false, "Small Texas Plain Tea")]
        [InlineData(Size.Medium, false, "Medium Texas Plain Tea")]
        [InlineData(Size.Large, false, "Large Texas Plain Tea")]
        [InlineData(Size.Small, true, "Small Texas Sweet Tea")]
        [InlineData(Size.Medium, true, "Medium Texas Sweet Tea")]
        [InlineData(Size.Large, true, "Large Texas Sweet Tea")]
        public void TexasTeaToStringShouldMatchExpectations(Size size, bool sweet, string expected)
        {
            var tea = new TexasTea()
            {
                Size = size,
                Sweet = sweet
            };
            Assert.Equal(expected, tea.ToString());
        }

        [Theory]
        [InlineData(Size.Small, false, "Small Cowboy Coffee")]
        [InlineData(Size.Medium, false, "Medium Cowboy Coffee")]
        [InlineData(Size.Large, false, "Large Cowboy Coffee")]
        [InlineData(Size.Small, true, "Small Decaf Cowboy Coffee")]
        [InlineData(Size.Medium, true, "Medium Decaf Cowboy Coffee")]
        [InlineData(Size.Large, true, "Large Decaf Cowboy Coffee")]
        public void CowbowyCoffeeToStringShouldMatchExpectations(Size size, bool decaf, string expected)
        {
            var coffee = new CowboyCoffee()
            {
                Size = size,
                Decaf = decaf
            };
            Assert.Equal(expected, coffee.ToString());
        }

    }
}
*/
