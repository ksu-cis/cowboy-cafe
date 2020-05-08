using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using System.Linq;
using Xunit;

namespace CowboyCafe.DataTests
{
    public class MenuPropertytest
    {
        [Theory]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        public void Sidesshouldcontainsides(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Sides)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);

        }

        [Fact]
        public void SidesShouldHaveOnlyFourItems()
        {
            Assert.Equal(12, Menu.Sides.Count());
        }

        [Fact]
        public void SidesReturnsCollectionOfSides()
        {
            var side = new List<IOrderItem>(Menu.Side());
            side.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                side,
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        [Theory]
        [InlineData(typeof(Water))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        public void Drinksshouldcontaindrink(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Drinks)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);

        }

        [Fact]
        public void DrinksShouldHaveOnlyFourItems()
        {
            Assert.Equal(4, Menu.Drinks.Count());
        }

        [Fact]
        public void DrinksReturnsCollectionOfDrinks()
        {
            var drink = new List<IOrderItem>(Menu.Drink());
            drink.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                drink,
                (w) => { Assert.IsType<Water>(w); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); }
                );
        }

        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]

        public void EntreesshouldcontainEntrees(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.Entrees)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);

        }

        [Fact]
        public void EntreesShouldHaveOnlySevenItems()
        {
            Assert.Equal(7, Menu.Entrees.Count());
        }

        [Fact]
        public void EntreesReturnsCollectionOfEntrees()
        {
            var entree = new List<IOrderItem>(Menu.Entree());
            entree.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                entree,
                (cpc) => { Assert.IsType<CowpokeChili>(cpc); },
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }


        [Theory]
        [InlineData(typeof(CowpokeChili))]
        [InlineData(typeof(AngryChicken))]
        [InlineData(typeof(RustlersRibs))]
        [InlineData(typeof(PecosPulledPork))]
        [InlineData(typeof(DakotaDoubleBurger))]
        [InlineData(typeof(TexasTripleBurger))]
        [InlineData(typeof(TrailBurger))]
        [InlineData(typeof(ChiliCheeseFries))]
        [InlineData(typeof(BakedBeans))]
        [InlineData(typeof(CornDodgers))]
        [InlineData(typeof(PanDeCampo))]
        [InlineData(typeof(Water))]
        [InlineData(typeof(JerkedSoda))]
        [InlineData(typeof(TexasTea))]
        [InlineData(typeof(CowboyCoffee))]
        public void AllshouldcontainAll(Type type)
        {
            var types = new List<Type>();
            foreach (IOrderItem item in Menu.All)
            {
                types.Add(item.GetType());
            }
            Assert.Contains(type, types);

        }

        [Fact]
        public void AllShouldHaveOnlyFifteenItems()
        {
            Assert.Equal(15, Menu.All.Count());
        }

        [Fact]
        public void AllReturnsCollectionOfAll()
        {
            var all = new List<IOrderItem>(Menu.All);
            all.Sort((a, b) => a.ToString().CompareTo(b.ToString()));
            Assert.Collection(
                all,
                (cpc) => { Assert.IsType<CowpokeChili>(cpc); },
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (tt) => { Assert.IsType<TexasTripleBurger>(tt); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (w) => { Assert.IsType<Water>(w); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); }
                );
        }

        [Theory]
        [InlineData(null,null)]
        [InlineData(null,10.00)]
        [InlineData(5.25,null)]
        [InlineData(3.00,6.25)]
        public void FilterByPriceReturnsItemsInPrice(double? min, double? max)
        {
            var all = Menu.All;

            var x = Menu.FilterByPrice(all,min,max);

            foreach(IOrderItem item in x)
            {
                if(min == null && max == null)
                {
                    Assert.Equal(15, x.Count());
                }
                else if(min == null)
                {
                    Assert.True(item.Price <= max);
                }
                else if (max == null)
                {
                    Assert.True(item.Price >= min);
                }
                else
                {
                    Assert.True(min <= item.Price && item.Price <= max);
                }
            }

        }

        [Theory]
        [InlineData(null, null)]
        [InlineData(null, 10.00)]
        [InlineData(5.25, null)]
        [InlineData(3.00, 6.25)]
        public void FilterByCaloriesReturnsItemsInCalories(uint? min, uint? max)
        {
            var all = Menu.All;

            var x = Menu.FilterByCalories(all, min, max);
            foreach (IOrderItem item in x)
            {
                if (min == null && max == null)
                {
                    Assert.Equal(15, x.Count());
                }
                else if (min == null)
                {
                    Assert.True(item.Calories <= max);
                }
                else if (max == null)
                {
                    Assert.True(item.Calories >= min);
                }
                else
                {
                    Assert.True(min <= item.Calories && item.Calories <= max);
                }
            }

        }


        [Theory]
        [InlineData("Entree")]
        [InlineData("Side")]
        [InlineData("Drink")]
        public void FilterByCategoryReturnsItemsInCategory(string type)
        {
            var all = Menu.All;
            var t = Menu.TypeOfItems;

            var x = Menu.FilterByCategory(all, t);



            foreach (IOrderItem item in x)
            {
                if(type == "Entree" && t.Contains(type))
                {
                    Assert.True(item is Entree);
                }
                else if(type == "Side" && t.Contains(type))
                {
                    Assert.True(item is Side && t.Contains(type));
                }
                else
                {
                    Assert.True(item is Drink && t.Contains(type));
                }
            }
            

        }

    }

}
