using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
/*
namespace CowboyCafe.DataTests
{
    public class CowboyCoffeeTest
    {

        [Fact]
        public void ShouldNotBeIcedByDefault()
        {
            var coffee = new CowboyCoffee();
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldBeAbleToSetIce()
        {
            var coffee = new CowboyCoffee();
            coffee.Ice = true;
            Assert.True(coffee.Ice);
            coffee.Ice = false;
            Assert.False(coffee.Ice);
        }

        [Fact]
        public void ShouldBeCaffinatedByDefault()
        {
            var coffee = new CowboyCoffee();
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldBeAbleToSetDecaf()
        {
            var coffee = new CowboyCoffee();
            coffee.Decaf = true;
            Assert.True(coffee.Decaf);
            coffee.Decaf = false;
            Assert.False(coffee.Decaf);
        }

        [Fact]
        public void ShouldNotHaveRoomForCreamByDefault()
        {
            var coffee = new CowboyCoffee();
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeAbleToSetRoomForCream()
        {
            var coffee = new CowboyCoffee();
            coffee.RoomForCream = true;
            Assert.True(coffee.RoomForCream);
            coffee.RoomForCream = false;
            Assert.False(coffee.RoomForCream);
        }

        [Fact]
        public void ShouldBeSmallByDefault()
        {
            var coffee = new CowboyCoffee();
            Assert.Equal(Size.Small, coffee.Size);
        }

        [Fact]
        public void ShouldBeAbleToSetSize()
        {
            var coffee = new CowboyCoffee();
            coffee.Size = Size.Large;
            Assert.Equal(Size.Large, coffee.Size);
            coffee.Size = Size.Medium;
            Assert.Equal(Size.Medium, coffee.Size);
            coffee.Size = Size.Small;
            Assert.Equal(Size.Small, coffee.Size);
        }

        [Theory]
        [InlineData(Size.Small, 0.60)]
        [InlineData(Size.Medium, 1.10)]
        [InlineData(Size.Large, 1.60)]
        public void ShouldHaveCorrectPriceForSize(Size size, double price)
        {
            var coffee = new CowboyCoffee()
            {
                Size = size
            };
            Assert.Equal(price, coffee.Price);
        }

        [Theory]
        [InlineData(Size.Small, 3)]
        [InlineData(Size.Medium, 5)]
        [InlineData(Size.Large, 7)]
        public void ShouldHaveCorrectCaloriesForSize(Size size, uint calories)
        {
            var coffee = new CowboyCoffee()
            {
                Size = size
            };
            Assert.Equal(calories, coffee.Calories);
        }

        [Theory]
        [InlineData(false, false)]
        [InlineData(true, false)]
        [InlineData(false, true)]
        [InlineData(true, true)]
        public void ShouldHaveCorrectSpecialInstructionsForIceAndRoomForCream(bool ice, bool roomForCream)
        {
            var coffee = new CowboyCoffee()
            {
                Ice = ice,
                RoomForCream = roomForCream,
            };
            if (ice) Assert.Contains("Add Ice", coffee.SpecialInstructions);
            if (roomForCream) Assert.Contains("Room for Cream", coffee.SpecialInstructions);
            if (!ice && !roomForCream) Assert.Empty(coffee.SpecialInstructions);
            if (ice && !roomForCream || !ice && roomForCream) Assert.Single(coffee.SpecialInstructions);
            if (ice && roomForCream) Assert.Equal(2, coffee.SpecialInstructions.Count);
        }
    }
}
*/