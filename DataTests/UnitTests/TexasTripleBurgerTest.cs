using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class TexasTripleBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new TexasTripleBurger();
            Assert.Equal(6.45, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new TexasTripleBurger();
            Assert.Equal<uint>(698, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new TexasTripleBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingMayoShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Mayo = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold mayo", instruction);
            });
        }

        [Fact]
        public void HoldingLettuceShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Lettuce = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold lettuce", instruction);
            });
        }

        [Fact]
        public void HoldingTomatoShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Tomato = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold tomato", instruction);
            });
        }

        [Fact]
        public void HoldingBaconShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Bacon = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bacon", instruction);
            });
        }

        [Fact]
        public void HoldingEggShouldAddInstruction()
        {
            var burger = new TexasTripleBurger();
            burger.Egg = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold egg", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new TexasTripleBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold ketchup", burger.SpecialInstructions);
            Assert.Contains("hold mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new TexasTripleBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold cheese", burger.SpecialInstructions);
            Assert.Contains("hold pickle", burger.SpecialInstructions);
        }
    }
}