using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class JerkedSodaTest
    {
        [Theory]
        [InlineData("CreamSoda")]
        [InlineData("OrangeSoda")]
        [InlineData("Sarsparilla")]
        [InlineData("BirchBeer")]
        [InlineData("RootBeer")]
        public void SodaFlavorEnumShouldContainFlavor(string name)
        {
            var names = Enum.GetNames(typeof(SodaFlavor));
            Assert.Contains(name, names);
        }

        [Fact]
        public void SodaFlavorEnumShouldHaveFiveValues()
        {
            var values = Enum.GetValues(typeof(SodaFlavor));
            Assert.Equal(5, values.Length);
        }

        [Theory]
        [InlineData("CreamSoda")]
        [InlineData("OrangeSoda")]
        [InlineData("Sarsparilla")]
        [InlineData("BirchBeer")]
        [InlineData("RootBeer")]
        public void ShouldBeAbleToSetFlavor(string name)
        {
            var flavor = (SodaFlavor)Enum.Parse(typeof(SodaFlavor), name);
            var soda = new JerkedSoda()
            {
                Flavor = flavor
            };
            Assert.Equal(flavor, soda.Flavor);
        }

        [Fact]
        public void ShouldBeIcedByDefault()
        {
            var soda = new JerkedSoda();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var soda = new JerkedSoda();
            soda.Ice = false;
            Assert.False(soda.Ice);
            soda.Ice = true;
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var soda = new JerkedSoda();
            Assert.Equal(Size.Small, soda.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var soda = new JerkedSoda();
            soda.Size = Size.Large;
            Assert.Equal(Size.Large, soda.Size);
            soda.Size = Size.Medium;
            Assert.Equal(Size.Medium, soda.Size);
            soda.Size = Size.Small;
            Assert.Equal(Size.Small, soda.Size);
        }

        [Theory]
        [InlineData(Size.Small, 1.59)]
        [InlineData(Size.Medium, 2.10)]
        [InlineData(Size.Large, 2.59)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var soda = new JerkedSoda()
            {
                Size = size
            };
            Assert.Equal(price, soda.Price);
        }

        [Theory]
        [InlineData(Size.Small, 110)]
        [InlineData(Size.Medium, 146)]
        [InlineData(Size.Large, 198)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint calories)
        {
            var soda = new JerkedSoda()
            {
                Size = size
            };
            Assert.Equal(calories, soda.Calories);
        }

        [Theory]
        [InlineData(false)]
        [InlineData(true)]
        public void ShouldHaveCorrectSpecialInstructionsForIce(bool ice)
        {
            var soda = new JerkedSoda()
            {
                Ice = ice
            };
            if (!ice) Assert.Collection(soda.SpecialInstructions, item => Assert.Equal("Hold Ice", item));
            if (ice) Assert.Empty(soda.SpecialInstructions);
        }
    }
}