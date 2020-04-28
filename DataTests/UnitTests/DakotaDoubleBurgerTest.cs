﻿using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class DakotaDoubleBurgerTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Equal(5.20, burger.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Equal<uint>(464, burger.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var burger = new DakotaDoubleBurger();
            Assert.Empty(burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Bun = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold bun", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Ketchup = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Ketchup", instruction);
            });
        }

        [Fact]
        public void HoldingMustardShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Mustard = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Mustard", instruction);
            });
        }

        [Fact]
        public void HoldingPickleShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Pickle = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Pickle", instruction);
            });
        }

        [Fact]
        public void HoldingCheeseShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Cheese = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Cheese", instruction);
            });
        }

        [Fact]
        public void HoldingMayoShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Mayo = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Mayo", instruction);
            });
        }

        [Fact]
        public void HoldingLettuceShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Lettuce = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Lettuce", instruction);
            });
        }

        [Fact]
        public void HoldingTomatoShouldAddInstruction()
        {
            var burger = new DakotaDoubleBurger();
            burger.Tomato = false;
            Assert.Collection(burger.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold Tomato", instruction);
            });
        }

        [Fact]
        public void HoldingKetchupAndMustardShouldAddTwoInstructions()
        {
            var burger = new DakotaDoubleBurger();
            burger.Ketchup = false;
            burger.Mustard = false;
            Assert.Contains("hold Ketchup", burger.SpecialInstructions);
            Assert.Contains("hold Mustard", burger.SpecialInstructions);
        }

        [Fact]
        public void HoldingBunCheeseAndPickleShouldAddThreeInstructions()
        {
            var burger = new DakotaDoubleBurger();
            burger.Bun = false;
            burger.Cheese = false;
            burger.Pickle = false;
            Assert.Contains("hold bun", burger.SpecialInstructions);
            Assert.Contains("hold Cheese", burger.SpecialInstructions);
            Assert.Contains("hold Pickle", burger.SpecialInstructions);
        }
    }
}
