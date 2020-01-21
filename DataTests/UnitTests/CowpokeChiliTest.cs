using System;
using System.Collections.Generic;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests
{
    public class CowpokeChiliTest
    {
        [Fact]
        public void DefaultPriceShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal(6.10, chili.Price);
        }

        [Fact]
        public void DefaultCaloriesShouldBeCorrect()
        {
            var chili = new CowpokeChili();
            Assert.Equal<uint>(171, chili.Calories);
        }

        [Fact]
        public void DefaultSpecialInstructionsShouldBeEmpty()
        {
            var chili = new CowpokeChili();
            Assert.Empty(chili.SpecialInstructions);
        }

        [Fact]
        public void HoldingCheeseShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold cheese", instruction);
            });
        }

        [Fact]
        public void HoldingSourCreamShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.SourCream = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold sour cream", instruction);
            });
        }

        [Fact]
        public void HoldingGreenOnionsShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.GreenOnions = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold green onions", instruction);
            });
        }

        [Fact]
        public void HoldingTortillaStripsShouldAddSpecialInstruction()
        {
            var chili = new CowpokeChili();
            chili.TortillaStrips = false;
            Assert.Collection(chili.SpecialInstructions, instruction =>
            {
                Assert.Equal("hold tortilla strips", instruction);
            });
        }

        [Fact]
        public void HoldCheeseAndTortillaStripsShouldAddTwoSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            chili.TortillaStrips = false;
            Assert.Contains("hold cheese", chili.SpecialInstructions);
            Assert.Contains("hold tortilla strips", chili.SpecialInstructions);
        }

        [Fact]
        public void HoldCheeseSourCreamAndGreenOnionsShouldAddThreeSpecialInstructions()
        {
            var chili = new CowpokeChili();
            chili.Cheese = false;
            chili.SourCream = false;
            chili.GreenOnions = false;
            Assert.Contains("hold cheese", chili.SpecialInstructions);
            Assert.Contains("hold sour cream", chili.SpecialInstructions);
            Assert.Contains("hold green onions", chili.SpecialInstructions);
        }
    }
}