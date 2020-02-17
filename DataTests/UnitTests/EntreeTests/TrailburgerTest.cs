using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TrailBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new TrailBurger();
            Assert.Equal(4.50, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new TrailBurger();
            Assert.Equal<uint>(288, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new TrailBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new TrailBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new TrailBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold ketchup", burger.SpecialInstructions);
            Assert.Contains("hold mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new TrailBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold cheese", burger.SpecialInstructions);
            Assert.Contains("hold pickle", burger.SpecialInstructions);
        }
    }
}