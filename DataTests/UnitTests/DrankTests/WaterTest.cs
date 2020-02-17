using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class WaterTest
    {
        [Fact]
        public void ShouldBeIcedByDefault()
        {
            var water = new Water();
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var water = new Water();
            water.Ice = false;
            Assert.False(water.Ice);
            water.Ice = true;
            Assert.True(water.Ice);
        }

        [Fact]
        public void ShouldNotHaveLemonByDefault()
        {
            var water = new Water();
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeAbleToSetLemon()
        {
            var water = new Water();
            water.Lemon = true;
            Assert.True(water.Lemon);
            water.Lemon = false;
            Assert.False(water.Lemon);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var water = new Water();
            Assert.Equal(Size.Small, water.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var water = new Water();
            water.Size = Size.Large;
            Assert.Equal(Size.Large, water.Size);
            water.Size = Size.Medium;
            Assert.Equal(Size.Medium, water.Size);
            water.Size = Size.Small;
            Assert.Equal(Size.Small, water.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.12)]
        [InlineData(Size.Medium, 0.12)]
        [InlineData(Size.Large, 0.12)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var water = new Water()
            {
                Size = size
            };
            Assert.Equal(price, water.Price);
        }

        [Theory]
        [InlineData(Size.Small, 0)]
        [InlineData(Size.Medium, 0)]
        [InlineData(Size.Large, 0)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint calories)
        {
            var water = new Water()
            {
                Size = size
            };
            Assert.Equal(calories, water.Calories);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void ShouldHaveCorrectSpecialInstructionsForIceAndLemon(bool ice, bool lemon)
        {
            var water = new Water()
            {
                Ice = ice,
                Lemon = lemon,
            };
            if (!ice) Assert.Contains("Hold Ice", water.SpecialInstructions);
            if (lemon) Assert.Contains("Add Lemon", water.SpecialInstructions);
            if (ice && !lemon) Assert.Empty(water.SpecialInstructions);
            if (ice && lemon || !ice && !lemon) Assert.Single(water.SpecialInstructions);
            if (!ice && lemon) Assert.Equal(2, water.SpecialInstructions.Count);
        }
    }
}
